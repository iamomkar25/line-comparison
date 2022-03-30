using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatAndLess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Length;
            Console.WriteLine("Enter the value of x1:");
            int x1x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            int x2x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y1:");
            int y1x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y2:");
            int y2x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x1:");
            int x1y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            int x2y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y1:");
            int y1y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y2:");
            int y2y = Convert.ToInt32(Console.ReadLine());

            double squareXx = (x2x - x1x) * (x2x - x1x);
            double squareYx = (y2x - y1x) * (y2x - y1x);
            double squareXy = (x2y - x1y) * (x2y - x1y);
            double squareYy = (y2y - y1y) * (y2y - y1y);
            double lengthOfLine1 = Math.Sqrt(squareXx + squareYx);
            double lengthOfLine2 = Math.Sqrt(squareXy + squareYy);
            if (lengthOfLine1 == lengthOfLine2)
            {
                Console.WriteLine("Length of Two Lines are Equal");
            }
            else if (lengthOfLine1 > lengthOfLine2)
            {
                Console.WriteLine("Length of Line1 is Greater than Line 2 ");
            }

            else if (lengthOfLine1 < lengthOfLine2)
            {
                Console.WriteLine("Length of Line1 is lesser than Line 2 ");
            }
        }
    }
}
