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
            double Area;
            double Perimeter;
            double Volume;
            string again;
            bool repeat = true;

            Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator");

            while (repeat == true)
            {
                Console.WriteLine("Please Enter Width:");
                Width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Length:");
                Length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Height:");
                Height = double.Parse(Console.ReadLine());

                Area = Width * Length;
                Perimeter = (2 * Width) + (2 * Length);
                Volume = (Length * Width * Height);

                Console.WriteLine($"Area: {Area}");
                Console.WriteLine($"Perimeter: {Perimeter}");
                Console.WriteLine($"Volume: {Volume}");

                Console.WriteLine("Continue? (y/n)");
                again = Console.ReadLine();

                if (again == "Y" || again == "y" )
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                    Console.WriteLine("Goodbye!!");
                }

            


            }
            
        }
    }
}
