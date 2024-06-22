
using System;
using System.Linq;

class VowelCounterClass
{
    // Step 1: Declare a delegate
    delegate string VowelsCounterDelegate(string text);

    // Step 2: Declare a class field to store user's text
    // so that all methods can access its value
    static string text = "";

    // Program's Entry-Point method
    static void Main()
    {
        // Step-3: instruct user to input any text
        Console.Write("Enter Any Text: ");

        // Step-4: store the user's supplied text in field
        text = Console.ReadLine();

        // convert user text to lowercase abc
        // so that we just have to compare with lowercase vowels 
        string loweredTxt = text.ToLower();

        // Step-5: Instanstiate the Delegate
        // using the named method 'TextProcessorMethod'
        VowelsCounterDelegate vowelsDelegateMethod = TextProcessorMethod;

        // Step-6: execute the delegate like a normal method
        // by sending user's lowered text as its parameter 
        string delegateResult = vowelsDelegateMethod(loweredTxt);

        // Final Last Step: display the result 
        Console.WriteLine(delegateResult);
    }

    // named method used to assign value to delegate instance
    static string TextProcessorMethod(string str)
    {
        // Read Code Explanation or Docs for Aggregate's documentation
        return str.Aggregate("", VowelExtractorMethod, VowelsInfoMethod);
    }

    // used as first parameter of Aggregate method
    // this method will be called by Aggregate method for every character in text
    static string VowelExtractorMethod(string str, char ch)
    {
        // this will just accumulate (keep adding/concatenating)
        // the vowels's in user's text inside the accumulator
        str += "aeiou".Contains(ch) ? ch : "";
        return str;
    }

    // used as second parameter of Aggregate method
    // this method will be called by Aggregate method
    // only once after all iterations of first parameter method
    // the supplied string parameter will represent the 
    // single value of Aggregate method,
    // containing info about vowels in user text
    // number of vowels alongwith the actual vowels present in text 
    static string VowelsInfoMethod(string str)
    {
        return $"'{text}' contains {str.Length} Vowels ({str}).";
    }
}

