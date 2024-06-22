using System;

class ActionDemo
{
    static void Main(string[] args)
    {
        // 1. Using a named method
        Action namedMethodAction = NamedMethod;
        namedMethodAction();

        // 2. Using an anonymous method
        Action anonymousMethodAction = delegate
        {
            Console.WriteLine("Anonymous Method Action");
        };
        anonymousMethodAction();

        // 3. Using a lambda expression
        Action lambdaAction = () => Console.WriteLine("Lambda Action");
        lambdaAction();

        // 4. Using Action with parameters
        Action<int, string> actionWithParams = (num, text) => 
        Console.WriteLine($"Number: {num}, Text: {text}");
        actionWithParams(10, "Hello");
    }

    // named method used for first Action instance on line 10
    static void NamedMethod()
    {
        Console.WriteLine("Named Method Action");
    }
}
