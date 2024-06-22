
using System;
using System.Collections.Generic;

class RangeOperatorDemo
{
    static void Main(string[] args)
    {
        string[] namesArray = ["Alice", "Bob", "Charlie", "David", "Eve"];
        List<string> namesList = ["Alice", "Bob", "Charlie", "David", "Eve"];
        //Range Operator also works for string
        //because under-the-hood string is a char array
        string nameString = "Alice";

        // Extract all elements from the beginning (inclusive) to the end
        string[] allNamesArray = namesArray[..];  // Same as names
        List<string> allNamesList = namesList[..];  // Same as names
        string entireNameString = nameString[..]; // Same as name

        // Extract elements from index 1 (inclusive) to 3 (exclusive)
        string[] subArray = namesArray[1..3];  // ["Bob", "Charlie"]
        List<string> subList = namesList[1..3];  // ["Bob", "Charlie"]
        string subString = nameString[1..3];  // "li"

        // Extract elements from the second element from the end to the end
        string[] lastTwoArray = namesArray[^2..];  // ["David", "Eve"]
        List<string> lastTwoList = namesList[^2..];  // ["David", "Eve"]
        string lastTwoInString = nameString[^2..];  // "ce"

        // Extract elements from the first element to the index 2 (exclusive)
        string[] firstTwoArray = namesArray[..2];  // ["Alice", "Bob"]
        List<string> firstTwoList = namesList[..2];  // ["Alice", "Bob"]
        string firstTwoInString = nameString[..2];  // "Al"

        // Result of 'Range Operator' with Array
        Console.WriteLine($"Array-All names: {string.Join(", ", allNamesArray)}");
        Console.WriteLine($"Array-Sub-array: {string.Join(", ", subArray)}");
        Console.WriteLine($"Array-Last two: {string.Join(", ", lastTwoArray)}");
        Console.WriteLine($"Array-First two: {string.Join(", ", firstTwoArray)}");

        // Result of 'Range Operator' with List
        Console.WriteLine($"List-All names: {string.Join(", ", allNamesList)}");
        Console.WriteLine($"List-Sub-list: {string.Join(", ", subList)}");
        Console.WriteLine($"List-Last two: {string.Join(", ", lastTwoList)}");
        Console.WriteLine($"List-First two: {string.Join(", ", firstTwoList)}");

        // Result of 'Range Operator' with string
        Console.WriteLine($"string-entire name: {entireNameString}");
        Console.WriteLine($"string-Sub-string: {subString}");
        Console.WriteLine($"string-Last two chars: {lastTwoInString}");
        Console.WriteLine($"string-First two chars: {firstTwoInString}");
    }
}
