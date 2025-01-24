using System;

class Variables
{
    public static void PrintMessage()
    {
        string message = "I'm Rmnprosf, and I'm learning C#!";
        char Grade = 'A';

        Console.WriteLine(Grade + " " + message);
    }

    public static void PrintNumber()
    {
        int number = 10;
        double DoubleNumber = 10.5;
        float FloatNumber = 10.5f;

        float test = 10;


        Console.WriteLine("The number is " + number + number.GetType());
        Console.WriteLine("The double number is " + DoubleNumber + DoubleNumber.GetType());
        Console.WriteLine("The float number is " + FloatNumber + FloatNumber.GetType());
        Console.WriteLine("The test number is " + test + "" + test.GetType());
    }

    public static void PrintBool()
    {
        bool isTrue = true;
        bool isFalse = false;

        Console.WriteLine("The value of isTrue is " + isTrue + " " + isTrue.GetType());
        Console.WriteLine("The value of isFalse is " + isFalse + " " + isFalse.GetType());
    }

    public static void PrintChar()
    {
        char character = 'A';
        char character2 = 'B';

        Console.WriteLine("The value of character is " + character);
        Console.WriteLine("The value of character2 is " + character2);
    }

    public static void PrintString()
    {
        string message = "Hello, World!";
        string message2 = "Hello, C#!";

        Console.WriteLine("The value of message is " + message);
        Console.WriteLine("The value of message2 is " + message2);
    }

    public static void PrintDecimal()
    {
        decimal decimalNumber = 10.5m;

        Console.WriteLine("The value of decimalNumber is " + decimalNumber);
    }
}