using System;

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

            int product = a * b;

            Console.WriteLine(a + " * " + b + " = " + product);
            Console.ReadKey();
        }
    }
}
