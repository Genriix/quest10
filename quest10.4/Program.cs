using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest10._4
{
    class Point
    {
        string name; // Приватная переменная name
        int x, y; // Приватные переменный x и y
        public int X { get { return x; } } // Делаем из приватной переменных публичную
        public int Y { get { return y; } } // Делаем из приватной переменных публичную
        public string Name { get { return name; } } // Публичная переменная Name
        public Point() : this("", 0, 0) { } // Создаём пустое поле Point()
        public Point(string name, int x, int y) // Заполняем это поле информацей точки
        {
            this.name = Console.ReadLine(); // Имя точки
            Console.WriteLine("Введите координату X:");
            this.x = int.Parse(Console.ReadLine()); // Координата точки по х
            Console.WriteLine("Введите координату Y:");
            this.y = int.Parse(Console.ReadLine()); // Координата точки по у
        }
    }
    class Figure
    {
        int number; // Приватная переменная для порядкового номера точки
        Point[] points; //Создаём множество из точек
        string name; // Приватная переменная name
        public string Name // Публичное поле Name, куда записываем приватную переменную
        {
            get { return name; }
            set { name = value; }
        }
        public void InitializeFigure()
        {
            Console.WriteLine("Введите количество вершин многоугольника");
            number = int.Parse(Console.ReadLine()); // Записывем количесво точек

                            /// Проводим защиту от дурака \\\
            if (number == 2)
            {
                Console.WriteLine("Многоугольник должен состоять минимум из 3-х вершин");
                Console.WriteLine("Программа будет завершена после нажатия любой клавиши");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else { Console.WriteLine($"Вы создали фигуру с {number} вершинами"); }

            points = new Point[number]; // Указываем размер множества
            for (int i = 0; i < points.Length; i++) // Проходим по всем точкам
            {
                Console.WriteLine($"Введите букву которой обозначается {i + 1} точка:" );
                points[i] = new Point(); // Записываем в множество новую точку
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2)); // Находим две точки с помощью координат
        }
        public string CalculatePerimeter()
        {
            double perimeter = 0; // Создаём переменную периметра 
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]); // Находим по 2 точки
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]); // Находим первую и последнюю точку 
            Console.Write($"Периметр фигуры равен равен: {perimeter}");
            return null;
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
