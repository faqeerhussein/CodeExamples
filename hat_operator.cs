
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbersArray = [1, 2, 3, 4, 5];
        List<int> numbersList = [10, 20, 30, 40, 50];
        string text = "Faqeer Hussain";

        // Access Array elements from the end using the ^ operator
        int lastElementArray = numbersArray[^1];     // 5
        int secondLastArray = numbersArray[^2];    // 4
        int thirdLastArray = numbersArray[^3];     // 3

        // Access List elements from the end using the ^ operator
        int lastElementList = numbersList[^1];     // 50
        int secondLastList = numbersList[^2];    // 40
        int thirdLastList = numbersList[^3];     // 30

        // Access string chars from the end using the ^ operator
        char lastCharString = text[^1];     // n
        char secondLastString = text[^2]; // i
        char thirdLastString = text[^3];  // a

        //Access result in Array
        Console.WriteLine($"Array-Last: {lastElementArray}");
        Console.WriteLine($"Array-Second last: {secondLastArray}");
        Console.WriteLine($"Array-Third last: {thirdLastArray}");

        //Access result in List
        Console.WriteLine($"List-Last: {lastElementList}");
        Console.WriteLine($"List-Second last: {secondLastList}");
        Console.WriteLine($"List-Third last: {thirdLastList}");

        //Access result in string
        Console.WriteLine($"string-Last char: {lastCharString}");
        Console.WriteLine($"string-Second last char: {secondLastString}");
        Console.WriteLine($"string-Third last char: {thirdLastString}");
    }
}
