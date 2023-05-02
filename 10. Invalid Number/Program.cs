using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 100 && number != 0)
            {
                Console.WriteLine("invalid");
            }
            else if (number > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}