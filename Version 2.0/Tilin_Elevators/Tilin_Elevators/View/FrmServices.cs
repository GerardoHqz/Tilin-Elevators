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
using Microsoft.Office.Interop.Excel;
using objExcel = Microsoft.Office.Interop.Excel;


namespace Elevators_Tilin.View
{
    public partial class FrmServices : Form
    {
        public FrmServices()
        {
            InitializeComponent();

        }
        private void excel()
        {
            objExcel.Application objAplicacion = new objExcel.Application();
            Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;

            foreach (DataGridViewColumn columna in dgvInformation.Columns)
            {
                objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                foreach (DataGridViewRow fila in dgvInformation.Rows)
                {
                    objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
                }
            }
            objAplicacion.Visible = true;
        }
        private void BtnExcel_Click(object sender, EventArgs e)
        {
            excel();
        }

        //Para Mantenimientos
        private void ConfigurationTable(List<Mantenimiento> auxMaintenance)
        {
            //limpiando tabla
            dgvInformation.Rows.Clear();

            //Agregando informacion 
            foreach (var element in auxMaintenance)
            {
                dgvInformation.Rows.Add(
                        element.Id,
                        element.NumeroSerie,
                        element.Estado,
                        element.Tecnico,
                        element.FechaMantenimiento,
                        element.Descripcion
                    );
            }
        }

        //Para Reparaciones
        private void ConfigurationTable2(List<Reparacion> auxRepair)
        {
            //limpiando tabla
            dgvInformation.Rows.Clear();

            //Agregando informacion
            foreach (var element in auxRepair)
            {
                dgvInformation.Rows.Add(
                        element.Id,
                        element.NumeroSerie,
                        element.Estado,
                        element.Tecnico,
                        element.FechaReparacion,
                        element.Descripcion
                    );
            }
        }
        private void ViewInformation()
        {
            using (var db = new SIAL_DBContext())
            {
                if (cmbType.Text == "Reparaciones")
                {
                    List<Reparacion> Repair = db.Reparacions.ToList();
                    List<Reparacion> auxRepair = Repair.Where(x => (x.NumeroSerie.ToLower().Contains(txtName.Text.ToLower()))).ToList();
                    ConfigurationTable2(auxRepair);
                }
                else if (cmbType.Text == "Mantenimientos")
                {
                    List<Mantenimiento> Maintenance = db.Mantenimientos.ToList();
                    List<Mantenimiento> auxMaintenance = Maintenance.Where(x => (x.NumeroSerie.ToLower().Contains(txtName.Text.ToLower()))).ToList();
                    ConfigurationTable(auxMaintenance);
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ViewInformation();
        }
    }
}

