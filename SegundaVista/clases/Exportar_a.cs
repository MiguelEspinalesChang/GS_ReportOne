using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace SegundaVista.clases
{
    class Exportar_a
    {
        public void Exel(DataGridView tabla, string Nombre_Medidor)
        {
            //creamos un libro de excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook libroExcel = app.Workbooks.Add(Type.Missing);
            //creamos una hoja de calculo en el documento de excel
            Microsoft.Office.Interop.Excel._Worksheet hojaCalculo = null;
            hojaCalculo = libroExcel.Sheets["Hoja Del Datos 1"];
            hojaCalculo = libroExcel.ActiveSheet;
            hojaCalculo.Name = "Datos Del Medidor " + Nombre_Medidor;
            //agregamos los encabezado de las columnas
            for (int i = 1; i < tabla.Columns.Count + 1; i++)
            {
                hojaCalculo.Cells[i, 1] = tabla.Columns[i - 1].HeaderText;
            }
            //agregamos los datos de las filas
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                //agregamos los datos de las Columnas
                for (int j = 0; j < tabla.Columns.Count; j++)
                {
                    hojaCalculo.Cells[i + 2, j + 1] = tabla.Rows[i].Cells[j].Value.ToString();
                }
            }
            //guardar el alchivo de excel
            var guardarExcel = new SaveFileDialog();
            guardarExcel.FileName = "Datos Medidor " + Nombre_Medidor + " " + DateTime.Now.ToString();
            guardarExcel.DefaultExt = ".xlsx";
            if (guardarExcel.ShowDialog() == DialogResult.OK)
            {
                hojaCalculo.SaveAs(guardarExcel.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
    }
}
