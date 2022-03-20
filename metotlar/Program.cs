using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =5;
            int b=12;
            Console.WriteLine(a+b);

            int result=Multi(a,b);
            Console.WriteLine(result);

            Metot exam = new Metot();
            exam.PrintScreen(result.ToString());

            int result2 = exam.IncreaseAndSum(ref a,ref b);
            exam.PrintScreen(Convert.ToString(result2));
            exam.PrintScreen(Convert.ToString(a+b));
        }

        static int Multi(int value1, int value2)
        {
            return (value1+value2);
        }
    }

    class Metot
    {
        public void PrintScreen(string veri)
        {
            Console.WriteLine(veri);
        }

        public int IncreaseAndSum(ref int value1,ref int value2)
        {
            value1+=1;
            value2+=1;
            return (value1+value2);
        }
    }
}
