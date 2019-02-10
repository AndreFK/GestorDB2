using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2;

namespace DB2Test
{
    public partial class ListarTablas : Form
    {

        DBStuff tool = new DBStuff();

        public ListarTablas()
        {
            InitializeComponent();

            string query = "select name from sysibm.systables where creator  = 'USUARIO'";
            tool.fillComboDB(this.tables, query);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from " + tables.Text;
            tool.fillDataGrid(dgv, query);
        }

        private void mostrarDDlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrarTablas form = new BorrarTablas();
            form.Show();
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarTriggers form = new ListarTriggers();
            form.Show();
        }

        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarViews form = new ListarViews();
            form.Show();
        }
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearTablas form = new CrearTablas();
            form.Show();
        }

        /*private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarTablas form = new ListarTablas();
            form.Show();
        }*/

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificaTablas form = new ModificaTablas();
            form.Show();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarProcedures form = new ListarProcedures();
            form.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarIndices form = new ListarIndices();
            form.Show();
        }

        private void listarToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ListarViews form = new ListarViews();
            form.Show();
        }
    }
}
