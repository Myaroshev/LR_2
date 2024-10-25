using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLL_lab_2
{
    internal class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;

        //конструктор инициализации
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //подсчёт
        public double[] Calculate()
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                //нет корней
                return Array.Empty<double>();
            }
            else if (discriminant == 0)
            {
                //1 корень
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                //2 корня
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { root1, root2 };
            }
        }


        public override string ToString()
        {
            return $"Уравнение: {a}x^2 + {b}x + {c} = 0";
        }



        //перегрузка инкремента
        public static QuadraticEquation operator ++(QuadraticEquation equation)
        {
            return new QuadraticEquation(equation.a + 1, equation.b + 1, equation.c + 1);
        }

        //перегрузка декремента
        public static QuadraticEquation operator --(QuadraticEquation equation)
        {
            return new QuadraticEquation(equation.a - 1, equation.b - 1, equation.c - 1);
        }




        //неявное приведение(дискриминант)
        public static implicit operator double(QuadraticEquation equation)
        {
            return equation.b * equation.b - 4 * equation.a * equation.c;//дискриминат
        }

        //явное приведение(проверка на существование корней)
        public static explicit operator bool(QuadraticEquation equation)
        {
            double discriminant = equation.b * equation.b - 4 * equation.a * equation.c;
            return discriminant >= 0;//если корни существуют - true
        }



        //перегрузка оператора равенства
        public static bool operator ==(QuadraticEquation equation1, QuadraticEquation equation2)
        {
            return equation1.a == equation2.a && equation1.b == equation2.b && equation1.c == equation2.c;
        }

        //перегрузка оператора неравенства (!=)
        public static bool operator !=(QuadraticEquation equation1, QuadraticEquation equation2)
        {
            return !(equation1 == equation2);
        }
    }
}
