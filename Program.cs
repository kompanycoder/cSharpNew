using System;

namespace myApp
{
    class Program
    {
        static void executeNumbers()
        {
            Console.WriteLine("Begining of program execution");
            int a = 15;
            int b = 20;
            int c = a + b;
            Console.WriteLine("The Sum is : " + c);
            c = b - a;
            Console.WriteLine("The Subtraction difference is : " + c);
            c = a * b;
            Console.WriteLine("The Multiplication is : " + c);
            c = a / b;
            Console.WriteLine("The Division result is : " + c);
            Console.WriteLine("End of Program execution");
        }

        static void Area()
        {
            double PI = Math.PI;
            double r = Math.Floor(Math.Abs(7.0));
            double area = PI * r * r;
            Console.WriteLine("The Area is : " + area);
        }
        static void Main(string[] args)
        {
            executeNumbers();
            Area();
        }
    }
}
