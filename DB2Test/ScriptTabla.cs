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
    public partial class ScriptTabla : Form
    {
        DBStuff tool = new DBStuff();
        TableSrcipt ts = new TableSrcipt();

        public ScriptTabla()
        {
            InitializeComponent();
            string query = "select name from sysibm.systables where creator  = 'USUARIO'";
            tool.fillDataGrid(dgv, query);

            DataGridViewColumn colpk = new DataGridViewColumn();
            colpk.DataPropertyName = "Script";
            colpk.Name = "L";
            colpk.HeaderText = "Script";
            colpk.CellTemplate = new DataGridViewTextBoxCell();

            dgv.Update();
            dgv.Refresh();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ts.sctiptTab("TESTC");
        }

        private string query(string tab)
        {
            return "";
        }
    }
}
