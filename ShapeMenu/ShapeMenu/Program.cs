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
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("4. Exit");
                Console.Write("Please choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PrintRectangle();
                        break;
                    case 2:
                        PrintSquareTriangle();
                        break;
                    case 3:
                        PrintIsoscelesTriangle();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void PrintRectangle()
        {
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintSquareTriangle()
        {
            Console.WriteLine("Select position for the right angle:");
            Console.WriteLine("1. Bottom-left");
            Console.WriteLine("2. Top-left");
            Console.Write("Your choice: ");
            int position = int.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());

            if (position == 1) // Bottom-left
            {
                for (int i = 1; i <= height; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else if (position == 2) // Top-left
            {
                for (int i = height; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }

        static void PrintIsoscelesTriangle()
        {
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
