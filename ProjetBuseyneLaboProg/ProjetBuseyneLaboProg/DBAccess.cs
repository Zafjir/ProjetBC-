
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetBuseyneLaboProg
{
    public class DBAccess
    {
        public DataTable qry(String qry)
        {
            OleDbConnection conn;
            OleDbCommand cmd;
            OleDbDataReader dtrd;
            Variable.cmd = new OleDbCommand();
            DataTable ds = new DataTable();
            try
            {
                conn = new OleDbConnection(Properties.Settings.Default.OledbConnectionString2010);
                conn.Open();
                //MessageBox.Show(qry);
                //MessageBox.Show(Variable.conn.ToString());
                OleDbDataAdapter oSqlDataAdapter = new OleDbDataAdapter(qry, conn);
                oSqlDataAdapter.Fill(ds);
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("L'erreur suivante a été rencontrée :" + e.ToString());

            }
            return ds;
        }
    }
}


