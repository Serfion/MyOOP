using System;

namespace MyOOP
{
    class Program
    {
        static void Main(string[] args)
        {           
            Point pStart = new Point(5,4,'*');
            Snake snake = new Snake(pStart, 5, Direction.DOWN);
            snake.Draw();

            Console.ReadKey();
        }
    }
}
