using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
             string[] renkler=new string[8];

            string[] hayvanlar={"fil","aslan","kuş"};

            int[] dizi;
            dizi=new int[5];

            //Dizilere değer atama ve erişim
            renkler[0]="mavi";

            dizi[3]=10;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalaması
            Console.Write("Dizinin eleman sayısını giriniz: ");
            int diziUzunlugu=int.Parse(Console.ReadLine());
            int[] sayiDizisi=new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
                
            }

            int toplam=0;
            foreach (var item in sayiDizisi)
            {
                toplam+=item;
            }
            Console.WriteLine("ortalama: "+toplam/diziUzunlugu);
        }
    }
}
