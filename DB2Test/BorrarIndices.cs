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
    public partial class BorrarIndices : Form
    {
        DBStuff tool = new DBStuff();

        public BorrarIndices()
        {
            string q = "select name from sysibm.systables where creator  = 'USUARIO'";
            InitializeComponent();
            tabpk.Text = "Tabla";
            tabfk.Text = "Tabla";
            tabind.Text = "Tabla";
            tool.fillComboDB(tabpk, q);
            tool.fillComboDB(tabfk, q);
            tool.fillComboDB(tabind, q);
        }

        private void tabpk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qd = "select colname as PK, tabname as Tabla from syscat.keycoluse where tabname = '"+tabpk.Text+"'";
            string q = "select colname from syscat.keycoluse where tabname = '" + tabpk.Text + "'";
            tool.fillComboDB(pkname, q);
            tool.fillDataGrid(dgvpk, qd);     
            
        }

        private void tabfk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qfkd = "select constname as FK, tabname as Tabla, reftabname as Referencia from syscat.references where tabname = '" + tabfk.Text + "'";
            string qfk = "select constname from syscat.references where tabname = '" + tabfk.Text + "'";
            tool.fillComboDB(fkname, qfk);
            tool.fillDataGrid(dgvfk, qfkd);
        }

        private void tabind_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qid = "select name as Indice, tbname as Tabla, uniquerule as Es_Unico from sysibm.sysindexes where tbname = '"+tabind.Text+"' and uniquerule != 'P'";
            string qi = "select name from sysibm.sysindexes where tbname = '" + tabind.Text + "'";
            tool.fillComboDB(indname, qi);
            tool.fillDataGrid(dgvind, qid);
        }

        private void btpk_Click(object sender, EventArgs e)
        {
            string q = "alter table " + tabpk.Text + " drop primary key";
            tool.sendCmd(q);
            System.Windows.Forms.MessageBox.Show("PK Borrada");
            dgvpk.DataSource = null;
            dgvpk.Update();
            dgvpk.Refresh();
            pkname.Items.Clear();
            pkname.Text = "";
            //tabpk.Items.Clear();
            tabpk.Text = "";
        }

        private void btfk_Click(object sender, EventArgs e)
        {
            string q = "alter table " + tabfk.Text + " drop foreign key "+ fkname.Text;
            tool.sendCmd(q);
            System.Windows.Forms.MessageBox.Show("FK Borrada");
            dgvfk.DataSource = null;
            dgvfk.Update();
            dgvfk.Refresh();
            fkname.Items.Clear();
            fkname.Text = "";
            //tabfk.Items.Clear();
            tabfk.Text = "";
        }

        private void btind_Click(object sender, EventArgs e)
        {
            string q = "drop index " +indname.Text;
            tool.sendCmd(q);
            System.Windows.Forms.MessageBox.Show("Indice Borrado");
            dgvind.DataSource = null;
            dgvind.Update();
            dgvind.Refresh();
            indname.Items.Clear();
            indname.Text = "";
           // tabind.Items.Clear();
            tabind.Text = "";
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
