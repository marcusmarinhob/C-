using System;

namespace InputFromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();  

            Console.WriteLine("O nome digitado foi: " + nome);
        }
    }
}
