using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Marcus";
            double salary_1 = 100.0;
            double salary_2 = 250.0;
            double soma = salary_1 + salary_2;

            string consoleMessage = name + " receives R$" + soma + " in a month!";
                        
            Console.WriteLine(consoleMessage);
        }
    }
}
