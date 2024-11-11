using System;
using System.IO;

namespace FileDataReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] emri;
            string[] mbiemri;
            int[] mosha;

            string filePath = "C:\\Users\\Admin\\Desktop\\PersonDataReader\\FileDataReader\\emrat.txt";

            string[] rreshtat = File.ReadAllLines(filePath);

            emri = new string[rreshtat.Length];
            mbiemri = new string[rreshtat.Length];
            mosha = new int[rreshtat.Length];

            for (int i = 0; i < rreshtat.Length; i++)
            {
                string[] ndarja = rreshtat[i].Split(' ');

                if (ndarja.Length == 3)
                {
                    emri[i] = ndarja[0];
                    mbiemri[i] = ndarja[1];
                    mosha[i] = int.Parse(ndarja[2]);
                }
                else
                {
                    Console.WriteLine($"Error parsing line {i + 1}: {rreshtat[i]}");
                }
            }

            Console.WriteLine("Emri\t\tMbiemri\t\tMosha");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < emri.Length; i++)
            {
                if (emri[i] != null)
                {
                    Console.WriteLine($"{emri[i]}\t\t{mbiemri[i]}\t\t{mosha[i]}");
                }
            }

        }
    }
}

