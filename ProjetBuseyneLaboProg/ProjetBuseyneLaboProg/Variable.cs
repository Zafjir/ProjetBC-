using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace ProjetBuseyneLaboProg
{
    class Variable
    {
        public static string username;
        public static string password;
        public static OleDbConnection conn;
        public static OleDbCommand cmd;
        public static OleDbDataReader dtrd;
    }
}
