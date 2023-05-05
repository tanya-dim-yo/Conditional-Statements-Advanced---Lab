using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double cost = 0;
            if (fruit == "banana")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thirsday" || day == "Friday")
                {
                    cost = quantity * 2.50;
                    Console.WriteLine("{0:f2}", cost);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    cost = quantity * 2.70;
                    Console.WriteLine("{0:f2}", cost);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "apple")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thirsday" || day == "Friday")
                {
                    cost = quantity * 1.20;
                    Console.WriteLine("{0:f2}", cost);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    cost = quantity * 1.25;
                    Console.WriteLine("{0:f2}", cost);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "orange")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thirsday" || day == "Friday")
                {
                    cost = quantity * 0.85;
                    Console.WriteLine("{0:f2}", cost);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    cost = quantity * 0.90;
                    Console.WriteLine("{0:f2}", cost);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "grapefruit")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thirsday" || day == "Friday")
                {
                    cost = quantity * 1.45;
                    Console.WriteLine("{0:f2}", cost);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    cost = quantity * 1.60;
                    Console.WriteLine("{0:f2}", cost);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "kiwi")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thirsday" || day == "Friday")
                {
                    cost = quantity * 2.70;
                    Console.WriteLine("{0:f2}", cost);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    cost = quantity * 3.0;
                    Console.WriteLine("{0:f2}", cost);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "pineapple")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thirsday" || day == "Friday")
                {
                    cost = quantity * 5.50;
                    Console.WriteLine("{0:f2}", cost);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    cost = quantity * 5.60;
                    Console.WriteLine("{0:f2}", cost);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "grapes")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thirsday" || day == "Friday")
                {
                    cost = quantity * 3.85;
                    Console.WriteLine("{0:f2}", cost);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    cost = quantity * 4.20;
                    Console.WriteLine("{0:f2}", cost);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}