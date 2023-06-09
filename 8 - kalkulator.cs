using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c;

        Console.WriteLine("Podaj liczbe");
        a = (int)inputValue();
        Console.WriteLine("Podaj liczbe");
        b = (int)inputValue();
        Console.WriteLine("Podaj liczbe");
        c = (int)inputValue();
        int suma;

        suma = a + b + c;
        double srednia;

        srednia = (double)suma / 3;
        Console.WriteLine(srednia);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

