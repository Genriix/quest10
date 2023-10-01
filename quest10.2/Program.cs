using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest10._2
{
    class Rectangle
    {
        double side1;
        double side2;
        double area;
        double perimeter;

        public Rectangle(double side1, double side2)
        {
            Console.WriteLine("Пользовательский конструктор");
            this.side1 = side1;
            this.side2 = side2;
            AreaCalculator(side1, side2);
            PerimeterCalculator(side1, side2);
        }

        public double Area { get { return area; } }
        public double Perimeter { get { return perimeter; } }

        public double AreaCalculator(double side1, double side2) { return area = side1 * side2; }

        public double PerimeterCalculator(double side1, double side2) {  return perimeter = 2 * (side1 + side2); }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины двух сторон прямоугольника С ЗАПЯТОЙ!!!!!");
            Rectangle rectagle = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine($"S прямоугольника: {rectagle.Area}");
            Console.WriteLine($"P прямоугольника: {rectagle.Perimeter}");

            Console.ReadKey();
        }
    }
}
