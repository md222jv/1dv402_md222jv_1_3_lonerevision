using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L03A
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            int antalLoner = 0;
            do
            {
                antalLoner = ReadInt("Hur många löner vill du beräkna? ");
                if (antalLoner < 2)
                {
                    Console.WriteLine("Felaktigt antal Löner. Du måste mata in minst två löner.");
                    Console.WriteLine("Tryck valfri tangent för ny beräkning - Esc avslutar");
                    ConsoleKeyInfo info = Console.ReadKey();
                    if (info.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                }
            }
            while (antalLoner < 2);

            ProcessSalaries(antalLoner);


            //Console.Write("Tryck valfri tangent för ny beräkning - Esc avslutar");
            //ConsoleKeyInfo info = Console.ReadKey();
            //if (info.Key == ConsoleKey.Escape)
            //{
            //    return;
            //}
            //}

        }

        static int ReadInt(string promt)
        {

            string input = null;
            while (true)
                try
                {
                    Console.Write(promt);
                    input = Console.ReadLine();
                    return int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("FEL! {0} kan inte tolkas som ett heltal", input);
                    //Console.WriteLine("Tryck valfri tangent för ny inmatning - Esc avslutar");
                    //ConsoleKeyInfo info = Console.ReadKey();
                    //if (info.Key == ConsoleKey.Escape)
                    //{
                    //    return false;
                    //}
                }



        }

        static void ProcessSalaries(int antalLoner)
        {
            int[] loner;
            int[] sorteradeLoner;
            int maxLon;
            int minLon;
            int spridning;
            int medianLon;
            int medianVarde;
            double medelLon;

            loner = new int[antalLoner];
            sorteradeLoner = new int[antalLoner];


            for (int i = 0; i < antalLoner; i++)
            {
                loner[i] = ReadInt("Mata in en lön: ");
            }

            maxLon = loner.Max();
            minLon = loner.Min();
            spridning = maxLon - minLon;
            medelLon = loner.Average();

            Array.Copy(loner, sorteradeLoner, antalLoner);
            Array.Sort(sorteradeLoner);

            if (antalLoner % 2 != 0)
            {
                medianVarde = (antalLoner / 2) + 1;
                medianLon = sorteradeLoner[medianVarde];
            }
            else  //(antalLoner % 2 == 0)
            {
                medianVarde = antalLoner / 2;
                medianLon = (sorteradeLoner[medianVarde] + sorteradeLoner[medianVarde + 1]) / 2;
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Medianlön:                  {0}", medianLon);
            Console.WriteLine("Medellön:                   {0}", medelLon);
            Console.WriteLine("Lönepridning:               {0}", spridning);
            Console.WriteLine("---------------------------------------");

            for (int i = 0; i < antalLoner; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write("     {0}", loner[i]);
            }
            Console.WriteLine();
            return;

        }
    }
}
