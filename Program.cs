using System;

namespace PracticeSheet
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Suman! Welcome.");
            Console.WriteLine("Please enter the purpose of your practice:");
            string purpose = Console.ReadLine();
            Console.WriteLine("Today we are going to practice " + purpose);
            Console.WriteLine("Let's begin!");

            PracticeClass practice = new PracticeClass();
            practice.DoPractice();

            Console.WriteLine("Practice session complete. Goodbye!");
            Console.ReadLine();
        }
    }
}
