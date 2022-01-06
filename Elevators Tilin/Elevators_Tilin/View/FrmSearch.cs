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
using Validar_TextBox;

namespace Elevators_Tilin.View
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ChargerProducts();
            cmbUpdateName.Text = "";
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

        private void ChargerProducts(){
            var db = new SIAL_DBContext();
            List<Repuesto> repuestos = db.Repuestos.ToList();
            //Cargando datos al cmb
            cmbUpdateName.DataSource = repuestos;
            cmbUpdateName.DisplayMember = "Nombre";
            cmbUpdateName.ValueMember = "Id";

            var collection = new AutoCompleteStringCollection();
            foreach(var element in repuestos){
                collection.Add(element.Nombre);
            }

            cmbUpdateName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbUpdateName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbUpdateName.AutoCompleteCustomSource = collection;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
            Clear();
        }

        private void Update()
        {
            if (txtQuantity.Text != "")
            {
                int amount = Convert.ToInt32(txtQuantity.Text);
            
                var db = new SIAL_DBContext();
                List<Repuesto> repuestos = db.Repuestos.ToList();
                List<Repuesto> exist = repuestos.Where(x => x.Nombre == cmbUpdateName.Text).ToList();
                if (exist.Count > 0)
                {
                    foreach (Repuesto item in exist)
                    {
                        item.Cantidad += amount;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Se han actualizado los datos");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad");
            }
            
            
        }

        private void ConfigurationTable(List<Repuesto> auxProduct)
        {
            //limpiando tabla
            dgvInformation.Rows.Clear();

            //Agregando informacion
            foreach(var element in auxProduct)
            {
                dgvInformation.Rows.Add(
                        element.Id,
                        element.Nombre,
                        element.Cantidad,
                        element.Modelo,
                        element.Fabricante
                    );
            }
        }
        private void ViewInformation()
        {
            using (var db = new SIAL_DBContext())
            {
                List<Repuesto> auxRepuesto = db.Repuestos.ToList();
                List<Repuesto> part = auxRepuesto.Where(x => (x.Nombre.ToLower().Contains(cmbName.Text.ToLower()))).ToList();
                ConfigurationTable(part);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ViewInformation();
        }

        private void Clear(){
            txtQuantity.Text = "";
            cmbUpdateName.Text = "";
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
