using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tilin_Elevators.ContextSIAL;
using Validar_TextBox;

namespace Elevators_Tilin.View
{
    public partial class FrmMaintenance : Form
    {
        public FrmMaintenance()
        {
            InitializeComponent();
        }

        private void FrmMaintenance_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Extras.ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Extras.ThemeColor.SecundaryColor;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //variable para validar que los campos esten llenos
            bool verification =
                txtEquipNumber.Text.Length > 0 &&
                txtDescription.Text.Length > 0 &&
                txtName.Text.Length > 0 &&
                cmbState.Text.Length > 1;

            if (verification)
            {
                Maintenance();
                Clear();
            }
            else
            {
                MessageBox.Show("Rellene y verifique que los datos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Maintenance()
        {
            //Creando y Guardando los datos en la base de datos
            string equipNumber = txtEquipNumber.Text;
            string description = txtDescription.Text;
            string name = txtName.Text;
            string state = cmbState.Text;
            DateTime date = dtpMaintain.Value;
            int numRegister = Convert.ToInt32(txtRegister.Text);

            using (var db = new SIAL_DBContext())
            {
                bool verify = true;
                bool verify2 = true;


                //obtenieniendo el id del equipo y/o automovil
                List<Equipo> equipos = db.Equipos.ToList();
                List<Automovil> automoviles = db.Automovils.ToList();
                List<Equipo> exist = equipos.Where(x => x.NumeroSerie == equipNumber).ToList();
                List<Automovil> exist2 = automoviles.Where(x => x.Placa == equipNumber).ToList();

                //Validacion para los numeros registros no se repitan
                List<Mantenimiento> maintent = db.Mantenimientos.ToList();
                List<Mantenimiento> validation = maintent.Where(x => x.NumeroRegistro == Convert.ToInt32(txtRegister.Text)).ToList();

                if(validation.Count() > 0)
                {
                    MessageBox.Show("El Numero de registro ya existe previamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (exist.Count() > 0)
                {
                    foreach (var item in equipos)
                    {
                        if (item.NumeroSerie == txtEquipNumber.Text)
                        {
                            Mantenimiento unMantenimiento = new Mantenimiento
                            {
                                FechaMantenimiento = date,
                                NumeroSerie = equipNumber,
                                Descripcion = description,
                                Tecnico = name,
                                Estado = state,
                                NumeroRegistro = numRegister,
                                IdEquipo = item.Id,
                                IdAutomovil = null
                            };
                            db.Add(unMantenimiento);
                            db.SaveChanges();
                            MessageBox.Show("Mantenimiento registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (exist2.Count() > 0)
                {
                    foreach (var item in automoviles)
                    {
                        if (item.Placa == txtEquipNumber.Text)
                        {
                            Mantenimiento unMantenimiento = new Mantenimiento
                            {
                                FechaMantenimiento = date,
                                NumeroSerie = equipNumber,
                                Descripcion = description,
                                Tecnico = name,
                                Estado = state,
                                NumeroRegistro=numRegister,
                                IdEquipo = null,
                                IdAutomovil = item.Id
                            };
                            db.Add(unMantenimiento);
                            db.SaveChanges();
                            MessageBox.Show("Mantenimiento registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El numero de serie no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Clear()
        {
            txtEquipNumber.Text = "";
            txtDescription.Text = "";
            txtName.Text = "";
            cmbState.Text = "";
            dtpMaintain.Value = DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new SIAL_DBContext())
            {
                List<Mantenimiento> mantenimientos = db.Mantenimientos.ToList();
                //Primera validacion para saber si existe el equipo
                List<Mantenimiento> exist = mantenimientos.Where(x => x.NumeroSerie == txtEquipNumber.Text).ToList();
                //Segunda validacion para saber si existe el numero de registro del mantenimiento
                List<Mantenimiento>exist2 = mantenimientos.Where(x => x.NumeroRegistro == Convert.ToInt32(txtRegister.Text) ).ToList();
                if (exist.Count > 0 && exist.Count > 0)
                {
                    foreach (var item in mantenimientos)
                    {
                        if (item.NumeroSerie == txtEquipNumber.Text)
                        {
                            item.FechaMantenimiento = dtpMaintain.Value;
                            item.NumeroSerie = txtEquipNumber.Text;
                            item.Descripcion = txtDescription.Text;
                            item.Tecnico = txtName.Text;
                            item.Estado = cmbState.Text;
                            item.NumeroRegistro = Convert.ToInt32(txtRegister.Text);
                            db.SaveChanges();
                            MessageBox.Show("Registro actualizado correctamente", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El numero de serie o numero de registro no existen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}

