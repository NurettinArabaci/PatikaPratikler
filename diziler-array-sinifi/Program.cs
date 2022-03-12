using System;

namespace diziler_array_sinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort methodu = sıralama için kullandığımız method
            int[] sayiDizisi={23,12,72,-8,17,3,11,86};

            Console.WriteLine("****Sırasız Dizi****");

            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            Console.WriteLine("****Sıralı Dizi****");

            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            
            //Clear methodu = seçilen indexten başlayarak verilen sayı kadar elemanı 0 yapar.
            Console.WriteLine("****Array Clear****");

            Array.Clear(sayiDizisi,2,3);
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            //Reverse methodu = elemanları ters sıralar. ilk eleman son sırada olur vb.
            Console.WriteLine("****Array Reverse****");

            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);


            //IndexOf methodu = Method içine yazılan elemanın kaçıncı index de olduğunu verir.
            Console.WriteLine("****Array IndexOf****");

            Console.WriteLine( Array.IndexOf(sayiDizisi,3)+". index"); //Output: 6.index


            //Resize methodu = referans verilen dizinin eleman sayısını yeniden boyutlandırır.
            Console.WriteLine("****Array Resize****");

            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            
            
            
        }
    }
}
