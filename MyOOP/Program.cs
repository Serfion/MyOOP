using System;
using System.Collections.Generic;

namespace MyOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');

            HorisontalLine line = new HorisontalLine(6, 13, 5, '*');
            line.Draw();

          


            Console.ReadKey();
        }


    }
}
