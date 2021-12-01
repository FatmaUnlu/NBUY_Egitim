using System;

namespace methodKullanım2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref ve out 

            //int a = 5;
            //RefMethod(a);
            //Console.WriteLine(a); //bu şekilde olursa a=5 gelir.methodun başında ref yokken
            int a = 5;
            RefMethod(ref a);
            Console.WriteLine(a); //bu şekilde olursa a=10 olur. Eğer int değil de ref olsaydı a ve b nin değişken tipi, a=20 gelirdi
            
            if (DonusturmeyiDene("123", out int cevap)) // string olaarak gönderilen 123, int değere dönüştürlmek isteniyor, eğer dönüştürülürse out paramaetresi ile gönderilen cevap değerineaktarılır yazdırılıyor ve sonuc değeri olarak true döner.
            {
                Console.WriteLine(cevap);
            }

            //TryParse Türkçesini yazalım. Aşağıdaki türkçesi aynı sonucu verir.

            Tuple<bool, int> tuple = DonusturmeyiDene("28579"); //tuple tipideğer döndüren bir metotu çağırıyoruz üstte olduğu gibi.item1= bool değer döner, item2 = int bir değer döner. Yukarıdaki outlu işlemin aynısı aslında
            if (tuple.Item1)
            {
                Console.WriteLine(tuple.Item2);
            }


        }

        static void RefMethod(ref int a)
        {

            int b = 10;
            a = b;
            b = 20;
        }

        static Tuple<bool, int> DonusturmeyiDene(string ifade)//out kullanmadan iki parametre döndürebiliriz Tuple sayesinde. Bu oluşturduğumuz nesne sayesinde 
        {

            try
            {
                int sonuc = int.Parse(ifade);
                return new Tuple<bool, int>(true, sonuc);
            }
            catch
            {
                return new Tuple<bool, int>(false, 0);
            }          

        }

        //Try Parse Türkçe kodu
        static bool DonusturmeyiDene(string ifade, out int sonuc) 
        {

            try
            {
                sonuc = int.Parse(ifade);
                return true;
            }
            catch
            {
                sonuc = 0;

                return false;
            }

        }
       
    }
}
