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
    public partial class BorrarProcedure : Form
    {
        DBStuff tool = new DBStuff();

        public BorrarProcedure()
        {
            string query = "select routinename as Nombre, routinetype as Tipo from syscat.routines where definer = 'USUARIO'";
            string q = "select routinename from syscat.routines where definer = 'USUARIO'";
            InitializeComponent();
            tool.fillDataGrid(dgv, query);
            tool.fillComboDB(pname, q);
        }

        private void pname_SelectedIndexChanged(object sender, EventArgs e)
        {
            string v = tool.PoC(pname.Text);
            string q = "select routinename as Nombre, text as Script from syscat.routines where routinename = '"+ pname.Text +"'";
            tool.fillDataGrid(dataGridView1, q);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryc = "select routinename as Nombre, routinetype as Tipo, from syscat.routines where definer = 'USUARIO'";
            string q = "select routinename from syscat.routines where definer = 'USUARIO'";
            if (string.IsNullOrWhiteSpace(pname.Text))
            {
                System.Windows.Forms.MessageBox.Show("Seleccione una rutina a borrar");
            }
            else
            {
                string type = tool.PoC(pname.Text);
                if(type == "P")
                {
                    string query = "drop procedure " + pname.Text;
                    System.Windows.Forms.MessageBox.Show(pname.Text + " borrado");
                    tool.sendCmd(query);
                   
                   // textBox1.Text = ddl;
                    pname.Text = "";
                    pname.Items.Clear();
                    dgv.DataSource = null;
                    dgv.Update();
                    dgv.Refresh();
                    tool.fillComboDB(pname, q);
                    tool.fillDataGrid(dgv, queryc);
                }
                else
                {
                    string query = "drop function " + pname.Text;
                    System.Windows.Forms.MessageBox.Show(pname.Text + " borrado");
                    tool.sendCmd(query);
                    
                   // string ddl = tool.PoCDDL(pname.Text);
                   // textBox1.Text = ddl;
                    pname.Text = "";
                    pname.Items.Clear();
                    dgv.DataSource = null;
                    dgv.Update();
                    dgv.Refresh();
                    tool.fillComboDB(pname, q);
                    tool.fillDataGrid(dgv, queryc);
                }
            }
        }
    }
}
