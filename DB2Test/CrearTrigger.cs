using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB2Test
{
    public partial class CrearTrigger : Form
    {

        DBStuff tool = new DBStuff();

        public CrearTrigger()
        {
            InitializeComponent();
            string q = "select trigname as Nombre, text ad DDL from syscat.triggers where owner = 'USUARIO'";
            tool.fillDataGrid(dgvproc, q);
        }

        private void crearproc_Click(object sender, EventArgs e)
        {
            string q = proc.Text;
            tool.sendCmd(q);
            tool.fillDataGrid(dgvproc, "select trigname as Nombre, text ad DDL from syscat.triggers where owner = 'USUARIO'");
        }
    }
}
