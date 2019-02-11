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
    public partial class CrearIndice : Form
    {
        DBStuff tool = new DBStuff();

        public CrearIndice()
        {
            InitializeComponent();
            string q = "select name as Nombre from sysibm.systables where creator  = 'USUARIO'"; //"select constname as Nombre, tabname as Tabla, refkeyname as Col_Ref, reftabname as Tabla_Ref from syscat.references";
            tool.fillComboDB(tabpk, q);
            tool.fillComboDB(tabfk, q);
            tool.fillComboDB(tabref, q);
            tool.fillComboDB(tabidx, q);
        }

        private void tabpk_SelectedIndexChanged(object sender, EventArgs e)
        {
            colpk.Text = "";
            colpk.Items.Clear();
            string q = "select colname from syscat.columns where tabname = '" + tabpk.Text + "'";
            string dgvq = "select * from " + tabpk.Text;
            tool.fillComboDB(colpk, q);
            tool.fillDataGrid(dgvpk, dgvq);
        }

        private void addpk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tabpk.Text) || string.IsNullOrWhiteSpace(colpk.Text))
            {
                MessageBox.Show("Debe seleccionar una tabla y columna");
            }
            if (tool.isInd(colpk.Text, tabpk.Text) != "No")
            {
                MessageBox.Show("Esta columna ya es una llave primaria");
            }
            else
            {
                string dgq = "select colname as Nombre, tabname as Tabla from syscat.keycoluse where tabschema  = 'USUARIO'";
                string q = "alter table " + tabpk.Text + " add primary key (" + colpk.Text + ")";
                tool.sendCmd(q);
                MessageBox.Show("Llave primaria creada");
                tabpk.Text = "";
                colpk.Text = "";
                colpk.Items.Clear();
                tool.fillDataGrid(dgvpk, dgq);
            }
        }

        private void tabfk_SelectedIndexChanged(object sender, EventArgs e)
        {
            colfk.Text = "";
            colfk.Items.Clear();
            string q = "select colname from syscat.columns where tabname = '" + tabfk.Text + "'";
            string dgvq = "select * from " + tabfk.Text;
            tool.fillComboDB(colfk, q);
            tool.fillDataGrid(dataGridView1, dgvq);
        }

        private void tabref_SelectedIndexChanged(object sender, EventArgs e)
        {
            colref.Text = "";
            colref.Items.Clear();
            string q = "select colname from syscat.columns where tabname = '" + tabref.Text + "'";
            string dgvq = "select * from " + tabref.Text;
            tool.fillComboDB(colref, q);
        }

        private void addfk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tabfk.Text) || string.IsNullOrWhiteSpace(colfk.Text) || string.IsNullOrWhiteSpace(tabref.Text) || string.IsNullOrWhiteSpace(colref.Text))
            {
                MessageBox.Show("Debe seleccionar una tabla y columna");
            }
            if (tool.isfk(colfk.Text, tabfk.Text))
            {
                MessageBox.Show("Esta columna ya es una llave foranea");
            }
            else
            {
                string dgq = "select constname as Nombre, tabname as Tabla, refkeyname as Col_Ref, reftabname as Tabla_Ref from syscat.references";
                string q = "alter table " + tabfk.Text + " add constraint "+ colfk.Text + "_fk foreign key (" + colfk.Text + ") references " + tabref.Text + "(" + colref.Text + ")";
                tool.sendCmd(q);
                //MessageBox.Show(q);
                MessageBox.Show("Llave foranea creada");
                tabpk.Text = "";
                colpk.Text = "";
                colpk.Items.Clear();
                tool.fillDataGrid(dataGridView1, dgq);
            }
        }

        private void tabidx_SelectedIndexChanged(object sender, EventArgs e)
        {
            colidx.Text = "";
            colidx.Items.Clear();
            string q = "select colname from syscat.columns where tabname = '" + tabidx.Text + "'";
            string dgvq = "select * from " + tabidx.Text;
            tool.fillComboDB(colidx, q);
            tool.fillDataGrid(dgvidx, dgvq);
        }

        private void addidx_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tabidx.Text) || string.IsNullOrWhiteSpace(colidx.Text))
            {
                MessageBox.Show("Debe seleccionar una tabla y columna");
            }
            if (tool.isfk(colfk.Text, tabfk.Text))
            {
                MessageBox.Show("Esta columna ya es un indice");
            }
            else
            {
                string dgq = "select name as Nombre, tbname as Tabla, uniquerule as Es_Unico from sysibm.sysindexes where tbcreator = 'USUARIO' and uniquerule = 'U'";
                string q = "create unique index " + colidx.Text + "_idx on " + tabidx.Text + "("+colidx.Text+")";
                tool.sendCmd(q);
                //MessageBox.Show(q);
                MessageBox.Show("Indice creado");
                tabidx.Text = "";
                colidx.Text = "";
                colidx.Items.Clear();
                tool.fillDataGrid(dgvidx, dgq);
            }
        }

        private void colfk_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = tool.isfk(colfk.Text, tabfk.Text).ToString();
        }

        private void colpk_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = tool.isInd(colpk.Text, tabpk.Text);
        }

        private void CrearIndice_Load(object sender, EventArgs e)
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

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarDDLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void mostrarDDLToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
