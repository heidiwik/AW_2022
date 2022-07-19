using System;

namespace StructExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // struct
            Point a = new Point(5, 25);
            Point b = a;

            b.x = 33;

            Console.WriteLine("Values from struct:");
            Console.WriteLine(a.x);
            Console.WriteLine(b.x);
            Console.WriteLine("\n\n");



            // classes
            PointC aO = new PointC(999, 1222);
            PointC bO = aO;

            bO.x = 33;

            Console.WriteLine("Values from object:");
            Console.WriteLine(aO.x);
            Console.WriteLine(bO.x);
        }
    }

    struct Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class PointC
    {
        public int x, y;

        public PointC(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    enum Season
    {
        Autumn = 0,
        Winter = 1, 
        Spring = 2,
        Summer = 4,
    }
}
