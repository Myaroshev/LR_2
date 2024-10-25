namespace lab_2_PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation equation = new QuadraticEquation(-1, 3, 1);
            QuadraticEquation equation2 = new QuadraticEquation(0, 3, 1);

            Console.WriteLine(equation.ToString());

            double[] roots = equation.Calculate();

            if (roots.Length == 0)
            {
                Console.WriteLine("Нет действительных корней");
            }
            else
            {
                Console.WriteLine("Корни:");
                foreach (int root in roots)
                {
                    Console.WriteLine(root);
                }
            }



            Console.WriteLine();
            //унарные операции
            equation++;
            Console.WriteLine($"После инкремента: {equation}");

            equation--;
            Console.WriteLine($"После декремента: {equation}");


            Console.WriteLine();
            //операции приведения типа
            double discriminant = equation;
            Console.WriteLine($"Дискриминант: {discriminant}");
            Console.WriteLine($"Существуют ли корни: {(bool)equation}");


            Console.WriteLine();
            //бинарные операции
            Console.WriteLine($"equation1 == equation2: {equation == equation2}");
            Console.WriteLine($"equation1 != equation2: {equation != equation2}");
        }
    }
}