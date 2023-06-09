using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Jeśli chcesz otrzymać wynik dodawania podaj 1, jeśli wynik odejmowania podaj 2, jeśli wynik mnożenia podaj 3, a jeśli wynik dzielenia podaj 4");
        int a, b, c;

        a = (int)inputValue();
        Console.WriteLine("Podaj liczbe");
        b = (int)inputValue();
        Console.WriteLine("Podaj liczbe");
        c = (int)inputValue();
        double dodawanie;
        double odejmowanie;
        double mnożenie;
        double dzielenie;

        if (a == 1)
        {
            dodawanie = b + c;
            Console.WriteLine("Wynik dodawania to: " + dodawanie);
        }
        if (a == 2)
        {
            odejmowanie = b - c;
            Console.WriteLine("Wynik odejmowania to: " + odejmowanie);
        }
        if (a == 3)
        {
            mnożenie = b * c;
            Console.WriteLine("Wynik mnożenia to: " + mnożenie);
        }
        if (a == 4)
        {
            if (c == 0)
            {
                while (c == 0)
                {
                    Console.WriteLine("Wynik dzielenia to: " + b + "/0");
                }
            }
            dzielenie = (double)b / c;
            Console.WriteLine("Wynik dzielenia to: " + dzielenie);
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
