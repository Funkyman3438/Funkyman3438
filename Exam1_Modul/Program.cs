using System;

namespace Exam1_Modul
{
    class Calculator
    {
        public void rabota()
        {
            int a = 1;
            double b;
            int c = 3 ;
            b = a + c;
            Console.WriteLine("Сумма а и с равна: \n"+ b);
            Console.WriteLine("Попробуй сам ввести цифры\n");
            Console.WriteLine("Введи d:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи e:");
            int e = Convert.ToInt32(Console.ReadLine());
            double f = d + e;
            Console.WriteLine("Вот тебе и результатик: " + f);



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator sum = new Calculator();
            sum.rabota();
            Console.ReadKey();
        }
    }
}
