using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest10._4
{
    class Point
    {
        string name;
        int x, y;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Name
        { get { return name; } }
        public Point() : this("", 0, 0) { }
        public Point(string name, int x, int y)
        {
            this.name = Console.ReadLine();
            Console.WriteLine("Введите координату X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y:");
            this.y = int.Parse(Console.ReadLine());
        }
    }
    class Figure
    {
        int number;
        Point[] points;
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void InitializeFigure()
        {
            Console.WriteLine("Введите количество вершин многоугольника");
            number = int.Parse(Console.ReadLine());
            if (number == 2)
            {
                Console.WriteLine("Многоугольник должен состоять минимум из 3-х вершин");
                Console.WriteLine("Программа будет завершена после нажатия любой клавиши");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else { Console.WriteLine($"Вы создали {number}-х угольник"); }

            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine("Введите букву которой обозначается {0} точка:", i + 1);
                points[i] = new Point();
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);
            Console.Write("Периметр {0}-х угольника равен: ", number);
            return perimeter;
        }
        public Figure(string name)
        {
            InitializeFigure();
        }
    }
    internal class Program
    {
        static void Main()
        {
            Figure multycorner = new Figure("многоугольник");
            Console.WriteLine(multycorner.CalculatePerimeter());
            Console.ReadKey();
        }
    }
}
