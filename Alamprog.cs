using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TARpv22_C
{
    public class Alamprog
    {
        public static int Korruta(int arv1,int arv2)
        {
            return arv1 * arv2;
        }
       
        public static string Kalkulaator(int arv1, int arv2,char tehe)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            double j =Convert.ToDouble(table.Compute(arv1.ToString()+tehe.ToString()+arv2.ToString(), String.Empty));
           
            j=Math.Round(j,0);
            string vastus = "";
            string nur = "nurr ";
            for (int i = 0; i < Math.Abs(Convert.ToInt32(j)); i++)
            {
                vastus= vastus + nur;
            }
            return vastus;
        }


        public static void Tere(string name)
        {
            Console.WriteLine("Tere {0}",name);
        }
    }
}
