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
            string Answer;
            do
            {

                // Input

                double Width;
                double Length;
                double Height;

                Console.WriteLine("Please enter the width");
                Width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the length");
                Length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height");
                Height = double.Parse(Console.ReadLine());

                



                // Processing

                double Area = Width * Length;
                double Perimeter = 2 * Width + 2 * Length;
                double Volume = Width * Length * Height;

                // Output

                Console.WriteLine("The area is " + Area + " units squared and the perimeter is " + Perimeter + " units.");
                Console.WriteLine("The volume is " + Volume + " units cubed.");

                Console.WriteLine("Would you like to continue?");
                Answer = Console.ReadLine();
            }
            while (Answer == "Y");
        }
    }
}
