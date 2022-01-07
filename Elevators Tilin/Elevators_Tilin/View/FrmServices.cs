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
    public partial class FrmServices : Form
    {
        public FrmServices()
        {
            InitializeComponent();

        }
        public void ExportarDatos(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();
            
            exportarexcel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn columna in datalistado.Columns)
            {
                IndiceColumna++;
                exportarexcel.Cells[1, IndiceColumna] = columna.Name;
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow fila in datalistado.Rows)
            {
                IndeceFila++;
                IndiceColumna = 0;

                foreach (DataGridViewColumn columna in datalistado.Columns)
                {
                    IndiceColumna++;
                    exportarexcel.Cells[IndeceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarexcel.Visible = true;
        }
        private void BtnExcel_Click(object sender, EventArgs e)
        {
            
            ExportarDatos(dgvInformation);
        }
        
        //Para Mantenimientos
        private void ConfigurationTable(List<Mantenimiento> auxMaintenance)
        {
            //limpiando tabla
            dgvInformation.Rows.Clear();

            //Agregando informacion
            foreach(var element in auxMaintenance)
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
            foreach(var element in auxRepair)
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
        private void ViewInformation(){
            var db = new SIAL_DBContext();
            if(cmbType.Text == "Reparaciones")
            {
                List<Reparacion> Repair = db.Reparacions.ToList();
                List<Reparacion> auxRepair = Repair.Where(x => (x.NumeroSerie.ToLower().Contains(txtName.Text.ToLower()))).ToList();
                ConfigurationTable2(Repair);
            }
            else
            {
                List<Mantenimiento> Maintenance = db.Mantenimientos.ToList();
                List<Mantenimiento> auxMaintenance = Maintenance.Where(x => (x.NumeroSerie.ToLower().Contains(txtName.Text.ToLower()))).ToList();
                ConfigurationTable(Maintenance);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ViewInformation();
        }
    }
}
