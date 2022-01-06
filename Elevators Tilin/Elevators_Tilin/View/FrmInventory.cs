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
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        //Para cambiar los botones del color correspondiente
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

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool verification =
                txtNameSpareParts.Text.Length > 0 &&
                txtNumberSparePart.Text.Length > 0 &&
                txtAmount.Text.Length > 0 &&
                txtDescriptionInventory.Text.Length > 0 &&
                txtManufacturer.Text.Length > 0 &&
                txtSupply.Text.Length > 0 &&
                txtModel.Text.Length > 0;
                

            if (verification)
            {
                RegisterInventory();
                Clear();
            }
            else
            {
                MessageBox.Show("Rellene y verifique que los datos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void RegisterInventory()
        {
            //Creando y guardando los datos en la base de datos
            string nameSpareParts = txtNameSpareParts.Text;
            string numberSparePart = txtNumberSparePart.Text; 
            int amount = Convert.ToInt32(txtAmount.Text);   
            string descriptionInventory = txtDescriptionInventory.Text;
            string manufacturer = txtManufacturer.Text;
            string model = txtModel.Text;
            string timesupply = txtSupply.Text;

            using (var db = new SIAL_DBContext())
            {
                //obtenieniendo el id
                List<Repuesto> repuesto = db.Repuestos.ToList();
                List<Repuesto> valid = repuesto.Where(r => r.Nombre == txtNameSpareParts.Text).ToList();
                
                if (valid.Count > 0)
                {
                    MessageBox.Show("El repuesto ya existe", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    //agregando el registro de mantenimiento
                        Repuesto unRepuesto = new Repuesto
                        {
                            Nombre = nameSpareParts,
                            NumeroSerie = numberSparePart,
                            Cantidad = amount,
                            Descripcion = descriptionInventory,
                            Fabricante = manufacturer,
                            Modelo = model,
                            TiempoSuministro = timesupply
                        };
                        
                        db.Add(unRepuesto);
                        db.SaveChanges();
                        MessageBox.Show("Repuesto agregado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                }
            }
        }
        

        private void Clear()
        {
            txtNameSpareParts.Text = "";
            txtNumberSparePart.Text = "";
            txtAmount.Text = "";
            txtDescriptionInventory.Text = "";
            txtManufacturer.Text = "";
            txtSupply.Text = "";
            txtModel.Text = "";
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
