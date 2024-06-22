
using System;

class SendingMethodToMethodDemo
{
    static void Main()
    {
        // Sending Named methods to ReceiverMethod()
        ReceiverMethod(SquareMethod, "Named");
        ReceiverMethod(IsEvenMethod, "Named");
        ReceiverMethod(PrintMessageMethod, "Named");

        // Sending Anonymous methods to ReceiverMethod
        ReceiverMethod(delegate (int x) { return x * x; }, "Anonymous");
        ReceiverMethod(delegate (int x) { return x % 2 == 0; }, "Anonymous");
        ReceiverMethod(delegate (string s) { Console.Write(s); }, "Anonymous");

        // Sending methods using Lambda expression
        ReceiverMethod(x => x * x, "Lambda");
        ReceiverMethod(x => x % 2 == 0, "Lambda");
        ReceiverMethod(s => Console.Write(s), "Lambda");
    }

    // Named method for demonstration of sending method via Func
    static int SquareMethod(int x)
    {
        return x * x;
    }

    // Named method for demostration of sending method via Predicate
    static bool IsEvenMethod(int x)
    {
        return x % 2 == 0;
    }

    // Named method for demonstration of sending method via Action
    static void PrintMessageMethod(string msg)
    {
        Console.Write(msg);
    }

    // Overloaded Method to execute a Func<int, int> type method
    static void ReceiverMethod(Func<int, int> parcelMethod, string parcelType)
    {
        Console.Write("Received method using " + parcelType);
        Console.Write(parcelType[0]=='L'? " expression" : " method");
        Console.Write("-Func: Square of 5 = ");
        int result = parcelMethod(5);
        Console.WriteLine(result);
    }

    // Overloaded Method to execute a Predicate<int> type method
    static void ReceiverMethod(Predicate<int> parcelMethod, string parcelType)
    {
        Console.Write("Received method using " + parcelType);
        Console.Write(parcelType[0]=='L'? " expression" : " method");
        Console.Write("-Predicate: Is 4 Even = ");
        bool result = parcelMethod(4);
        Console.WriteLine(result);
    }

    // Overloaded Method to execute an Action<string> type method
    static void ReceiverMethod(Action<string> parcelMethod, string parcelType)
    {
        parcelMethod("Received method using " + parcelType);
        Console.Write(parcelType[0]=='L'? " expression" : " method");
        Console.WriteLine("-Action");
    }
}
