using System;
using System.Collections.Generic;

namespace ListDataReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> teDhenat = new List<string>
            {
                "Blina Sopjani 19",
                "Besa Leka 29",
                "Dritan Gashi 34",
                "Elira Ismaili 25",
                "Fadil Hoxha 32",
                "Gerta Nikolla 28"

            };
            string[] emri = new string[teDhenat.Count];
            string[] mbiemri = new string[teDhenat.Count];
            int[] mosha = new int[teDhenat.Count];

            for (int i = 0; i < teDhenat.Count; i++) 
            {
                string[] ndarja = teDhenat[i].Split(' ');

                if (ndarja.Length == 3)
                {
                    emri[i] = ndarja[0];
                    mbiemri[i] = ndarja[1];
                    mosha[i] = int.Parse(ndarja[2]);
                }
                else
                {
                    Console.WriteLine($"Error parsing line {i + 1}: {teDhenat[i]}");
                }
            }
            Console.WriteLine("Emri\t\tMbiemri\tMosha");
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < emri.Length; i++)
            {
                Console.WriteLine($"{emri[i]}\t\t{mbiemri[i]}\t\t{mosha[i]}");
            }

            Statistikat.KalkuloStatistikat(emri, mbiemri, mosha);

        }
    }
    public class Statistikat
    {
        public static void KalkuloStatistikat(string[] emri, string[] mbiemri, int[] mosha)
        {
            int me_i_riu = int.MaxValue;
            int me_i_vjetri = int.MinValue;
            int mosha_totale = 0;
            int index_i_riu = -1;
            int index_vjetri = -1;

            for (int i = 0; i < mosha.Length; i++)
            {
                int age = mosha[i];
                mosha_totale += age;

                if (age < me_i_riu)
                {
                    me_i_riu = age;
                    index_i_riu = i;
                }

                if (age > me_i_vjetri)
                {
                    me_i_vjetri = age;
                    index_vjetri = i;
                }
            }

            double mosha_mesatare = (double)mosha_totale / mosha.Length;

            Console.WriteLine("\nStatistikat:");
            Console.WriteLine("Personi më i ri: " + emri[index_i_riu] + " " + mbiemri[index_i_riu] + " - Mosha: " + me_i_riu);
            Console.WriteLine("Personi më i vjetër: " + emri[index_vjetri] + " " + mbiemri[index_vjetri] + " - Mosha: " + me_i_vjetri);
            Console.WriteLine("Mosha mesatare: " + mosha_mesatare.ToString("0.00"));
        }
    }
}
