using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int num2 = Int32.Parse(age);
            int newAge = num2 + 5;
            Console.WriteLine("Your age in 5 years is going to be " + newAge);
        }
    }
}
