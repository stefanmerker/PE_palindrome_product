using System;
using System.IO;
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


            List<Ergebnis> ergebnisse = new List<Ergebnis>();

            int produkt;

            while (a > 0)
            {
                while (b > 0)
                {
                    produkt = a * b;

                    if (Palindrom(produkt))
                    {
                        ergebnisse.Add(new Ergebnis() {a=a, b=b, produkt=produkt});
                        //Console.WriteLine("Palindrom gefunden: " + ergebnisse[ergebnisse.Count-1].a + " * " + ergebnisse[ergebnisse.Count-1].b + " = " + ergebnisse[ergebnisse.Count-1].produkt);
                    }else
                    {
                        //Console.WriteLine(produkt + " ist kein Palindrom.");
                    }
                    b--;
                }
                a--;
                b = a;
            }

            ergebnisse.Sort(CompareErgebnisse);

            ergebnisse.Reverse();

            Console.WriteLine("größtes Palimdrom ist " + ergebnisse[0].produkt + " aus a = " + ergebnisse[0].a + " und b = " + ergebnisse[0].b);

            Console.ReadKey();
        }
        public static int CompareErgebnisse(Ergebnis er1, Ergebnis er2)
        {
            return er1.produkt.CompareTo(er2.produkt);
        }

        static public bool Palindrom (int produkt)
        {
            int left = produkt;
            int rev = 0;
            while (Convert.ToBoolean(left))
            {
                int r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10); 
            }

            if (produkt == rev)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Ergebnis
    {
        public int produkt { get; set; }
        public int a { get; set; }
        public int b { get; set; }
    }

}
