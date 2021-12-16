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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        //Metodo para cambiar de colores los botones
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
            if (txtNumberRegister.Text == string.Empty || txtDirection.Text == string.Empty ||txtLevels.Text == string.Empty || txtSpeed.Text == string.Empty || txtVoltage.Text == string.Empty)
            {
                MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string numberRegister = txtNumberRegister.Text;
                string direction = txtDirection.Text;
                int levels = Convert.ToInt32(txtLevels.Text);
                double speed = Convert.ToDouble(txtSpeed.Text);
                double voltage = Convert.ToDouble(txtVoltage.Text);
                DateTime Fecha_inicio= dtpStartcontract.Value;
                DateTime Fecha_fin = dtpFinishcontract.Value;

                using (var db= new SIAL_DBContext())
                {
                    List<Equipo> elevators = db.Equipos.ToList();
                    foreach (var item in elevators)
                    {
                        if (item.NumeroSerie == numberRegister)
                        {
                            MessageBox.Show("El numero de serie ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    Equipo new_elevator = new Equipo
                    {   
                        ContratoFinal=Fecha_fin,
                        ContratoInicio=Fecha_inicio,
                        Direccion=direction,
                        Marca="",
                        Niveles=levels,
                        NumeroSerie=numberRegister,
                        Velocidad=speed,
                        Voltaje=voltage
                    };
                    db.Add(new_elevator);
                    db.SaveChanges();
                    MessageBox.Show( "Equipo registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                Clear();
            }
            
        }

        private void Clear()
        {
            txtNumberRegister.Text = "";
            txtDirection.Text = "";
            txtLevels.Text = "";
            txtSpeed.Text = "";
            txtVoltage.Text= "";
            dtpStartcontract.Value=DateTime.Now;
            dtpFinishcontract.Value=DateTime.Now;
        }
    }
}

