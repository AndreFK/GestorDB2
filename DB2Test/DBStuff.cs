using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using IBM.Data.DB2;

namespace DB2Test
{
    class DBStuff
    {
        

        DB2Connection connect = new DB2Connection("Server = localhost:50000; Database = DBNAMES; UID = USUARIO; PWD = smonkw33d");

        public void fillComboDB(ComboBox c, string query)
        {
            try
            {
                c.Items.Clear();

                DB2Command cmd = new DB2Command(query, connect);

                connect.Open();

                DB2DataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string tName = reader.GetString(0);
                    c.Items.Add(tName);
                }
                reader.Close();
                connect.Close();
            }
            catch(DB2Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                connect.Close();
            }
        }

        public void fillDataGrid(DataGridView d, string query)
        {

            try
            {
                connect.Open();
                DB2DataAdapter da = new DB2DataAdapter(query, connect);
                DataSet ds = new DataSet();
                da.Fill(ds);
                d.DataSource = ds.Tables[0];

                d.Update();
                d.Refresh();
                connect.Close();
            }
            catch(DB2Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                connect.Close();
            }
        }

        public void fillDataGridRout(DB2Command cm, DataGridView d)
        {
            DB2DataReader reader;
            reader = cm.ExecuteReader();
            d.DataSource = reader;
            reader.Close();
        }

        public void callRout(DataGridView d)
        {
            DB2Command cmd = connect.CreateCommand();
            connect.Open();
            try
            {
                string call = "call GET_ID_TEST(@param)";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = call;
                cmd.Parameters.Add(new DB2Parameter("@param", "?"));
                fillDataGridRout(cmd, d);
                connect.Close();
            }
            catch(DB2Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
        }

        public void sendCmd(string query)
        {
         
            DB2Command cmd = new DB2Command(query, connect);
            connect.Open();
            try
            {
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch(DB2Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                connect.Close();
            }
        }

        public string getType(string col, string tab)
        {
            string v = "";
            try
            {
                DB2Command cmd = new DB2Command("select colname from syscat.columns where tabname = '" + tab + "' and colname = '" + col + "'", connect);
                connect.Open();
                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        v = dr.GetDataTypeName(0);
                    }
                    dr.Close();
                }
                connect.Close();
            }
            catch(DB2Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                connect.Close();
            }
            return v;
        }

        public string getValue(string v, string tab)
        {
            string q = "";
            DB2Command cmd = new DB2Command("seelect * from " + tab, connect);
            return q;
        }


    }
}
