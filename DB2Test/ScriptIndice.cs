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
            tool.fillDataGrid(dataGridView1, q);

            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = "Script";
            col.HeaderText = "Script";
            col.Name = "K";
            dataGridView1.Columns.Add(col);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = tool.scriptFK(dataGridView1.Rows[i].Cells[1].Value.ToString().Remove(dataGridView1.Rows[i].Cells[1].Value.ToString().Length - 3), dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
