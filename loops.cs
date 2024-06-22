using System;

public class LoopDemo
{
    public static void Main(string[] args)
    {
        /*
        for loop:
            use when you know the exact number of iterations
        */
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"for loop: Iteration #: {i}");
        }

        /*
        while loop: 
            use when you need to repeat
            a block of code as long as
            a condition is true
        */
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine($"while loop: Iteration #: {j}");
            j++;
        }

        /*
        do-while loop: 
            use when you need to execute a block of code
            at least once, then continue as long as
            a condition is true
        */
        int k = 1;
        do
        {
            Console.WriteLine($"do-while loop: Iteration #: {k}");
            k++;
        } while (k <= 5);

        /* 
        foreach loop: 
            use to iterate through all elements in a collection
            without managing an index variable
        */
        string[] names = { "John", "Mary", "Peter" };
        foreach (string name in names)
        {
            Console.WriteLine($"foreach loop: {name}");
        }
    }
}