using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_ex1_PL
{
    internal class Class1
    {
        protected int x;
        protected int y;
        protected int z;

        //свойства
        public int X
        {
            get { return x;}
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        //конструктор инициализации
        public Class1(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //конструктор копирования
        public Class1(Class1 temp)
        {
            this.x = temp.x;
            this.y = temp.y;
            this.z = temp.z;
        }

        public int min_p()
        {
            int digit_1 = Math.Abs(x) % 10;
            int digit_2 = Math.Abs(y) % 10;
            int digit_3 = Math.Abs(z) % 10;

            int min_digit = digit_1;

            if (digit_2 < min_digit)
            {
                min_digit = digit_2;
            }
            else if (digit_3 < min_digit)
            {
                min_digit = digit_3;
            }

            return min_digit;
        }

        //перегрузка
        public override string ToString()
        {
            return $"x: {x}\ny: {y}\nz: {z}";
        }
    }
}
