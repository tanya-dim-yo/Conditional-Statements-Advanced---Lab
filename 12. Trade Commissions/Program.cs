using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;
            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500.0)
                {
                    commission = sales * 0.05;
                    Console.WriteLine("{0:f2}", commission);
                }
                else if (sales > 500.0 && sales <= 1000.0)
                {
                    commission = sales * 0.07;
                    Console.WriteLine("{0:f2}", commission);
                }
                else if (sales > 1000.0 && sales <= 10000.0)
                {
                    commission = sales * 0.08;
                    Console.WriteLine("{0:f2}", commission);
                }
                else if (sales > 10000.0)
                {
                    commission = sales * 0.12;
                    Console.WriteLine("{0:f2}", commission);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500.0)
                {
                    commission = sales * 0.045;
                    Console.WriteLine("{0:f2}", commission);
                }
                else if (sales > 500.0 && sales <= 1000.0)
                {
                    commission = sales * 0.075;
                    Console.WriteLine("{0:f2}", commission);
                }
                else if (sales > 1000.0 && sales <= 10000.0)
                {
                    commission = sales * 0.1;
                    Console.WriteLine("{0:f2}", commission);
                }
                else if (sales > 10000.0)
                {
                    commission = sales * 0.13;
                    Console.WriteLine("{0:f2}", commission);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500.0)
                {
                    commission = sales * 0.055;
                    Console.WriteLine("{0:f2}", commission);
                }
                else if (sales > 500.0 && sales <= 1000.0)
                {
                    commission = sales * 0.08;
                    Console.WriteLine("{0:f2}", commission);
                }
                else if (sales > 1000.0 && sales <= 10000.0)
                {
                    commission = sales * 0.12;
                    Console.WriteLine("{0:f2}", commission);
                }
                else if (sales > 10000.0)
                {
                    commission = sales * 0.145;
                    Console.WriteLine("{0:f2}", commission);
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