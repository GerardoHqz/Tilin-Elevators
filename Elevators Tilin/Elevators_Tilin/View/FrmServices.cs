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

        //
    }
}
