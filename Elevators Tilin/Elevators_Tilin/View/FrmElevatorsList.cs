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
    public partial class FrmElevatorsList : Form
    {
        public FrmElevatorsList()
        {
            InitializeComponent();
        }

        private void GenerateDGV(){
            dgvInformation.Columns.Clear();
            if(cmbType.Text == "Elevador"){
                DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
                col1.HeaderText = "ID";
                dgv.Columns.Add(col1);

                DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
                col2.HeaderText = "Marca";
                dgv.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
                col3.HeaderText = "No. Serie";
                dgv.Columns.Add(col3);

                DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
                col4.HeaderText = "Contrato Inicio";
                dgv.Columns.Add(col4);

                DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
                col5.HeaderText = "Contrato Final";
                dgv.Columns.Add(col5);

                DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
                col6.HeaderText = "Direccion";
                dgv.Columns.Add(col6);

                DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
                col7.HeaderText = "Velocidad";
                dgv.Columns.Add(col7);

                DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
                col8.HeaderText = "Voltaje";
                dgv.Columns.Add(col8);

                DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
                col9.HeaderText = "Niveles";
                dgv.Columns.Add(col9);
            }
            else{
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GenerateDGV();
        }
    }
}
