using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedBy5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers That Can Be Divided By 5 is: ");
            for (int i = 0;  i <= 100;  i++)
            {
                if (i % 5 == 0) 
                {
                    Console.WriteLine("" + i);
                }
            }
            Console.ReadKey();
        }
    }
}
