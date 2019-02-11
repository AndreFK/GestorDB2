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
    public partial class BorrarViews : Form
    {
        DBStuff tool = new DBStuff();

        public BorrarViews()
        {
            InitializeComponent();
            string query = "select viewname as Nombre from syscat.views where owner = 'USUARIO'";
            string q = "select viewname from syscat.views where owner = 'USUARIO'";
            tool.fillComboDB(trame, q);
            tool.fillDataGrid(dgv, query);
        }

        private void trame_SelectedIndexChanged(object sender, EventArgs e)
        {
            string v = tool.PoC(trame.Text);
            string q = "select viewname as Nombre, text as Script from syscat.views where viewname = '" + trame.Text + "'";
            tool.fillDataGrid(dataGridView1, q);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryc = "select viewname as Nombre from syscat.views where owner = 'USUARIO'";
            string q = "select viewname from syscat.views where owner = 'USUARIO'";
            if (string.IsNullOrWhiteSpace(trame.Text))
            {
                System.Windows.Forms.MessageBox.Show("Seleccione un view a borrar");
            }
            else
            {

                string query = "drop view " + trame.Text;
                tool.sendCmd(query);
                System.Windows.Forms.MessageBox.Show(trame.Text + " borrado");
                trame.Text = "";
                trame.Items.Clear();
                dgv.DataSource = null;
                dgv.Update();
                dgv.Refresh();
                tool.fillComboDB(trame, q);
                tool.fillDataGrid(dgv, queryc);
            }
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

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       /* private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }*/

        private void mostrarDDLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       /* private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }*/

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mostrarDDLToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        /*private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }*/

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void mostrarDDLToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        /*private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }*/

        private void crearToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void mostrarDDLToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        /*private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }*/

        private void crearToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void mostrarDDLToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }
    }
}
