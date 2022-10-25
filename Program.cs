using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int lava_hranica, prava_hranica, hodnota, index;
            char lava_zatvorka, prava_zatvorka;
            Console.Write("Zadaj interval: ");
            string interval = Console.ReadLine();
            index = interval.IndexOf(';');

            Console.Write("Zadaj hodnotu: ");
            hodnota = int.Parse(Console.ReadLine());
            

            lava_zatvorka = interval[0];
            lava_hranica = Convert.ToInt32(interval.Substring(1, index-1));

            prava_hranica = Convert.ToInt32(interval.Substring(index + 1, interval.Length - index - 2));
            prava_zatvorka = interval[interval.Length - 1];

            if(lava_zatvorka == '(') 
            {
                lava_hranica++;
            }
            if(prava_zatvorka == ')')
            {
                prava_hranica--;
            }
            vypocitajInterval(lava_hranica, prava_hranica, hodnota, interval);
           
            Console.ReadLine();
        }

        static void vypocitajInterval(int lava_hranica, int prava_hranica, int hodnota, string interval)
        {
            if(hodnota >= lava_hranica & hodnota <= prava_hranica)
            {
                Console.WriteLine($"Hodnota {hodnota} patri do intervalu {interval}");
            }
            else
            {
                Console.WriteLine($"Hodnota {hodnota} nepatri do intervalu {interval}");
            }
        }
    }
}