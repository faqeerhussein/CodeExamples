
using System;
using System.Collections.Generic;

class PredicateDemo
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Using a named method
        Predicate<int> isEvenPredicate = IsEven;
        List<int> evenNumbers = numbers.FindAll(isEvenPredicate);
        Console.Write("Even numbers (Predicate using named method): ");
        Console.WriteLine(string.Join(", ", evenNumbers));

        // Using an anonymous method
        Predicate<int> isOddPredicate = delegate (int x)
        {
            return x % 2 != 0;
        };
        List<int> oddNumbers = numbers.FindAll(isOddPredicate);
        Console.Write("Odd numbers (Predicate using anonymous method): ");
        Console.WriteLine(string.Join(", ", oddNumbers));

        // Using a lambda expression
        Predicate<int> greaterThan5Predicate = x => x > 5;
        List<int> greaterThanFiveNumbers = numbers.FindAll(greaterThan5Predicate);
        Console.Write("Greater than 5 (Predicate using lambda expression): ");
        Console.WriteLine(string.Join(", ", greaterThanFiveNumbers));
    }

    // named method
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
