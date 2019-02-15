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
    public partial class CrearProcedure : Form
    {
        DBStuff tool = new DBStuff();
        public CrearProcedure()
        {

            InitializeComponent();
            string q = "select routinename as Nombre, text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'P'";
            string qf = "select routinename as Nombre, text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'F'";

            tool.fillDataGrid(dgvproc, q);
            tool.fillDataGrid(dgvfunc, qf);
        }

        private void crearproc_Click(object sender, EventArgs e)
        {
            string q = proc.Text;
            tool.sendCmd(q);
            tool.fillDataGrid(dgvproc,"select routinename as Nombre, text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'P'");
        }

        private void crearfunc_Click(object sender, EventArgs e)
        {
            string q = func.Text;
            tool.sendCmd(q);
            tool.fillDataGrid(dgvfunc, "select routinename as Nombre, text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'F'");
        }
    }
}
