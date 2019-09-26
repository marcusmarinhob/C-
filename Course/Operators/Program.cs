using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10, num2 = 5;
            double soma, sub, mult, div;
            string consoleMessage;

            soma = num1 + num2;
            sub  = num1 - num2;
            mult = num1 * num2;
            div  = num1 / num2;


            consoleMessage = "Número 1: " + num1;                        
            Console.WriteLine(consoleMessage);

            consoleMessage = "Número 2: " + num2;                        
            Console.WriteLine(consoleMessage);

            consoleMessage = "\r";
            Console.WriteLine(consoleMessage);

            consoleMessage = "Soma: " + soma;                        
            Console.WriteLine(consoleMessage);

            consoleMessage = "Subtração: " + sub;                        
            Console.WriteLine(consoleMessage);

            consoleMessage = "Multiplicação: " + mult;                        
            Console.WriteLine(consoleMessage);

            consoleMessage = "Divisão: " + div;                        
            Console.WriteLine(consoleMessage);
        }
    }
}
