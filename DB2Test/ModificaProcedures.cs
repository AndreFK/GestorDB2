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
    public partial class ModificaProcedures : Form
    {

        DBStuff tool = new DBStuff();

        public ModificaProcedures()
        {
            InitializeComponent();
            string query = "select routinename as Nombre, routinetype as Tipo, text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'P'";
            string q = "select routinename as Nombre, routinetype as Tipo, text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'F'";

            string queryc = "select routinename from syscat.routines where definer = 'USUARIO' and routinetype = 'P'";
            string qc = "select routinename from syscat.routines where definer = 'USUARIO' and routinetype = 'F'";

            tool.fillDataGrid(dgvpk, query);
            tool.fillDataGrid(dataGridView1, q);

            tool.fillComboDB(pk, queryc);
            tool.fillComboDB(fk, qc);
        }

        private void addpk_Click(object sender, EventArgs e)
        {
            string tab = "select text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'P' and routinename = '"+ textBox1.Text+"'";
            string query = "drop procedure " + textBox1.Text;
            tool.dropCmd(query, tool.ddl(tab));
            tool.sendCmd(textBox1.Text);
            tool.fillDataGrid(dgvpk, "select routinename as Nombre, routinetype as Tipo, text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'P'");
        }

        private void addfk_Click(object sender, EventArgs e)
        {
            string tab = "select text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'F' and routinename = '" + textBox2.Text + "'";
            string query = "drop function " + textBox2.Text;
            tool.dropCmd(query, tool.ddl(tab));
            tool.sendCmd(textBox1.Text);
            tool.fillDataGrid(dgvpk, "select routinename as Nombre, routinetype as Tipo, text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'F'");
        }

        private void pk_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = tool.ddl("select text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'P' and routinename = '"+ textBox1.Text+"'");
        }

        private void fk_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = tool.ddl("select text as DDL from syscat.routines where definer = 'USUARIO' and routinetype = 'F' and routinename = '" + textBox2.Text + "'");
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

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificaTablas form = new ModificaTablas();
            form.Show();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrarTablas form = new BorrarTablas();
            form.Show();
        }

        private void mostrarDDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScriptTabla form = new ScriptTabla();
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
            this.Hide();
            CrearIndice form = new CrearIndice();
            form.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificaInidces form = new ModificaInidces();
            form.Show();
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrarIndices form = new BorrarIndices();
            form.Show();
        }

        private void mostrarDDLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScriptIndice form = new ScriptIndice();
            form.Show();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarProcedures form = new ListarProcedures();
            form.Show();
        }

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearProcedure form = new CrearProcedure();
            form.Show();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificaProcedures form = new ModificaProcedures();
            form.Show();
        }

        private void borrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrarProcedure form = new BorrarProcedure();
            form.Show();
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarTriggers form = new ListarTriggers();
            form.Show();
        }

        private void crearToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearTrigger form = new CrearTrigger();
            form.Show();
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificaTriggers form = new ModificaTriggers();
            form.Show();
        }

        private void borrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrarTriggers form = new BorrarTriggers();
            form.Show();
        }

        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarViews form = new ListarViews();
            form.Show();
        }

        private void crearToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearView form = new CrearView();
            form.Show();
        }

        private void modificarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificaViews form = new ModificaViews();
            form.Show();
        }

        private void borrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrarViews form = new BorrarViews();
            form.Show();
        }
    }
}
