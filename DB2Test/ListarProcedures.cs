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
    public partial class ListarProcedures : Form
    {
        DBStuff tool = new DBStuff();

        public ListarProcedures()
        {
            InitializeComponent();

            string query = "select routinename, routinetype from syscat.routines where definer = 'USUARIO'";

            tool.fillDataGrid(this.dgv, query);
            //tool.fillComboDB(procName, query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /*private void procName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "call " + procName.Text + "(?)";

            tool.callRout(dgv);
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarTablas form = new ListarTablas();
            form.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificaTablas form = new ModificaTablas();
            form.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarIndices form = new ListarIndices();
            form.Show();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}

