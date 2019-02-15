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
