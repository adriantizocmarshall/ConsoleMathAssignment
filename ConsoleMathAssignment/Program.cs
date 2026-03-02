using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMathAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Takes entered number and multiplies by 50
            Console.WriteLine("Please enter a number to be multiplied by 50.");
            int a = Int32.Parse(Console.ReadLine()) * 50;
            Console.WriteLine(a);
            Console.ReadLine();

            // Takes entered number and adds 25
            Console.WriteLine("Please enter a number to be added to 25.");
            int b = Int32.Parse(Console.ReadLine()) + 25;
            Console.WriteLine(b);
            Console.ReadLine();

            // Takes entered number and divides by 12.5
            Console.WriteLine("Please enter a number to be divided by 12.5.");
            double c = Double.Parse(Console.ReadLine()) / 12.5;
            Console.WriteLine(c);
            Console.ReadLine();

            // Takes entered number and checks if it is greater than or equal to 50
            Console.WriteLine("Please enter a number from 1 to 50.");
            bool d = Int32.Parse(Console.ReadLine()) >= 50;
            Console.WriteLine(d);
            Console.ReadLine();

            // Takes entered number and returns modulus of 7
            Console.WriteLine("Please enter a number to be divided by 7.");
            int f = Int32.Parse(Console.ReadLine()) % 7;
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
