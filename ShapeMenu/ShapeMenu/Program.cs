using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Shape Menu!");
                Console.WriteLine("1. Print A Rectangle");
                Console.WriteLine("2. Print A Square Triangle (The corner is square at \n4 different angles: top-left, top-right, bottom-left, bottom-right))");
                Console.WriteLine("3. Print A Isosceles Triangle");
                Console.WriteLine("4. Exit");
                Console.WriteLine();

                Console.Write("Enter Your Choice (1-4): ");
                string input = Console.ReadLine();
                int choice;

                // Check if input is a valid integer
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        break;
                }
            }
        }
    }
}
