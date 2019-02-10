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
    }
}
