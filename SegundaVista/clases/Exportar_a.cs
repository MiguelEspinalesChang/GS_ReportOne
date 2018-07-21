using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

namespace SegundaVista.clases
{
    class Exportar_a
    {
        public void Exel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application hojaExcel = new Microsoft.Office.Interop.Excel.Application();
            hojaExcel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridView col in tabla.Columns) //Columnas
            {
                IndiceColumna++;
                hojaExcel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndiceFila = 0;

            foreach (DataGridView row in tabla.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;
                foreach (DataGridView col in tabla.Columns)
                {
                    IndiceColumna++;
                    hojaExcel.Cells[IndiceFila + 1, IndiceColumna] = row.cells;
                }
            }
        }        
    }
}
