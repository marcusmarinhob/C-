using System;

namespace InputFromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Variables *********************************************/
            double num1, num2;
            double soma, sub, mult, div;
            string consoleMessage;

            /* Inputs ************************************************/
            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse( Console.ReadLine() );  

            Console.Write("Digite o segundo número: ");
            num2 = double.Parse( Console.ReadLine() );  

            /** Operations *******************************************/
            soma = num1 + num2;
            sub  = num1 - num2;
            mult = num1 * num2;
            div  = num1 / num2;

            /** Outputs ***********************************************/
            consoleMessage = "\n";                        
            Console.WriteLine(consoleMessage);

            consoleMessage = "Soma: " + soma;                        
            Console.WriteLine(consoleMessage);

            consoleMessage = "Subtração: " + sub;                        
            Console.WriteLine(consoleMessage);

            consoleMessage = "Multiplicação: " + mult;                        
            Console.WriteLine(consoleMessage);

            consoleMessage = "Divisão: " + div;                        
            Console.WriteLine(consoleMessage);

            /** *******************************************************/

        }
    }
}
