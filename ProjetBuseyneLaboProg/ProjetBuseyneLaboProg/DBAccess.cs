
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
            Variable.cmd = new SqlCommand();
            DataTable ds = new DataTable();
            try
            {
                Variable.conn.ConnectionString = Properties.Settings.Default.SQLClientConnection;
                //conn = new OleDbConnection(Properties.Settings.Default.OledbConnectionString2010);
                Variable.conn.Open();
                //MessageBox.Show(qry);
                //MessageBox.Show(Variable.conn.ToString());
                SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter(qry, Variable.conn);
                oSqlDataAdapter.Fill(ds);
                Variable.conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("L'erreur suivante a été rencontrée :" + e.ToString());

            }
            return ds;
        }
    }
}


