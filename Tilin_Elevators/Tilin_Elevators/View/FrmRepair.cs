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
    public partial class FrmRepair : Form
    {
        public FrmRepair()
        {
            InitializeComponent();
        }

        private void FrmRepair_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ChargerProducts();
            cmbParts.Text = "";
        }

        //Para cambiar los botones del color correspondiente ඞඞඞ ඞ
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

        //Añadiendo funcion de cargar datos de repuestos
        private void ChargerProducts()
        {
            var db = new SIAL_DBContext();
            List<Repuesto> repuestos = db.Repuestos.ToList();
            //Cargando datos al cmb
            cmbParts.DataSource = repuestos;
            cmbParts.DisplayMember = "Nombre";
            cmbParts.ValueMember = "Id";
        }

        //Añadiendo funcion para añadir productos al dgv
        private void AddProduct()
        {
            try
            {
                var db = new SIAL_DBContext();
                List<Repuesto> repuestos = db.Repuestos.ToList();
                int cant = Convert.ToInt32(txtQuantity.Text);
                List<Repuesto> exist = repuestos.Where(x => x.Nombre == cmbParts.Text && x.Cantidad >= cant).ToList();
                bool verification = cant > 0;
                if (cant < 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a 0");
                }
                else if (verification && exist.Count() > 0)
                {
                    dgvParts.Rows.Add(cmbParts.Text, cant);
                }
                else
                {
                    MessageBox.Show("No hay suficientes productos en stock");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, verifique los datos");
            }
        }

        //Funciones para agregar el registro de mantenimiento
        private void Repair()
        {
            var db = new SIAL_DBContext();
            List<Reparacion> reparaciones = db.Reparacions.ToList();
            List<Equipo> equipos = db.Equipos.ToList();
            List<Equipo> exist = equipos.Where(u => u.NumeroSerie == txtEquipNumber.Text).ToList();
            List<Automovil> auto = db.Automovils.ToList();
            List<Automovil> exist2 = auto.Where(u => u.Placa == txtEquipNumber.Text).ToList();

            bool verification = txtEquipNumber.Text.Length > 1 && cmbState.Text.Length > 1 && txtName.Text.Length > 1;
            bool band = true;
            bool band2 = true;

            //Validacion para los numeros registros no se repitan
            List<Reparacion> validation = reparaciones.Where(x => x.NumeroRegistro == Convert.ToInt32(txtRegister.Text)).ToList();

            if (validation.Count() > 0)
            {
                MessageBox.Show("El Numero de registro ya existe previamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verification && (exist.Count() > 0 || exist2.Count() > 0))
            {

                if (cmbType.Text == "Elevador")
                {
                    int id = 0;
                    foreach (var item in equipos)
                    {
                        if (item.NumeroSerie == txtEquipNumber.Text)
                        {
                            id = item.Id;
                        }
                        else
                        {
                            band = false;
                        }
                    }

                    //Añadiendo el registro reparacion
                    Reparacion reparacion = new Reparacion
                    {
                        FechaReparacion = dtpRepair.Value,
                        NumeroSerie = txtEquipNumber.Text,
                        Descripcion = txtDescription.Text,
                        Tecnico = txtName.Text,
                        Estado = cmbState.Text,
                        IdEquipo = id,
                        IdAutomovil = null
                    };
                    db.Add(reparacion);
                    db.SaveChanges();

                }
                else
                {
                    int id = 0;
                    foreach (var item in auto)
                    {
                        if (item.Placa == txtEquipNumber.Text)
                        {
                            id = item.Id;
                        }
                        else
                        {
                            band2 = false;
                        }
                    }

                    //Añadiendo el registro reparacion
                    Reparacion reparacion = new Reparacion
                    {
                        FechaReparacion = dtpRepair.Value,
                        NumeroSerie = txtEquipNumber.Text,
                        Descripcion = txtDescription.Text,
                        Tecnico = txtName.Text,
                        Estado = cmbState.Text,
                        IdEquipo = null,
                        IdAutomovil = id
                    };
                    db.Add(reparacion);
                    db.SaveChanges();
                }

                //Mandamos los datos a ReparacionxRepuesto
                var db2 = new SIAL_DBContext();
                List<Reparacion> reparaciones2 = db2.Reparacions.ToList();
                int idReparacion = 0;
                foreach (var item in reparaciones2)
                {
                    if (item.NumeroSerie == txtEquipNumber.Text)
                    {
                        idReparacion = item.Id;
                    }
                }

                List<Repuesto> repuestos = db.Repuestos.ToList();
                for (int i = 0; i < dgvParts.Rows.Count - 1; i++)
                {
                    int idRepuesto = 0;
                    foreach (var item in repuestos)
                    {
                        var name = dgvParts.Rows[i].Cells[0].Value.ToString();
                        if (item.Nombre == name)
                        {
                            idRepuesto = item.Id;
                        }
                        if (item.Id == idRepuesto)
                        {
                            item.Cantidad = item.Cantidad - Convert.ToInt32(dgvParts.Rows[i].Cells[1].Value);
                            db.Update(item);
                            db.SaveChanges();
                        }
                    }
                    //Añadiendo el registro repuesto
                    ReparacionxRepuesto repuesto2 = new ReparacionxRepuesto
                    {
                        IdReparacion = idReparacion,
                        IdRepuesto = idRepuesto,
                    };
                    db.Add(repuesto2);
                    db.SaveChanges();
                }

                MessageBox.Show("Reparacion registrada correctamente!", "SIAL", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Numero de placa/serie incorrecto o datos erroneos!", "SIAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            txtEquipNumber.Text = "";
            txtDescription.Text = "";
            txtName.Text = "";
            cmbState.Text = "";
            dgvParts.Rows.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
            cmbParts.Text = "";
            txtQuantity.Text = "";
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            try
            {
                Repair();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, verifique los datos");
                Clear();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new SIAL_DBContext())
            {
                List<Reparacion> repairs = db.Reparacions.ToList();
                //Primera validacion para saber si existe el equipo
                List<Reparacion> exist = repairs.Where(x => x.NumeroSerie == txtEquipNumber.Text).ToList();
                //Segunda validacion para saber si existe el numero de registro del mantenimiento
                List<Reparacion>exist2 = repairs.Where(x => x.NumeroRegistro == Convert.ToInt32(txtRegister.Text)).ToList();
                if (exist.Count > 0)
                {
                    foreach (var item in repairs)
                    {
                        if (item.NumeroSerie == txtEquipNumber.Text)
                        {
                            item.FechaReparacion = dtpRepair.Value;
                            item.NumeroSerie = txtEquipNumber.Text;
                            item.Descripcion = txtDescription.Text;
                            item.Tecnico = txtName.Text;
                            item.Estado = cmbState.Text;
                            item.NumeroRegistro = Convert.ToInt32(txtRegister.Text);
                            db.SaveChanges();
                            MessageBox.Show("Registro actualizado correctamente", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
