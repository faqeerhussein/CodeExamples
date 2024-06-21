using System;
class DataTypeDemo
{
    static void Main(string[] args)
    {           
        // Integral types
        sbyte smallSignedByte = -127;
        byte smallUnsignedByte = 255;
        short smallSignedInt = -32768;
        ushort smallUnsignedInt = 65535;
        int wholeNumber = 100;
        uint wholeUnsignedNumber = 4294967295;
        long bigSignedInt = -9223372036854775808;
        ulong bigUnsignedInt = 18446744073709551615;
        char singleCharacter = 'A';

        // Floating-point types
        float singlePrecisionFloat = 3.14159f; // f suffix for float
        double doublePrecisionFloat = 3.141592653589793;

        // Decimal type
        // m suffix for decimal        
        decimal highPrecisionDecimal = 1.234567890123456789m;

        // Boolean type
        bool isTrue = true;
        bool isFalse = false;

        // String type
        string text = "This is a string";

        // Print variable values and data type limits using string interpolation
        Console.Write($"sbyte: {smallSignedByte} ");
        Console.WriteLine($"Min: {sbyte.MinValue}, Max: {sbyte.MaxValue}");
        Console.Write($"byte: {smallUnsignedByte} ");
        Console.WriteLine($"Min: {byte.MinValue}, Max: {byte.MaxValue}");
        Console.Write($"short: {smallSignedInt} ");
        Console.WriteLine($"Min: {short.MinValue}, Max: {short.MaxValue}");
        Console.Write($"ushort: {smallUnsignedInt} ");
        Console.WriteLine($"Min: {ushort.MinValue},Max: {ushort.MaxValue}");
        Console.Write($"int: {wholeNumber} ");
        Console.WriteLine($"Min: {int.MinValue}, Max: {int.MaxValue})");
        Console.Write($"uint: {wholeUnsignedNumber} ");
        Console.WriteLine($"Min: {uint.MinValue}, Max: {uint.MaxValue}");
        Console.Write($"long: {bigSignedInt} ");
        Console.WriteLine($"Min: {long.MinValue}, Max: {long.MaxValue}");
        Console.Write($"ulong: {bigUnsignedInt} ");
        Console.WriteLine($"Min: {ulong.MinValue}, Max: {ulong.MaxValue}");
        Console.Write($"float: {singlePrecisionFloat} ");
        Console.WriteLine($"Min: {float.MinValue}, Max: {float.MaxValue}");
        Console.Write($"double: {doublePrecisionFloat} ");
        Console.WriteLine($"Min: {double.MinValue}, Max: {double.MaxValue}");
        Console.Write($"decimal: {highPrecisionDecimal} ");
        Console.WriteLine($"Min:{decimal.MinValue}, Max: {decimal.MaxValue}");
        Console.WriteLine($"char: {singleCharacter}");
        Console.WriteLine($"bool (true): {isTrue}");
        Console.WriteLine($"bool (false): {isFalse}");
        Console.WriteLine($"string: {text}");
    }
}