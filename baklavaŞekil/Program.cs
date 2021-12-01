using System;

namespace baklavaŞekil
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, i, k, sayac = 1;
            Console.Write("Satır sayısı giriniz\n");
            sayi = int.Parse(Console.ReadLine());
            sayac = sayi - 1;
            for (k = 1; k <= sayi; k++)
            {
                for (i = 1; i <= sayac; i++)
                    Console.Write(" ");
                sayac--;
                for (i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            sayac = 1;
            for (k = 1; k <= sayi - 1; k++)
            {
                for (i = 1; i <= sayac; i++)
                    Console.Write(" ");
                sayac++;
                for (i = 1; i <= 2 * (sayi - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
