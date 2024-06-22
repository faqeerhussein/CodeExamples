
using System;
using System.Linq;

class VowelCounterMinimizedClass
{
    // Program's Entry-Point method
    static void Main()
    {
        // Source-code contains minimized number of statements/lines
        // making use of built-in delegate Func,
        // and Lambda expression instead of named methods
        Console.Write("Enter Any Text: ");
        Func<string, string> VowelCounterFuncDelegate = txt => txt.ToLower().Aggregate("", (ac, c) => ac += "aeiou".Contains(c) ? c : "", ac => $"'{txt}' contains {ac.Length} Vowels ({ac}).");
        Console.WriteLine(VowelCounterFuncDelegate(Console.ReadLine()));
    }
}