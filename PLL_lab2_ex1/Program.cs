namespace PLL_lab2_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 original = new Class1(3,4,5);

            Class1 copy = new Class1(original);

            Console.WriteLine(copy.ToString());

            int minLastDigit = original.min_p();
            Console.WriteLine($"Минимальная из последних цифр: {minLastDigit}");


            //дочерний
            Console.WriteLine();
            Triangle triangle = new Triangle(original.x, original.y, original.z);
            Console.WriteLine(triangle);
        }
    }
}