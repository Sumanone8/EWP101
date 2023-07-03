using System;

namespace PracticeSheet
{
    class PracticeClass
    {
        public void DoPractice()
        {
            Console.WriteLine(" Welcome to Employment Wage Problem 101");

            //UC1
            Random random = new Random();
            bool isPresent = random.Next(2) == 0;

            if (isPresent)
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");

            }
        }
    }
}