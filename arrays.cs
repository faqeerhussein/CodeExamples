using System;

public class ArrayDemo
{
    public static void Main(string[] args)
    {
        // 1. Declare and initialize implicitly sized array
        int[] numbers1 = new int[] { 1, 2, 3 };
        Console.Write("Numbers Array (implicitly sized): ");
        Console.WriteLine($"{numbers1[0]}, {numbers1[1]}, {numbers1[2]}");

        // 2. Declare with size, initialize later
        int[] numbers2 = new int[3];
        numbers2[0] = 10;
        numbers2[1] = 20;
        numbers2[2] = 30;
        Console.Write("Numbers Array (initialized later): ");
        Console.WriteLine($"{numbers2[0]}, {numbers2[1]}, {numbers2[2]}");

        // 3. Declare and initialize with size
        string[] fruits = new string[3] { "Apple", "Banana", "Orange" };
        Console.Write("Fruits Array: ");
        Console.WriteLine($"{fruits[0]}, {fruits[1]}, {fruits[2]}");


        // 4. Declare with size only
        double[] decimals = new double[3];
        Console.Write("Decimals Array (default values): ");
        Console.WriteLine($"{decimals[0]}, {decimals[1]}, {decimals[2]}");
    }
}