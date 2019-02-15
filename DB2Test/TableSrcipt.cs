using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2;

namespace DB2Test
{
    class TableSrcipt
    {
        DB2Connection connect = new DB2Connection("Server = localhost:50000; Database = DBNAMES; UID = USUARIO; PWD = smonkw33d");

        public string sctiptTab(string tab)
        {
            string q = "create table " + tab + "(" + tabValuesScript(tab) + ") ";
            q = q + tabCols(tab);
            return q;

        }

        private string scriptInd(string col, string tab)
        {
            string idx = col + "_IDX";
            if (!isIND(idx, tab))
            {
                return "Nada";
            }
            return "create unique index " + idx + " on " + tab + "(" + col + ")";
        }

        private string getPK(string tab)
        {
            return "";
        }

        private string scriptPk(string col, string tab)
        {
            if (!isPK(col, tab))
            {
                return "Nada";
            }
            return "alter table " + tab + " add primary key (" + col + ")";
        }

        private string tabCols(string tab)
        {
            string c = "";
            string col = "";
            DB2Command cmd = new DB2Command("select colname from syscat.columns where tabname = '" + tab + "'", connect);
            if (!connect.IsOpen) { connect.Open(); }
            using (DB2DataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    c = dr.GetString(0);
                    if (isFK(c, tab))
                    {
                        col = col + " " + script_FK(c, tab);
                    }
                    if (isPK(c, tab))
                    {
                        col = col + " " + scriptPk(c, tab);
                    }
                    if (isIND(c, tab))
                    {
                        col = col + " " + scriptInd(c, tab);
                    }

                }
                dr.Close();
            }
            connect.Close();
            return col;
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

        private string tabValuesScript(string tab)
        {
            string c = "";
            string q = "";
            int x = 0;
            DB2Command cmd = new DB2Command("select colname from syscat.columns where tabname = '" + tab + "'", connect);
            if (!connect.IsOpen) { connect.Open(); }
            using (DB2DataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    c = dr.GetString(0);
                    if (x == 0)
                    {
                        if (colCant(tab) == 1)
                        {
                            q = c + " " + Type(c, tab) + colLength(c, tab);
                            x++;
                        }
                        else
                        {
                            q = q + c + " " + Type(c, tab) + colLength(c, tab);
                            x++;
                        }
                    }
                    else
                    {
                        q = q + ", " + c + " " + Type(c, tab) + colLength(c, tab);
                        x++;
                    }
                }
            }
            return q;
        }

        private string colLength(string col, string tab)
        {
            if (Type(col, tab) == "VARCHAR")
            {
                return "(70)";
            }
            else if (Type(col, tab) == "CHAR")
            {
                return "(1)";
            }
            else if (Type(col, tab) == "INTEGER")
            {
                return "";
            }
            else if (Type(col, tab) == "DOUBLE")
            {
                return "";
            }
            else if (Type(col, tab) == "NUMERIC")
            {
                return "(10,2)";
            }
            else
            {
                return "";
            }
        }

        private int colCant(string tab)
        {
            int c = 0;
            try
            {
                DB2Command cmd = new DB2Command("select count(*) from syscat.columns where tabname = '" + tab + "'", connect);
                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        c = dr.GetInt32(0);
                    }
                }
            }
            catch (DB2Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return c;
        }
        private string script_FK(string col, string tab)
        {
            string v = "";

            string cref = "";
            string tref = "";

            if (!isFK(col, tab))
            {
                return "Nada";
            }
            DB2Command cmd = new DB2Command("select ref.constname as FK, ref.tabname as Tabla, key.colname as Ref_Col, key.tabname as Ref_Tabla from syscat.keycoluse as key inner join syscat.references as ref on key.constname = ref.refkeyname where ref.constname = '" + col + "_FK' and ref.tabname = '" + tab + "'", connect);
            if (!connect.IsOpen) { connect.Open(); }
            using (DB2DataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    cref = dr.GetString(2);
                    tref = dr.GetString(3);
                }
            }
            v = "alter table " + tab + " add constraint " + col + "_FK foreign key (" + col + ") references " + tref + " (" + cref + ") not enforced";
            return v;
        }
        private bool isFK(string col, string tab)
        {
            string v = "";
            try
            {
                DB2Command cmd = new DB2Command("select constname from syscat.references where constname = '" + col + "_FK' and tabname = '" + tab + "'", connect);
                if (!connect.IsOpen) { connect.Open(); }
                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        v = dr.GetString(0);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
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
        private bool isPK(string col, string tab)
        {
            string v = "";
            try
            {
                DB2Command cmd = new DB2Command("select colname from syscat.keycoluse where colname = '" + col + "' and tabname = '" + tab + "'", connect);
                if (!connect.IsOpen) { connect.Open(); }
                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        v = dr.GetString(0);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
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
        private bool isIND(string col, string tab)
        {
            string v = "";
            try
            {
                DB2Command cmd = new DB2Command("select name from sysibm.sysindexes where  name = '" + col + "' and tbname = '" + tab + "' and tbcreator = 'USUARIO'", connect);
                if (!connect.IsOpen) { connect.Open(); }
                using (DB2DataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        v = dr.GetString(0);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
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

        public string script_Ind(string col, string tab)
        {
            string idx = col;

            return "create unique index " + idx + " on " + tab + "(" + col.Remove(col.Length - 4) + ")";
        }
        public string script_Pk(string col, string tab)
        {
            return "alter table " + tab + " add primary key (" + col + ")";
        }
        public string scriptFK(string col, string tab)
        {
            string v = "";

            string cref = "";
            string tref = "";

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
            v = "alter table " + tab + " add constraint " + col + " foreign key (" + col + "_FK) references " + tref + " (" + cref + ") not enforced";
            return v;
        }

    }
}
