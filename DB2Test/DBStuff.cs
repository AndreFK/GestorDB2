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

        public void dropCmd(string query, string bkp)
        {

            DB2Command cmd = new DB2Command(query, connect);
            connect.Open();
            try
            {
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (DB2Exception e)
            {
                DB2Command cm = new DB2Command(bkp, connect);
                cm.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(e.ToString());
                connect.Close();
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

        public string ddl(string q)
        {

            string v = "";
            DB2Command cmd = new DB2Command(q, connect);
            if (!connect.IsOpen) { connect.Open(); }
            using(DB2DataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    v = dr.GetString(0);
                }
                dr.Close();
            }
            connect.Close();
            return v;
        }
        
        public string getType(string col, string tab)
        {
            string v = "";
            try
            {
                DB2Command cmd = new DB2Command("select typename from syscat.columns where tabname = '" + tab + "' and colname = '" + col + "'", connect);
                if (!connect.IsOpen) { connect.Open(); }
                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        v = dr.GetString(0);
                    }
                    if (!dr.IsClosed)
                    {
                        dr.Close();
                    }
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

        private string Type(string col, string tab)
        {
            string v = "";
            try
            {
                DB2Command cmd = new DB2Command("select typename from syscat.columns where tabname = '" + tab + "' and colname = '" + col + "'", connect);
                if (!connect.IsOpen) { connect.Open(); }
                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        v = dr.GetString(0);
                    }
                }
            }
            catch (DB2Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            return v;
        }

        public string isInd(string col, string tab)
        {
            if (ispk(col, tab))
            {
                return "PK";
            }
            else if (isfk(col, tab))
            {
                return "FK";
            }
            else if (isindex(col, tab))
            {
                return "Index";
            }
            else return "No";
        }

        public string scriptPk(string col, string tab)
        {
            if(!ispk(col, tab))
            {
                return "Nada";
            }
            return "alter table " + tab + " add primary key (" + col + ")";
        }

        private bool ispk(string col, string tab)
        {
            string v = "";
            try
            {
                DB2Command cmd = new DB2Command("select colname from syscat.keycoluse where colname = '" + col + "' and tabname = '" + tab + "'", connect);
                connect.Open();
                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        v = dr.GetString(0);
                    }
                    dr.Close();
                }
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                connect.Close();
            }
            if (v == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string scriptFK(string col, string tab)
        {
            string v = "";

            string cref = "";
            string tref = "";

           if(!isfk(col, tab))
            {
                return "Nada";
            }
                DB2Command cmd = new DB2Command("select ref.constname as FK, ref.tabname as Tabla, key.colname as Ref_Col, key.tabname as Ref_Tabla from syscat.keycoluse as key inner join syscat.references as ref on key.constname = ref.refkeyname where ref.constname = '" + col + "_FK' and ref.tabname = '" + tab + "'", connect);
                connect.Open();
                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cref = dr.GetString(2);
                        tref = dr.GetString(3);
                    }
                    dr.Close();
                }
                connect.Close();
                v = "alter table " + tab + " add constraint " + col + "_FK foreign key (" + col + ") references " + tref + " (" + cref + ") not enforced";
                return v;
        }

        public bool isfk(string col, string tab)
        {
            string v = "";
            try
            {
                DB2Command cmd = new DB2Command("select constname from syscat.references where constname = '" + col + "_FK' and tabname = '" + tab + "'", connect);
                connect.Open();
                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        v = dr.GetString(0);
                    }
                    dr.Close();
                }
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                connect.Close();
            }
            if (v == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string scriptInd(string col, string tab)
        {
            string idx = col + "_IDX";
            if(!isindex(idx, tab))
            {
                return "Nada";
            }
            return "create unique index " + idx + " on " + tab + "(" + col + ")";
        }

        public bool isindex(string col, string tab)
        {
            string v = "";
            try
            {
                DB2Command cmd = new DB2Command("select name from sysibm.sysindexes where  name = '" + col + "' and tbname = '" + tab + "' and tbcreator = 'USUARIO'", connect);
                connect.Open();
                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        v = dr.GetString(0);
                    }
                    dr.Close();
                }
                connect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                connect.Close();
            }
            if (v == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string PoC(string name)
        {
            string v = "";

            
            DB2Command cmd = new DB2Command(" select routinetype from syscat.routines where routinename = '" + name +"'", connect);
            try
            {
                connect.Open();
                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        v = dr.GetString(0);
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

        public string coltab(string col)
        {
            string v = "";
            DB2Command cmd = new DB2Command("select tabname from syscat.columns where colname = '" + col + "'", connect);
            if (!connect.IsOpen) { connect.Open(); }
            using(DB2DataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    v = dr.GetString(0);
                }
                dr.Close();
            }
            connect.Close();
            return v;
        }
    }
}
