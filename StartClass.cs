using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TARpv22_C
{
    public class StartClass
    {
        public static void Main(string[] args)
        {
            string nimi = "Python";
            Alamprog.Tere(nimi);
            int a = 12;
            int b = 13;
            int vastus=Alamprog.Korruta(a, b);
            Console.WriteLine(vastus);
            Console.WriteLine(Alamprog.Korruta(5, 6));
            Console.WriteLine(Alamprog.Kalkulaator(2, 3, '+'));
            /*Random rnd= new Random();
            int N=rnd.Next(-100,100);
            int M=rnd.Next(-100,100);
            int pikkus = 0;
            if (N<0 && M<0) 
            {
                if (N<M)
                {
                    pikkus = Math.Abs(N) - Math.Abs(M);
                }
                else 
                {
                    pikkus = Math.Abs(M) - Math.Abs(N);
                }
            }
            else if (N<0 && M>0)
            {
                pikkus = Math.Abs(N) + M+1;
            }
            else if (M<0 && N>0)
            {
                pikkus = Math.Abs(M) + N+1;
            }
            else
            {
                if (M>N)
                {
                    pikkus = M - N;
                }
                else
                {
                    pikkus = N - M;
                }
            }
            Console.WriteLine("N={1},M={0},pikkus={2}",M,N,pikkus);
            int[] ruudud= new int[pikkus+1];
            for (int i = 0; i < pikkus; i++)
            {
                ruudud[i] = N;
                N += 1;
            }
            foreach (int item in ruudud)
            {
                Console.WriteLine(item*item);
            }*/
            /*string paev = "";
            for (int i = 0; i < 10; i++)
            {
                int nr=rnd.Next(1,7);
                Console.WriteLine(nr);
                switch (nr)
                {
                    case 1: paev = "Esmaspäev"; break;
                    case 2: paev = "Teisipäev"; break;
                    case 3: paev = "Kolmapäev";break;
                    case 4: paev = "Neljapäev"; break;
                    case 5: paev = "Reede"; break;
                    case 6: paev = "Laupäev"; break;
                    case 7: paev = "Pühapäev"; break;
                    default:
                        paev = "Tundmatu päev";
                        break;
                }
                Console.WriteLine(paev);
            }
            int j = 0;
            while (j<10)
            {
                Console.WriteLine(paev);
                j++;
            }
            Console.WriteLine(j);
            do
            {
                Console.WriteLine(paev);
                j--;

            } while (j!=0);
            Console.WriteLine(j);
            int[] arvud= new int[10];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(-100, 100);
            }
            foreach (int arv in arvud)
            {
                if (arv<0)
                {
                    //Console.Beep();
                }
                Console.WriteLine(arv);
            }

            */
            /*Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Tere tulemast!\nMis on sinu nimi?");
            string eesnimi=Console.ReadLine();
            Console.WriteLine("Tere "+eesnimi);
            //&&-and ||-or
            if (eesnimi.ToUpper()=="JUKU")
            {
                Console.WriteLine("Lähme kinno!\nKui vana sa oled?");
                int vanus=int.Parse(Console.ReadLine());
                if (vanus<0 || vanus>100)
                {
                    Console.WriteLine("Viga!");
                }
                else if (vanus<=6)
                {
                    Console.WriteLine("Tasuta pilet!");
                }
                else if (vanus <= 15)
                {
                    Console.WriteLine("Lastepilet!");
                }
                else if (vanus <= 65)
                {
                    Console.WriteLine("Täispilet!");
                }
                else if (vanus <= 100)
                {
                    Console.WriteLine("Sooduspilet!");
                }
            }
            Console.Clear();*/
            /*Console.WriteLine("Arv1: ");

            int arv1=int.Parse(Console.ReadLine());
            Console.WriteLine("Arv2: ");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tehe: ");
            char tehe =char.Parse(Console.ReadLine());
            if (tehe=='+')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}",arv1,arv2,arv1+arv2);
            }
            else if (tehe=='-')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 - arv2);
            }
            */

            Console.ReadKey();
        }
    }
}
