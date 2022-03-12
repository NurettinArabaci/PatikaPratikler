using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //1den başlayarak girilen sayıya kadar ortalamayı hesaplama
            Console.Write("Bir sayı giriniz: ");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while(sayac<=sayi){
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama: "+toplam/sayi);

            //a'dan başlayarak z'ye kadar bütün harfleri yazdır
            char character='a';
            while (character<'z')
            {
                Console.Write(character+" ");
                character++;
            }

            Console.WriteLine("*****Foreach döngüsü*****");

            int [] sayilar={1,2,3,4,14,25,-4};

            foreach (var item in sayilar)
            {
                Console.Write(item+" ");
            }


        }
    }
}
