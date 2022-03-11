using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //şimdiki saat değeri
            int time = DateTime.Now.Hour;

            //Normal if Kullanımı
            if(time>6 && time<11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time<18 && time>=11)
            {
                Console.WriteLine("İyi günler");
            }
            else
            {
                Console.WriteLine("İyi geceler");
            }

            //Ternary if kullanımı
            string sonuc= time>6 && time<11 ? "Günaydın": time<18 && time>=11 ? "İyi günler": "İyi geceler";
            Console.WriteLine(sonuc);
        }
    }
}
