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
    public partial class BorrarTablas : Form
    {
        DBStuff tool = new DBStuff();

        public BorrarTablas()
        {
            InitializeComponent();
            string query = "select name from sysibm.systables where creator  = 'USUARIO'";
            tool.fillComboDB(this.tabName, query);
            tool.fillDataGrid(dgv, query);
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tabName.Text))
            {

                string query = "drop table " + tabName.Text;
                System.Windows.Forms.MessageBox.Show("Tabla " + tabName.Text + " ha sido borrada");
                tool.sendCmd(query);
                tabName.Text = "";
                tool.fillComboDB(tabName, "select name from sysibm.systables where creator  = 'USUARIO'");
                tool.fillDataGrid(dgv, "select name from sysibm.systables where creator  = 'USUARIO'");

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No ha seleccionado una tabla");
            }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarTablas form = new ListarTablas();
            form.Show();
        }


        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearTablas form = new CrearTablas();
            form.Show();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarProcedures form = new ListarProcedures();
            form.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificaTablas form = new ModificaTablas();
            form.Show();
        }
    }
}
