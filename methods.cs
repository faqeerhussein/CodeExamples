
using System;

namespace MethodDemo
{
    class Program
    {

        // Main method - entry point of the program
        static void Main(string[] args)
        {
            // Calling a method without parameters
            Greet();

            // Calling a method with parameters
            int a = 5;
            int b = 10;
            int sum = Add(a, b);
            Console.WriteLine($"Sum of {a} and {b} is: {sum}");

            // Calling an overloaded method
            double x = 5.5;
            double y = 10.3;
            double sumDouble = Add(x, y);
            Console.WriteLine($"Sum of {x} and {y} is: {sumDouble}");

            // Calling a method with a return value
            double radius = 3.5;
            double area = CalculateCircleArea(radius);
            Console.WriteLine($"Area of circle with radius {radius} is: {area}");
        }

        // Method without parameters and return type
        static void Greet()
        {
            Console.WriteLine("Hello, welcome to the method demonstration!");
        }

        // Method with parameters and return type
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Overloaded method - same name but different parameters
        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Method with a return value
        static double CalculateCircleArea(double radius)
        {
            const double Pi = 3.14159;
            return Pi * radius * radius;
        }
    }
}

