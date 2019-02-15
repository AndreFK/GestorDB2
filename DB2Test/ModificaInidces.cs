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
    public partial class ModificaInidces : Form
    {
        TableSrcipt ts = new TableSrcipt();
        DBStuff tool = new DBStuff();

        public ModificaInidces()
        {
            InitializeComponent();
            string q = "select colname from syscat.keycoluse where tabschema = 'USUARIO'";
            string qfk = "select ref.constname from syscat.keycoluse as key inner join syscat.references as ref on key.constname = ref.refkeyname ";
            string qi = "select name from sysibm.sysindexes where tbcreator = 'USUARIO' and uniquerule = 'U'";

            string qdgv = "select colname as PK, tabname as Tabla from syscat.keycoluse where tabschema = 'USUARIO'";
            string qfkdgv = "select ref.constname as FK, ref.tabname as Tabla, key.colname as Ref_Col, key.tabname as Ref_Tabla from syscat.keycoluse as key inner join syscat.references as ref on key.constname = ref.refkeyname ";
            string qidgv = "select name as Indice, tbname as Tabla, uniquerule as Es_Unico from sysibm.sysindexes where tbcreator = 'USUARIO' and uniquerule = 'U'";

            tool.fillComboDB(this.pk, q);
            tool.fillComboDB(this.fk, qfk);
            tool.fillComboDB(this.idx, qi);

            tool.fillDataGrid(dgvpk, qdgv);
            tool.fillDataGrid(dataGridView1, qfkdgv);
            tool.fillDataGrid(dgvidx, qidgv);

            textBox1.Text = "alter table _____ add primary key (_____)";
            textBox2.Text = "alter table _____ add constraint _____|_FK foreign key (_____) references _____ (_____) not enforced";
            textBox3.Text = "create unique index _____ on _____ (______)";


        }

        private void pk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tab = tool.coltab(pk.Text);
            textBox1.Text = ts.script_Pk(pk.Text, tab);
        }

        private void fk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tab = tool.coltab(fk.Text.Remove(fk.Text.Length - 3));
            textBox2.Text = ts.scriptFK(fk.Text.Remove(fk.Text.Length - 3), tab);
        }

        private void idx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tab = tool.coltab(idx.Text.Remove(idx.Text.Length - 4));
            textBox3.Text = ts.script_Ind(idx.Text, tab);
        }

        private void addpk_Click(object sender, EventArgs e)
        {
            string tab = tool.coltab(pk.Text);
            string text = tool.scriptInd(pk.Text, tab);
            string query = "alter table " + tab + " drop primary key " + pk.Text;
            tool.dropCmd(query, text);
            tool.sendCmd(textBox1.Text);
            tool.fillDataGrid(dgvpk, "select colname as PK, tabname as Tabla from syscat.keycoluse where tabschema = 'USUARIO'");
        }

        private void addfk_Click(object sender, EventArgs e)
        {
            string tab = tool.coltab(fk.Text);
            string text = tool.scriptInd(fk.Text, tab);
            string query = "alter table " + tab + " drop foreign key " + fk.Text;
            tool.dropCmd(query, text);
            tool.sendCmd(textBox2.Text);
            tool.fillDataGrid(dataGridView1, "select ref.constname as FK, ref.tabname as Tabla, key.colname as Ref_Col, key.tabname as Ref_Tabla from syscat.keycoluse as key inner join syscat.references as ref on key.constname = ref.refkeyname ");
        }

        private void addidx_Click(object sender, EventArgs e)
        {
            string tab = tool.coltab(idx.Text);
            string text = tool.scriptInd(idx.Text, tab);
            string query = "drop index " + idx.Text;
            tool.dropCmd(query, text);
            tool.sendCmd(textBox3.Text);
            tool.fillDataGrid(dgvidx, "select name as Indice, tbname as Tabla, uniquerule as Es_Unico from sysibm.sysindexes where tbcreator = 'USUARIO' and uniquerule = 'U'");
        }

        private void ModificaInidces_Load(object sender, EventArgs e)
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
