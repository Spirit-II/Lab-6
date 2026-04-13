using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Lab_6_5_2
{
    /// Класс, представляющий точку на плоскости с координатами x и y.
    public class Point
    {
        /// Поле для хранения координаты x.
        private double x;

        /// Поле для хранения координаты y.
        private double y;

        /// Конструктор по умолчанию. Инициализирует точку в начале координат.
        public Point()
        {
            x = 0;
            y = 0;
        }

        /// Конструктор с параметрами. Инициализирует точку заданными координатами.
        /// <param name="x">Координата x.</param>
        /// <param name="y">Координата y.</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// Свойство для доступа к координате x.
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        /// Свойство для доступа к координате y.
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        /// Метод для вычисления расстояния до другой точки.
        /// <param name="other">Другая точка.</param>
        /// <returns>Расстояние между точками.</returns>
        public double DistanceTo(Point other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other), "Point cannot be null.");
            }
            return Math.Sqrt(Math.Pow(x - other.X, 2) + Math.Pow(y - other.Y, 2));
        }

        /// Перегрузка метода ToString() для вывода координат точки.
        /// <returns>Строка с координатами точки.</returns>
        public override string ToString()
        {
            return $"Point({X}, {Y})";
        }

        // Унарные операции
        public static Point operator ++(Point p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p), "Point cannot be null.");
            }
            p.X += 1;
            return p;
        }

        public static Point operator --(Point p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p), "Point cannot be null.");
            }
            p.X -= 1;
            return p;
        }

        // Операции приведения типа
        public static explicit operator int(Point p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p), "Point cannot be null.");
            }
            return (int)p.X;
        }

        public static implicit operator double(Point p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p), "Point cannot be null.");
            }
            return p.Y;
        }

        // Бинарные операции
        public static double operator +(Point p1, Point p2)
        {
            if (p1 == null || p2 == null)
            {
                throw new ArgumentNullException(p1 == null ? nameof(p1) : nameof(p2), "Point cannot be null.");
            }
            return p1.DistanceTo(p2);
        }

        public static Point operator +(Point p, int value)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p), "Point cannot be null.");
            }
            return new Point(p.X + value, p.Y);
        }

        public static Point operator +(int value, Point p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p), "Point cannot be null.");
            }
            return new Point(p.X + value, p.Y);
        }
    }
}
