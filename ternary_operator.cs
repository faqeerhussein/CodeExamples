using System;

class TernaryOperatorDemo
{
    static void Main()
    {
        // Basic usage of ternary operator
        int a = 10;
        int b = 20;
        string result = a > b ? "a is greater than b" : "a is not greater than b";
        Console.WriteLine(result);

        // Nested ternary operator
        int score = 85;
        string grade = score >= 90 ? "A" :
                       score >= 80 ? "B" :
                       score >= 70 ? "C" :
                       score >= 60 ? "D" : "F";
        Console.WriteLine($"The grade is: {grade}");

        // Ternary operator with different data types
        bool isAdult = true;
        string message = isAdult ? "You are an adult." : "You are not an adult.";
        Console.WriteLine(message);

        // Assigning the result to a variable
        int x = 5;
        int y = 10;
        int max = x > y ? x : y;
        Console.WriteLine($"The maximum value is: {max}");

        // Inline use in Console.WriteLine
        int age = 25;
        Console.WriteLine(age >= 18 ? "You can vote." : "You cannot vote.");

        // Method returning a value based on ternary operator
        Console.WriteLine(CheckEvenOdd(10)); // Output: Even
        Console.WriteLine(CheckEvenOdd(7));  // Output: Odd

        // Ternary operator used as method parameter
        bool isHappy = true;
        PrintMessage(isHappy ? "I'm happy!" : "I'm not happy.");

        // Ternary operator in a complex expression
        int c = 15;
        max = (a > b ? a : b) > c ? (a > b ? a : b) : c;
        Console.WriteLine($"The maximum value is: {max}");
    }

    // Method returning a value based on ternary operator
    static string CheckEvenOdd(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }

    
    static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}