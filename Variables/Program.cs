using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string consoleMsg;

            string name    = "Marcus";
            int    age     = 28;
            bool   married = false;
            double height  = 1.75;


            
            consoleMsg = "Name: " + name;
            Console.WriteLine(consoleMsg);

            consoleMsg = "Age: " + age;
            Console.WriteLine(consoleMsg);

            consoleMsg = "Married: " + married;
            Console.WriteLine(consoleMsg);

            consoleMsg = "Height: " + height;
            Console.WriteLine(consoleMsg);

            

            

            
        }
    }
}
