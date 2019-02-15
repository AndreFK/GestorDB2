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
    public partial class CrearView : Form
    {
        DBStuff tool = new DBStuff();
        public CrearView()
        {
            InitializeComponent();
            string q = "select viewname as Nombre, text as DDL from syscat.views where owner = 'USUARIO'";
            tool.fillDataGrid(dgvproc, q);
        }

        private void crearproc_Click(object sender, EventArgs e)
        {
            string q = proc.Text;
            tool.sendCmd(q);
            tool.fillDataGrid(dgvproc, "select viewname as Nombre, text as DDL from syscat.views where owner = 'USUARIO'");
        }
    }
}
