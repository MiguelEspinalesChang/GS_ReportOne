using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaVista.Vistas
{
    public partial class AgregarMedidor : Form
    {
        public AgregarMedidor()
        {
            InitializeComponent();
        }

        private void AgregarMedidor_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //https://www.youtube.com/watch?v=rv4IJfjD8K0
        //https://social.msdn.microsoft.com/Forums/es-ES/cf1fdace-f4f0-4f9a-915d-02191ad56b2b/recoger-datos-de-una-fila-de-un-datagrid?forum=vcses


    }
}
