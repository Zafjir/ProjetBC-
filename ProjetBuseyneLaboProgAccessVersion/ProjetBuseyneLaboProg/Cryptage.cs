using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ProjetBuseyneLaboProg
{
    class Cryptage
    {
        public static void cryptage()
        {
            int a = 0;
            Variable.motCrypte = new char[Variable.motNonCrypte.Length];
            for (int i =0; i < Variable.motNonCrypte.Length; i++)
            {
                a= Variable.motNonCrypte[i];
                a = a + 1;
                Variable.motCrypte[i] = (char)a;
                Console.WriteLine(Variable.motCrypte[i]);
            }
            Variable.motStringCrypte = new String(Variable.motCrypte);
}

        public static void decryptage()
        {
            int a = 0;
            Variable.motNonCrypte = new char[Variable.motCrypte.Length];
            for (int i = 0; i < Variable.motCrypte.Length; i++)
            {
                a = Variable.motCrypte[i];
                a = a - 1;
                //Console.WriteLine((char)a);
                Variable.motNonCrypte[i] = (char)a;
               Console.WriteLine(Variable.motNonCrypte[i]);
            }
        }
    }
}
