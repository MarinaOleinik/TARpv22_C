using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace TARpv22_C
{
    public class Alamprog
    {
        public async Task Tagaplaanis_Mangida(string Path)
        {
            await Task.Run(() =>
            {
                using (AudioFileReader audioFileReader = new AudioFileReader(Path))
                using (IWavePlayer waveOutDevice = new WaveOutEvent { DesiredLatency = 200})
                {
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                    while (waveOutDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(1000);
                    }
                }
            });
        }
        public async Task Natuke_mangida(string Path)
        {
            await Task.Run(() =>
            {
                using (AudioFileReader audioFileReader = new AudioFileReader(Path))
                using (IWavePlayer waveOutDevice = new WaveOutEvent())
                {
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                    while (waveOutDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(50);
                    }
                }
            });
        }
        

        public KeyValuePair<Dictionary<string, string>, Dictionary<string, string>> Minufunktion(string file)
        {
            Dictionary<string, string> dic1= new Dictionary<string, string>();
            Dictionary<string, string> dic2 = new Dictionary<string, string>();

            return new KeyValuePair<Dictionary<string, string>, Dictionary<string, string>>(dic1,dic2);
        }



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
