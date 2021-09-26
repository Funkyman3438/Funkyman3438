using System;

namespace Exam1_Modul
{
    class Calculator
    {
        public void charchters()
        {
            int a = 1;
            double b;
            int c = 3 ;
            b = a + c;
            Console.WriteLine("Сумма а и с равна:" + b);
                

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator sum = new Calculator();
            sum.charchters();
            Console.ReadKey();
        }
    }
}
