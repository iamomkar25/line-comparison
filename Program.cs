using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Length;
            Console.WriteLine("Enter the value of x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double Xpower = Math.Pow((x2 - x1), 2);
            double Ypower = Math.Pow((y2 - y1), 2);

            Length = Math.Sqrt((Xpower + Ypower));

            Console.WriteLine($"Length of line using two points ({x1},{x1}) and ({y2},{y2}) is : {Length}");

        }
    }
}
