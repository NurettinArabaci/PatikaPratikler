using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hatayı kontrol etmek istediğimiz kod bloğu
            try 
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi= int.Parse(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı: "+sayi);
            }

            //Hatayı yakalayınca ne olacağını belirlediğimiz kod
            catch(Exception exc)
            {
                Console.WriteLine("Hata "+ exc.Message+" Lütfen Tekrar Deneyiniz..");
            }

            //Kullanımı zorunlu değil, hata olsa da olmasa da sonda çalışan kod bloğu
            finally
            {
                Console.WriteLine("İşlem tamamlandı!");
            }


            try
            {
                int a = int.Parse(null);
                int b = int.Parse("test");
                int c = int.Parse("11111111111");
            }
            //Boş değer hatası = try daki a için
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş bir değer girdiniz.");
                Console.WriteLine(ex); 
            }
            //Uygunsuz format uyarısı = b için
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex); 
            }
            //Kapsama alanı dışına çıkma hatası(int en fazla 10 haneli olabilir) = c için
            catch(OverflowException ex)
            {
                Console.WriteLine("Girilen sayi çok küçük ya da çok büyük!");
                Console.WriteLine(ex);
            }

            finally{System.Console.WriteLine("İşlem başarılı");}

        }
    }
}
