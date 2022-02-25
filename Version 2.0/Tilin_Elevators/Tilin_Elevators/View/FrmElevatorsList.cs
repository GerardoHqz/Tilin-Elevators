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
//using Microsoft.Office.Interop.Excel;
//using objExcel = Microsoft.Office.Interop.Excel;

namespace Elevators_Tilin.View
{
    public partial class FrmElevatorsList : Form
    {
        public FrmElevatorsList()
        {
            InitializeComponent();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            excel();
        }

        private void copyAlltoClipboard()
        {
            //to remove the first blank column from datagridview
            dgv.RowHeadersVisible = false;
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        private void GenerateDGV()
        {

            dgv.Columns.Clear();

            if (cmbType.Text == "Elevador")
            {
                DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
                col1.HeaderText = "ID";
                col1.Width = 50;
                dgv.Columns.Add(col1);


                DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
                col2.HeaderText = "No. Equipo";
                col2.Width = 125;
                dgv.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
                col3.HeaderText = "Marca";
                col3.Width = 120;
                dgv.Columns.Add(col3);

                DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
                col4.HeaderText = "Contrato Inicio";
                col4.Width = 175;
                dgv.Columns.Add(col4);

                DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
                col5.HeaderText = "Contrato Final";
                col5.Width = 175;
                dgv.Columns.Add(col5);

                DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
                col6.HeaderText = "Direccion";
                col6.Width = 250;
                dgv.Columns.Add(col6);

                DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
                col7.HeaderText = "Velocidad";
                col7.Width = 80;
                dgv.Columns.Add(col7);

                DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
                col8.HeaderText = "Voltaje";
                col8.Width = 80;
                dgv.Columns.Add(col8);

                DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
                col9.HeaderText = "Niveles";
                col9.Width = 80;
                dgv.Columns.Add(col9);

                ViewInformationEquip();

            }
            else
            {
                DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
                col1.HeaderText = "ID";
                col1.Width = 50;
                dgv.Columns.Add(col1);


                DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
                col2.HeaderText = "Placa";
                col2.Width = 125;
                dgv.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
                col3.HeaderText = "Año";
                col3.Width = 60;
                dgv.Columns.Add(col3);

                DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
                col4.HeaderText = "Contrato Inicio";
                col4.Width = 175;
                dgv.Columns.Add(col4);

                DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
                col5.HeaderText = "Contrato Final";
                col5.Width = 175;
                dgv.Columns.Add(col5);

                DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
                col6.HeaderText = "Marca";
                col6.Width = 80;
                dgv.Columns.Add(col6);

                DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
                col7.HeaderText = "Modelo";
                col7.Width = 100;
                dgv.Columns.Add(col7);

                DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
                col8.HeaderText = "Combustible";
                col8.Width = 100;
                dgv.Columns.Add(col8);

                ViewInformationVehicle();

            }

        }

        private void ConfigurationTableEquip(List<Equipo> equip)
        {
            //limpiando tabla
            dgv.Rows.Clear();

            //Agregando informacion
            foreach (var element in equip)
            {
                dgv.Rows.Add(
                        element.Id,
                        element.NumeroSerie,
                        element.Marca,
                        element.ContratoInicio,
                        element.ContratoFinal,
                        element.Direccion,
                        element.Velocidad,
                        element.Voltaje,
                        element.Niveles
                    );
            }
        }
        private void ViewInformationEquip()
        {
            using (var db = new SIAL_DBContext())
            {
                List<Equipo> auxEquip = db.Equipos.ToList();
                List<Equipo> part = auxEquip.Where(x => (x.NumeroSerie.ToLower().Contains(txtName.Text.ToLower()))).ToList();
                ConfigurationTableEquip(part);
            }
        }

        private void ConfigurationTableVehicle(List<Automovil> auxAutomovil)
        {
            //limpiando tabla
            dgv.Rows.Clear();

            //Agregando informacion
            foreach (var element in auxAutomovil)
            {
                dgv.Rows.Add(
                        element.Id,
                        element.Placa,
                        element.Anio,
                        element.ContratoInicio,
                        element.ContratoFinal,
                        element.Marca,
                        element.Modelo,
                        element.Combustuble
                    );
            }
        }

        private void ViewInformationVehicle()
        {
            using (var db = new SIAL_DBContext())
            {
                List<Automovil> auxVehicle = db.Automovils.ToList();
                List<Automovil> part = auxVehicle.Where(x => (x.Placa.ToLower().Contains(txtName.Text.ToLower()))).ToList();
                ConfigurationTableVehicle(part);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GenerateDGV();
        }

        private void excel()
        {
            //objExcel.Application objAplicacion = new objExcel.Application();
            //Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
            //Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;

            //foreach (DataGridViewColumn columna in dgv.Columns)
            //{
            //    objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
            //    foreach (DataGridViewRow fila in dgv.Rows)
            //    {
            //        objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
            //    }
            //}
            //objAplicacion.Visible = true;
        }
    }
}
