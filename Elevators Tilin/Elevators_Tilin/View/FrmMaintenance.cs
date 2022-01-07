using Elevators_Tilin.ContextSIAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                using (var db = new SIAL_DBContext())
                {
                    bool verify = true;
                    bool verify2 = true;


                    //obtenieniendo el id del equipo y/o automovil
                    List<Equipo> equipos = db.Equipos.ToList();
                    List<Automovil> automoviles = db.Automovils.ToList();
                    List<Equipo> exist = equipos.Where(x => x.NumeroSerie == equipNumber).ToList();
                    List<Automovil> exist2 = automoviles.Where(x => x.Placa == equipNumber).ToList();

                    
                    // foreach (var item in equipos)
                    // {
                    //     if (item.NumeroSerie == equipNumber)
                    //     {

                    //         //agregando el registro de mantenimiento
                    //         Mantenimiento unMantenimiento = new Mantenimiento
                    //         {
                    //             FechaMantenimiento = date,
                    //             NumeroSerie = equipNumber,
                    //             Descripcion = description,
                    //             Tecnico = name,
                    //             Estado = state,
                    //             IdEquipo = item.Id,
                    //             IdAutomovil = null
                    //         };
                    //         db.Add(unMantenimiento);
                    //         db.SaveChanges();
                    //         MessageBox.Show("Mantenimiento registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //     }
                    //     else { verify = false; }
                    // }

                    // foreach (var item in automoviles)
                    // {
                    //     if (item.Placa == equipNumber)
                    //     {
                    //         //agregando el registro de mantenimiento
                    //         Mantenimiento unMantenimiento = new Mantenimiento
                    //         {
                    //             FechaMantenimiento = date,
                    //             NumeroSerie = equipNumber,
                    //             Descripcion = description,
                    //             Tecnico = name,
                    //             Estado = state,
                    //             IdEquipo = null,
                    //             IdAutomovil = item.Id
                    //         };
                    //         db.Add(unMantenimiento);
                    //         db.SaveChanges();
                    //         MessageBox.Show("Mantenimiento registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //     }
                    //     else { verify2 = false; }

                    // }


                    // if (!verify && !verify2)
                    // {
                    // MessageBox.Show("El numero de serie no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // }


                
                
                    //Si pasa error entonces ocupamos dos if validando si es equipo o automovil
                if(exist.Count() > 0 )
                {
                    foreach(var item in equipos){
                        if(item.NumeroSerie == txtEquipNumber.Text){
                            Mantenimiento unMantenimiento = new Mantenimiento
                                {
                                    FechaMantenimiento = date,
                                    NumeroSerie = equipNumber,
                                    Descripcion = description,
                                    Tecnico = name,
                                    Estado = state,
                                    IdEquipo = item.Id,
                                    IdAutomovil = null
                                };
                            db.Add(unMantenimiento);
                            db.SaveChanges();
                            MessageBox.Show("Mantenimiento registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if(exist2.Count() > 0)
                {
                    foreach(var item in automoviles)
                    {
                        if(item.Placa == txtEquipNumber.Text)
                        {
                            Mantenimiento unMantenimiento = new Mantenimiento
                                {
                                    FechaMantenimiento = date,
                                    NumeroSerie = equipNumber,
                                    Descripcion = description,
                                    Tecnico = name,
                                    Estado = state,
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
    }
}  
