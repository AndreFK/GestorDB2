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
    public partial class ScriptIndice : Form
    {

        DBStuff tool = new DBStuff();

        public ScriptIndice()
        {
            InitializeComponent();
            string q = "select ref.constname as FK, ref.tabname as Tabla, key.colname as Ref_Col, key.tabname as Ref_Tabla from syscat.keycoluse as key inner join syscat.references as ref on key.constname = ref.refkeyname";
            string qpk = "select colname as PK, tabname as Tabla from syscat.keycoluse where tabschema = 'USUARIO'";
            string qind = "select name as Indice, tbname as Tablas, uniquerule as Unico from sysibm.sysindexes where tbcreator = 'USUARIO' and uniquerule = 'U'";
            tool.fillDataGrid(dataGridView1, q);
            tool.fillDataGrid(dgvpk, qpk);
            tool.fillDataGrid(dgvind, qind);

            DataGridViewColumn colpk = new DataGridViewColumn();
            colpk.DataPropertyName = "Script";
            colpk.Name = "L";
            colpk.HeaderText = "Script";
            colpk.CellTemplate = new DataGridViewTextBoxCell();

            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = "Script";
            col.HeaderText = "Script";
            col.Name = "K";
            
            DataGridViewColumn coli = new DataGridViewColumn();
            coli.DataPropertyName = "Script";
            coli.HeaderText = "Script";
            coli.Name = "C";
            coli.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(col);
            dgvpk.Columns.Add(colpk);
            dgvind.Columns.Add(coli);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = tool.scriptFK(dataGridView1.Rows[i].Cells[1].Value.ToString().Remove(dataGridView1.Rows[i].Cells[1].Value.ToString().Length - 3), dataGridView1.Rows[i].Cells[2].Value.ToString());
            }

            for (int i = 0; i < dgvpk.RowCount - 1; i++)
            {
                dgvpk.Rows[i].Cells[0].Value = tool.scriptPk(dgvpk.Rows[i].Cells[1].Value.ToString(), dgvpk.Rows[i].Cells[2].Value.ToString());
            }

            for (int i = 0; i < dgvind.RowCount - 1; i++)
            {
                dgvind.Rows[i].Cells[0].Value = tool.scriptInd(dgvind.Rows[i].Cells[1].Value.ToString().Remove(dgvind.Rows[i].Cells[1].Value.ToString().Length - 4), dgvind.Rows[i].Cells[2].Value.ToString());
            }

            dataGridView1.Update();
            dataGridView1.Refresh();
            dgvpk.Update();
            dgvpk.Refresh();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
