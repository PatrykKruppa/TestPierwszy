using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c;

        Console.WriteLine("Podaj pierwszy bok trójkąta");
        a = (int)inputValue();
        Console.WriteLine("Podaj drugi bok trójkąta");
        b = (int)inputValue();
        Console.WriteLine("Podaj trzeci bok trójkąta");
        c = (int)inputValue();
        if (a == b && a == c && b == c)
        {
            Console.WriteLine("Boki trójkąta są równe i mogą utworzyć trójkąt równoboczny");
        }
        else
        {
            Console.WriteLine("Boki trójkąta nie są równe i nie mogą utworzyć trójkąt równoboczny");
        }
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
