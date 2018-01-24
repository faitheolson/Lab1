using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Width;
            double Length;
            double Height;
            string again;
            bool repeat = true;

            Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator!!!");

            while (repeat == true)
            {

                Console.WriteLine("Please Enter Width:");
                Width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Length:");
                Length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Height:");
                Height = double.Parse(Console.ReadLine());


                Console.WriteLine($"Area: {Area(Width,Length)}");
                Console.WriteLine($"Perimeter: {Perimeter(Width,Length)}");
                Console.WriteLine($"Volume: {Volume(Width,Length,Height)}");

                Console.WriteLine("Continue? (y/n)");
                again = Console.ReadLine();

                if (again == "Y" || again == "y" )
                {
                    repeat = true;
                    Console.Clear();
                }
                else
                {
                    repeat = false;
                    Console.Clear();
                    Console.WriteLine("Goodbye!!");
                }
            }
        }

        public static double Area(double Width, double Length)
        {
            return Width * Length;
        }

        public static double Perimeter(double Width, double Length)
        {
            return (2 * Width) + (2 * Length);

        }

        public static double Volume(double Width, double Length, double Height)
        {
            return (Length * Width * Height);

        }
    }
}
