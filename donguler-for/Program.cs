using System;

namespace donguler_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar tek sayıları yazdır
            Console.Write("Bir sayı giriniz: ");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını yazdır
            int tekToplam=0;
            int ciftToplam=0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i%2==0)
                    ciftToplam+=i;
                else
                    tekToplam+=i;
            }
            Console.WriteLine("Çift sayıların toplamı: "+ciftToplam);
            Console.WriteLine("Tek sayıların toplamı: "+tekToplam);

            //Break koşul sağlandığında döngüden çıkar
            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                    break;
                Console.WriteLine(i);
            }
            //Continue koşulu sağlandığında o koşulu çıkarır ve döngüye devam eder
            for (int i = 0; i < 10; i++)
            {
                 if (i==4)
                    continue;
                Console.WriteLine(i); 
            }
        }
    }
}
