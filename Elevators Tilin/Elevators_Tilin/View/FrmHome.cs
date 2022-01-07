using Elevators_Tilin.Extras;
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
    public partial class FrmHome : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FrmHome()
        {
            InitializeComponent();
            random = new Random();
        }

        //metodo para cambiar de colores aleatoriamente la interfaz 
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTitle.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecundaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnClose.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMainMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        //Metodo para desplegaar los formularios hijos.
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(childForm);
            this.pnlPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRegister(), sender);
            lblTitle.Text = "Registrar Servicio";
            lblTitle.Location = new Point(300, 12);
            this.Show();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmVehicle(), sender);
            lblTitle.Text = "Registrar Automovil";
            lblTitle.Location = new Point(300, 12);
            this.Show();
        }

        private void BtnMaintenance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMaintenance(), sender);
            lblTitle.Text = "Mantenimiento";
            lblTitle.Location = new Point(300, 12);
            this.Show();
        }

        private void BtnRepair_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRepair(), sender);
            lblTitle.Text = "Reparaciones";
            lblTitle.Location = new Point(300, 12);
            this.Show();
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmInventory(), sender);
            lblTitle.Text = "Inventario";
            lblTitle.Location = new Point(300, 12);
            this.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSearch(), sender);
            lblTitle.Text = "Buscador";
            lblTitle.Location = new Point(300, 12);
            this.Show();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            lblTitle.Location = new Point(350, 12);
            pnlTitle.BackColor = Color.FromArgb(0, 150, 136);
            pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnClose.Visible = false;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmServices(), sender);
            lblTitle.Text = "Inventario";
            lblTitle.Location = new Point(300, 12);
            this.Show();
        }

        private void btnEquipments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmElevatorsList(), sender);
            lblTitle.Text = "Equipos";
            lblTitle.Location = new Point(300, 12);
            this.Show();
        }
    }
}
