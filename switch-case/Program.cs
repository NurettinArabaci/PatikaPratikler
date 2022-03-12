﻿using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //teker teker case yazma durumu
            switch (month)
            {
                case 1:
                 Console.WriteLine("Ocak ayındasınız");
                 break;
                case 2:
                 Console.WriteLine("Şubat ayındasınız");
                 break;
                case 4:
                 Console.WriteLine("Nisan ayındasınız");
                 break;
                case 3:
                 Console.WriteLine("Mart ayındasınız");
                 break;

                default:
                Console.WriteLine("Yanlış veri");
                break;
            }

            //Çoklu case yazma durumu
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindesiniz!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindesiniz!");
                    break;    
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz!");
                    break;
                default:
                break;
            }
        }
    }
}