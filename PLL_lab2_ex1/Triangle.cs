using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLL_lab2_ex1
{
    internal class Triangle : Class1
    {
        public Triangle(int x, int y, int z) : base(x, y, z) { }
        //поля - длины сторон треугольника

        //периметр
        public int Perimeter()
        {
            return x + y + z;
        }

        //площадь
        public double Area()
        {
            double semi_perimeter = Perimeter() / 2;

            double area = Math.Sqrt(semi_perimeter * ((semi_perimeter - x) * (semi_perimeter - y) * (semi_perimeter - z)));

            return area;
        }

        //существование
        public bool isExists()
        {
            return (x + y > z && x + z > y && y + z > x);
        }

        //перегрузка
        public override string ToString()
        {
            return base.ToString() + $"\nПлощадь: {Area()}\nПериметр: {Perimeter()}\nСуществует: {isExists()}";
        }
    }
}
