using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace TARpv22_C
{
    public class StartClass
    {       
        public static void Main(string[] args)
        {
            //SoundPlayer laul = new SoundPlayer("../../../naidis_laul.wav");
            //laul.Play();



            //IWavePlayer waveOutDevice = new WaveOutEvent();
            //AudioFileReader audioFileReader = new AudioFileReader("../../../Lindude_laul.mp3");
            //waveOutDevice.Init(audioFileReader);
            //waveOutDevice.Play();
            Console.OutputEncoding = System.Text.UTF8Encoding.UTF8;

            Alamprog mäng = new Alamprog();
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            _ = mäng.Tagaplaanis_Mangida("../../../people-and-trees.mp3");
            while (true)
            {
                
                nupp = Console.ReadKey();
                if (nupp.Key==ConsoleKey.C)
                {
                    Console.WriteLine("\x263A");
                   
                    _ = mäng.Natuke_mangida("../../../Apple.mp3");
                }
            }

            /*
             waveOutDevice.Stop();
             audioFileReader.Dispose();
             waveOutDevice.Dispose();
            */
            //try
            //{
            //    StreamWriter text = new StreamWriter(@"..\..\..\TextFile.txt", true);
            //    Console.WriteLine("Sisesta maakonna nimetus: ");
            //    string maakond = Console.ReadLine();
            //    Console.WriteLine("Sisesta linna nimetus: ");
            //    string linn = Console.ReadLine();
            //    string lause = maakond+"-"+linn;
            //    text.WriteLine(lause);
            //    text.Close();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga failiga!");
            //}
            //try
            //{
            //    StreamReader text = new StreamReader(@"..\..\..\TextFile.txt");
            //    string laused=text.ReadToEnd();
            //    text.Close();
            //    Console.WriteLine("Failis on järgmine informatsion:\n");
            //    Console.WriteLine(laused);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga failiga!");
            //}

            //List<string> list_failist = new List<string>();
            //try
            //{
            //    foreach (string rida in File.ReadAllLines(@"..\..\..\TextFile.txt"))
            //    {
            //        list_failist.Add(rida);
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga failiga!");
            //}

            //string key="";
            //string value="";
            //Dictionary<string, string> maakond_linn = new Dictionary<string, string>();
            //foreach (var rida in list_failist)
            //{
            //    key = rida.Split('-')[0];//Harjumaa
            //    value = rida.Split('-')[1];//Tallinn
            //    maakond_linn.Add(key, value);
            //}
            //foreach (KeyValuePair<string, string> keyValue in maakond_linn)
            //{
            //    Console.WriteLine(keyValue.Key + " pealinn on " + keyValue.Value);
            //}

            //ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            //do
            //{
            //    Console.WriteLine("Vajuta Backspace");
            //    nupp = Console.ReadKey();
            //} while (nupp.Key != ConsoleKey.Backspace);



            /*Dictionary<int,string> dic = new Dictionary<int,string>(5);
            dic.Add(1, "üks");
            dic.Add(2, "kaks");
            dic[3] = "kolm";
            dic[4] = "neli";
            dic[5] = "viis";
            foreach (KeyValuePair<int,string> keyValue in dic)
            {
                Console.WriteLine(keyValue.Key + "-" + keyValue.Value);
            }

            Dictionary<int,Inimene> õpilased= new Dictionary<int,Inimene>(3);
            Inimene inimene = new Inimene();
            inimene.Nimi = "Mati";
            inimene.Vanus = 65;
            Inimene inimene2 = new Inimene();
            inimene2.Nimi = "Kati";
            inimene2.Vanus = 35;
            õpilased.Add(1, inimene);
            õpilased.Add(2,inimene2);
            õpilased.Add(3,new Inimene() { Nimi = "Marina", Vanus = 100 });
            foreach (Inimene item in õpilased.Values)
            {
                Console.WriteLine(item.Nimi);
            }

            foreach (KeyValuePair<int,Inimene> item in õpilased)
            {
                Console.WriteLine(item.Key + ": " + item.Value.Nimi);
            }*/

            /*List<Inimene> list = new List<Inimene>();
            Inimene inimene= new Inimene();
            inimene.Nimi = "Mati";
            inimene.Vanus = 65;
            list.Add(inimene);
            list.Add(new Inimene() { Nimi = "Kati" });

            foreach (Inimene item in list)
            {
                Console.WriteLine(item.Nimi);
            }*/




            /*ArrayList arrayList= new ArrayList();
            arrayList.Add("Esimene");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            if (arrayList.Contains("Teine"))
            {
                Console.WriteLine("Sõna Teine on olemas");
                Console.WriteLine("Teine asub kohal " + arrayList.IndexOf("Teine"));
            }
            else
            {
                Console.WriteLine("Otsitav sõna puudub");
            }
            Console.WriteLine("Kokku järjendis on "+arrayList.Count+" elemente");
            arrayList.Insert(3, "Neljas");
            arrayList.Insert(4, "Viies");
            arrayList.Sort();
            foreach (string item in arrayList)
            {
                Console.Write(item + ", ");
            }
            arrayList.RemoveAt(0);
            arrayList.Remove("Viies");
            arrayList.Clear();*/




            /*string nimi = "Python";
            Alamprog.Tere(nimi);
            int a = 12;
            int b = 13;
            int vastus=Alamprog.Korruta(a, b);
            Console.WriteLine(vastus);
            Console.WriteLine(Alamprog.Korruta(5, 6));
            Console.WriteLine(Alamprog.Kalkulaator(2, 3, '+'));*/
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
            //Random rnd = new Random();
            //string paev = "";
            //for (int i = 0; i < 10; i++)
            //{
            //    int nr=rnd.Next(1,7);
            //    Console.WriteLine(nr);
            //    switch (nr)
            //    {
            //        case 1: paev = "Esmaspäev"; break;
            //        case 2: paev = "Teisipäev"; break;
            //        case 3: paev = "Kolmapäev";break;
            //        case 4: paev = "Neljapäev"; break;
            //        case 5: paev = "Reede"; break;
            //        case 6: paev = "Laupäev"; break;
            //        case 7: paev = "Pühapäev"; break;
            //        default:
            //            paev = "Tundmatu päev";
            //            break;
            //    }
            //    Console.WriteLine(paev);
            //}

            //int j = 0;
            //while (j<10)
            //{
            //    Console.WriteLine(paev);
            //    j++;
            //}
            //Console.WriteLine(j);
            //do
            //{
            //    Console.WriteLine(paev);
            //    j--;

            //} while (j!=0);
            //Console.WriteLine(j);
            //int[] arvud= new int[10];
            //for (int i = 0; i < arvud.Length; i++)
            //{
            //    arvud[i] = rnd.Next(-100, 100);
            //}
            //foreach (int arv in arvud)
            //{
            //    if (arv<0)
            //    {
            //        Console.Beep();
            //    }
            //    Console.WriteLine(arv);
            //}


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
