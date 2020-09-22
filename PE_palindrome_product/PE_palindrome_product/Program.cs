using System;
using System.Collections.Generic;

namespace PE_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int laenge;

            Console.WriteLine("Länge eingeben:");
            laenge = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            string set = "";

            while (i < laenge)
            {
                set = set + "9";
                i++;
            }

            int a = Convert.ToInt32(set);
            int b = Convert.ToInt32(set);


            List<int> produkte = new List<int> { };

            while (a > 0)
            {
                while (b > 0)
                {
                    produkte.Add(a * b);
                    b--;
                }
                a--;
                b = a;
            }

            produkte.Sort();

            foreach (var produkt in produkte)
            {
                Console.WriteLine("Produkt = " + produkt);
            }




            Console.ReadKey();
        }
    }
}
