﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Equal
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Line Comparison Computation Program ");



            double length1 = 0;
        Console.WriteLine("Enter the first coordinate of first line");
            int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Second Coordinate of first line");
            int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("First Coordinate : " + x1 + "," + y1);
            Console.WriteLine("Second Coordinate : " + x2 + "," + y2);

            double calculated;
        Equal P = new Equal();
        calculated = P.Formula(x1, y1, x2, y2);


            length1 = length1 + calculated;
            Console.WriteLine("Calculated Lenth is {0}", length1);

            double length2 = 0;
        Console.WriteLine("Enter the first coordinate of second line");
            int x3 = Convert.ToInt32(Console.ReadLine());
        int y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Second Coordinate of second line");
            int x4 = Convert.ToInt32(Console.ReadLine());
        int y4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("First Coordinate : " + x3 + "," + y3);
            Console.WriteLine("Second Coordinate : " + x4 + "," + y4);

            double calculated2;
        Equal P1 = new Equal();
        calculated2 = P1.Formula(x3, y3, x4, y4);


            length2 = length2 + calculated2;
            Console.WriteLine("Calculated Lenth is {0}", length2);

            if (length1 == length2)
            {
                Console.WriteLine("The lines are equal");
            }
            else
            {
                Console.WriteLine("They are not equal");
            }




Console.ReadKey();
        }

        public double Formula(int x1, int y1, int x2, int y2)
{

    double formula = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    return formula;
}
    }
}
