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
    public partial class ModificaTablas : Form
    {

        DBStuff tool = new DBStuff();
        private int rows = 0;
        private int totRows = 0;

        public ModificaTablas()
        {
            InitializeComponent();
            tablesNames.Text = "Seleccione tabla";
            string query = "select name from sysibm.systables where creator  = 'USUARIO'";
            tool.fillComboDB(tablesNames, query);
        }

        private void ModificaTablas_Load(object sender, EventArgs e)
        {
            
        }

        private void tablesNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablesNames.Text == "Seleccione tabla" || string.IsNullOrWhiteSpace(tablesNames.Text)) {
            }
            else
            {

                colName.Text = "Columna";
                colName.Items.Clear();
                valorViejo.Text = "";
                valorViejo.Items.Clear();
                string query = "select colname from syscat.columns where tabname = '" + tablesNames.Text + "'";
                string dgvquery = "select * from " + tablesNames.Text;
                tool.fillComboDB(colName, query);
                tool.fillDataGrid(dgv, dgvquery);
                rows = dgv.Rows.Count - 1;
            }
        }

        private void valorViejo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void colName_SelectedIndexChanged(object sender, EventArgs e)
        {
            valorViejo.Text = "Valor";
            valorViejo.Items.Clear();
            string query = "select " + colName.Text + " from " + tablesNames.Text;
            textBox1.Text = tool.getType(colName.Text, tablesNames.Text);
            tool.fillComboDB(this.valorViejo, query);
            
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            if (tablesNames.Text == "Seleccione tabla" && string.IsNullOrWhiteSpace(colName.Text) && string.IsNullOrWhiteSpace(valorViejo.Text) && string.IsNullOrWhiteSpace(valorNuevo.Text))
            {
                System.Windows.Forms.MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
               string query = updateQuery(tablesNames, colName, valorViejo, valorNuevo);
               tool.sendCmd(query);
           }
            resetall();
        }

        private void resetTexts()
        {

        }

        private string updateQuery(ComboBox t, ComboBox col, ComboBox vv, TextBox vn)
        {
            string query = "";
            string type = tool.getType(col.Text, t.Text);
            if(type == "VARCHAR" || type == "CHARACTER")
            {
                query = "update " + t.Text + " set " + col.Text + " = '" + vn.Text + "' where " + col.Text + " = '" + vv.Text + "'";
                
            }
            else
            {
                query = "update " + t.Text + " set " + col.Text + " = " + vn.Text + " where " + col.Text + " = " + vv.Text;
            }
            return query;
        }

        private void resetall()
        {
            string dgquery = "select * from " + tablesNames.Text;
            dgv.DataSource = null;
            dgv.Update();
            dgv.Refresh();
            tablesNames.Text = "Seleccione tabla";
            colName.Text = "";
            colName.Items.Clear();
            valorViejo.Text = "";
            valorViejo.Items.Clear();
            valorNuevo.Text = "";
            rows = 0;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            int r = rows;
            totRows = dgv.Rows.Count;
            for(int i = rows; i < totRows -1; i++)
            {
                tool.sendCmd(insertQuery(r));
                r++;
            }
            rows = totRows - 1;
            System.Windows.Forms.MessageBox.Show("Elementos insertados");
        }

        public string insertQuery(int ro)
        {
            string q = "";
            int cols = dgv.Columns.Count - 1;
            if (checkIfOne())
            {
                string type = tool.getType(dgv.Columns[0].Name, tablesNames.Text);
                if(type == "VARCHAR" || type == "CHARACTER")
                {
                    q = "insert into " + tablesNames.Text + " values ('" + dgv.Rows[ro].Cells[cols].Value + "')";
                }
                else
                {
                    q = "insert into " + tablesNames.Text + " values (" + dgv.Rows[ro].Cells[cols].Value + ")";
                }
            }
            else
            {
                string t = tool.getType(dgv.Columns[0].Name, tablesNames.Text);
                if (t == "VARCHAR" || t == "CHAR") {
                    q = "insert into " + tablesNames.Text + " values ('" + dgv.Rows[ro].Cells[0].Value + "'";
                }
                else
                {
                    q = "insert into " + tablesNames.Text + " values (" + dgv.Rows[ro].Cells[0].Value;
                }
                for(int i = 1; i<dgv.ColumnCount; i++)
                {
                    string type = tool.getType(dgv.Columns[i].Name, tablesNames.Text);
                    if (type == "VARCHAR" || type == "CHAR")
                    {
                        if (i == dgv.ColumnCount - 1)
                        {
                            q = q + ", '" + dgv.Rows[ro].Cells[i].Value + "')";
                        }
                        else
                        {
                            q = q + ", '" + dgv.Rows[ro].Cells[i].Value + "'";
                        }
                    }
                    else
                    {
                        if (i == dgv.ColumnCount - 1)
                        {
                            q = q + ", " + dgv.Rows[ro].Cells[i].Value + ")";
                        }
                        else
                        {
                            q = q + ", " + dgv.Rows[ro].Cells[i].Value;
                        }
                    }
                }
            }
            return q;
        }

        public bool checkIfOne()
        {
            if(dgv.Columns.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
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

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarTablas form = new ListarTablas();
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
    }
}

