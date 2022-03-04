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

namespace Elevators_Tilin.View
{
    public partial class FrmVehicle : Form
    {
        public FrmVehicle()
        {
            InitializeComponent();
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

        private void FrmVehicle_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnRegisterVehicle_Click(object sender, EventArgs e)
        {
            if (txtPlateVehicle.Text == string.Empty || txtBrand.Text == string.Empty || txtModel.Text == string.Empty || txtYear.Text == string.Empty || cmbGas.Text.Length == 0)
            {
                MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string plateVehicle = txtPlateVehicle.Text;
                string brand = txtBrand.Text;
                string model = txtModel.Text;
                int year = Convert.ToInt32(txtYear.Text);
                string gas = cmbGas.Text;


                using (var db = new SIAL_DBContext())
                {
                    List<Automovil> vehicles = db.Automovils.ToList();
                    foreach (var item in vehicles)
                    {
                        if (item.Placa == plateVehicle)
                        {
                            MessageBox.Show("El numero de placa ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    Automovil new_vehicle = new Automovil
                    {
                        Anio = year,
                        Combustuble = gas,
                        Marca = brand,
                        Modelo = model,
                        Placa = plateVehicle,
                        ContratoInicio = dtpStartcontract.Value,
                        ContratoFinal = dtpFinishcontract.Value
                    };
                    db.Add(new_vehicle);
                    db.SaveChanges();
                    MessageBox.Show("Vehiculo registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                Clear();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using(var db = new SIAL_DBContext())
            {
                List<Automovil> vehicle = db.Automovils.ToList();
                List<Automovil> validation = vehicle.Where(x => x.Placa == txtPlateVehicle.Text).ToList();
                
                if (txtBrand.Text == string.Empty || txtPlateVehicle.Text == string.Empty || txtModel.Text == string.Empty || txtYear.Text == string.Empty )
                {
                    MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(validation.Count < 0)
                {
                    MessageBox.Show("El numero de placa no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach(var item in vehicle)
                    {
                        if(item.Placa == txtPlateVehicle.Text)
                        {
                            item.Marca = txtBrand.Text;
                            item.Modelo = txtModel.Text;
                            item.Anio = Convert.ToInt32(txtYear.Text);
                            item.Combustuble = cmbGas.Text;
                            item.ContratoInicio = dtpStartcontract.Value;
                            item.ContratoFinal = dtpFinishcontract.Value;
                            db.SaveChanges();
                            MessageBox.Show("Vehiculo actualizado correctamente", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            break;
                        }
                    }
                }
            }
        }
        private void Clear()
        {
            txtPlateVehicle.Text = "";
            txtBrand.Text = "";
            txtModel.Text = "";
            txtYear.Text = "";
            cmbGas.Text = "";
        }

    }
}

