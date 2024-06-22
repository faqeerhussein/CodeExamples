
using System;
using System.Collections.Generic;

public class ListExample
{
    public static void Main(string[] args)
    {
        // 1. Empty list declaration (implicitly typed with var)
        var emptyList = new List<string>();

        // 2. List declaration with initial elements (string interpolation)
        List<int> numbers = new List<int>() { 1, 2, { 3 * 2 } }; // Inline expression for efficiency

        // 3. Collection initializer syntax for conciseness (implicitly typed)
        var colors = new List<string> { "red", "green", "blue" };

        // 4. Access first element (string interpolation)
        Console.WriteLine($"First number: {numbers[0]}");

        // 5. Insert element at specific index
        numbers.Insert(1, numbers.Count); // Insert current list size after the first element

        // 6. Remove element by value
        numbers.Remove(2); // Remove the value 2
     
        // 7. Remove element by position
        numbers.RemoveAt(0); // Removes the element at index 0

        int[] arrayNumbers = new int[] { 7, 8, 9 };

        // 8. Add multiple elements by adding array in list
        numbers.AddRange(arrayNumbers);

        // 9. Check if element exists (string interpolation)
        Console.WriteLine($"Does the list contain 8? {numbers.Contains(8)}");

        // 10. Get the number of elements (string interpolation)
        Console.WriteLine($"Number of elements: {numbers.Count}");

        // 11. Print all elements using string interpolation and joining
        Console.WriteLine($"All elements: {string.Join(", ", numbers)}");

        // 12. Clear the list
        numbers.Clear();
        Console.WriteLine("List count after clearing: " + numbers.Count); // prints 0
    }
}
