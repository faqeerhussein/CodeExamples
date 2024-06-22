
using System;

public class DelegateDemo
{
    //Step 1: Delegate Declaration
    public delegate int MathOperation(int a, int b);

    public static void Main()
    {
        //Step 2-Option-1: Delegate instance creation using a named method
        MathOperation addOperation = Add;
        //Step 3: Invoking the delegate
        int addResult = addOperation(5, 3); // Invoking delegate
        Console.WriteLine($"Add(5,3) Result: {addResult}");

        //Step 2-Option-2: Delegate instance creation using anonymous method
        MathOperation multiplyOperation = delegate (int a, int b)
        {
            return a * b;
        };
        //Step 3: Invoking the delegate
        int multiplyResult = multiplyOperation(5, 3);
        Console.WriteLine($"Multiply(5, 3) Result: {multiplyResult}");

        //Step 2-Option-3: Delegate instance creation using lambda expres-sion
        MathOperation subtractOperation = (a, b) => a - b;
        //Step 3: Invoking the delegate
        int subtractResult = subtractOperation(5, 3);
        Console.WriteLine($"Subtract(5,3) Result: {subtractResult}");
    }

    // Named method used in Step 2
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

