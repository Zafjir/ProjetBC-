﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace ProjetBuseyneLaboProg
{
    public class DataBaseConnection
    {
       public static string log;
        public static string sqlstr, enr;
        public DataBaseConnection()
        {
         
            // InitializeComponent();

        }
        public static void Connection(ref TextBox textBox1, ref TextBox tb_password)
        {
          try
            {
                Variable.conn.Open();

                if (Variable.conn.State == ConnectionState.Open)
                {
                    Variable.username = textBox1.Text;
                    Variable.password = tb_password.Text;
                    sqlstr = "select * from LogAdmin";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr = Variable.dtrd["UserName"].ToString() + "" + Variable.dtrd["Password"].ToString();
                        log = Variable.username + Variable.password;
                        MessageBox.Show(enr);
                        MessageBox.Show(Variable.dtrd["Username"].ToString()+ Variable.dtrd["Password"].ToString());
                        if (log == enr)
                        {
                            Variable.conn.Close();
                            Form3 form3 = new Form3();
                            form3.ShowDialog();
                        }
                        if (Variable.dtrd == null)
                        {
                            Variable.dtrd.Close();
                        }
                    }

                        if (Variable.conn.State == ConnectionState.Open)
                        {
                            Variable.username = textBox1.Text;
                            Variable.password = tb_password.Text;
                            sqlstr = "select * from LogUtilisateur";
                            Variable.cmd.CommandType = CommandType.Text;
                            Variable.cmd.CommandText = sqlstr;
                            Variable.cmd.Connection = Variable.conn;
                            Variable.dtrd = Variable.cmd.ExecuteReader();
                            while (Variable.dtrd.Read())
                            {
                                enr = Variable.dtrd["UsName"].ToString() + "" + Variable.dtrd["Pwd"].ToString();
                                log = Variable.username + Variable.password;
                                if (log == enr)
                                {
                                    Variable.conn.Close();
                                    PageAccueil pageAccueil = new PageAccueil();
                                    pageAccueil.ShowDialog();
                                }
                            }
                            if (Variable.dtrd == null)
                            {
                                Variable.dtrd.Close();
                            }

                            if (Variable.conn.State == ConnectionState.Open)
                            {
                                Variable.conn.Close();
                            }
                        }
                }
            }
            catch (Exception ex) { }
        }
    }
}
