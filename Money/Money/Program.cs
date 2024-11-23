using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 1.0;
            int month = 1;
            double interestRate = 5.5;

            Console.Write("Enter investment amount: ");
            money = Double.Parse(Console.ReadLine());

            Console.Write("Enter number of months: ");
            month = Int32.Parse(Console.ReadLine());

            double totalInterest = 0;
            for (int i = 0; i < month; i++)
            {
                totalInterest += money * (interestRate / 100) / 12;
            }

            Console.WriteLine("Total of interest: " + totalInterest);
            Console.ReadKey();
        }
    }
}
