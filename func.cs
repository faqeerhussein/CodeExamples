
using System;

class FuncDemo
{
    static void Main()
    {
        // 1. Func using a named method
        Func<int, int, int> add = Add;
        Console.WriteLine($"Add using named method: {add(3, 4)}");

        // 2. Func using an anonymous method
        Func<int, int, int> multiply = delegate (int a, int b)
        {
            return a * b;
        };
        Console.WriteLine($"Multiply using anonymous method: {multiply(3, 4)}");

        // 3. Func using a lambda expression
        Func<int, int, int> subtract = (a, b) => a - b;
        Console.WriteLine($"Subtract using lambda expression: {subtract(7, 4)}");

        // 4. Func with no parameters, only return via lambda expression
        Func<string> sayHello = () => "Hello, world!";
        Console.WriteLine($"no parameter: {sayHello()}");

        // 5. Func with multiple types of parameters using lambda expression
        Func<int, string, string> concat = (number, text) => text + number;
        Console.WriteLine($"multiple parameter types: {concat(10, "Number is ")}");
    }

    // Named method
    static int Add(int a, int b)
    {
        return a + b;
    }
}
