using System;

namespace BomOyunu
{
    class Program
    {
        static void Main(string[] args)

        {
            bool iscontinue = true;

            while (iscontinue)
            {
                Console.WriteLine("BOM denilmesi istenilen sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Sıra sizde ");
                        string girilenDeger = Console.ReadLine();
                        //int girilenDeger2 = Convert.ToInt32(girilenDeger);
                        try
                        {
                            if ("BOM".Equals(girilenDeger.ToUpper()) || Convert.ToInt32(girilenDeger) == i)
                            {

                                if ("BOM".Equals(girilenDeger.ToUpper()) && i % sayi == 0)
                                {
                                    continue;
                                }
                                else if (!"BOM".Equals(girilenDeger.ToUpper()) && i % sayi == 0)
                                {
                                    Console.WriteLine("Kaybettiniz ");
                                }
                                else
                                {
                                    Console.WriteLine("Kaybettiniz ");
                                    break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sıra bilgisayarda");
                        if (i % sayi == 0)
                        {
                            Console.WriteLine("BOM");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                }

                Console.WriteLine("Tekrar oynamak icin 1 bitirmek icin 0 giriniz ?");
                iscontinue = Console.ReadLine() == "1";

            }
        }
    }
}
