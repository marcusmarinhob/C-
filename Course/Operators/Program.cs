using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10, num2 = 5;
            double media;
            string consoleMessage;

            media = (num1 + num2)/2;

            consoleMessage = "Número 1: " + num1;                        
            Console.WriteLine(consoleMessage);

            consoleMessage = "Número 2: " + num2;                        
            Console.WriteLine(consoleMessage);

            consoleMessage = "\r";                      
            Console.WriteLine(consoleMessage);

            consoleMessage = "Média: " + media;                        
            Console.WriteLine(consoleMessage);
        }
    }
}
