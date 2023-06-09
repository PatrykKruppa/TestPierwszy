using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, a, r;

        Console.WriteLine("Podaj x");
        x = inputValue();
        Console.WriteLine("Podaj y");
        y = inputValue();
        Console.WriteLine("Podaj r");
        r = inputValue();
        double odlegloscodscrodka;

        if (x * x + y * y <= r * r)
        {
            Console.WriteLine("Wpisane wartosci znajduja sie w obrebie kola");
        }
        else
        {
            Console.WriteLine("Wpisane wartosci nie znajduja sie w obrebie kola");
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
