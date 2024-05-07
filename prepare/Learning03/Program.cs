using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6,7);

        fraction1.SetTop(3);
        fraction1.SetBottom(5);
        
        fraction2.SetTop(4);
        fraction2.SetBottom(8);

        fraction3.SetTop(7);
        fraction3.SetBottom(9);

        fraction1.GetTop();
        fraction2.GetTop();
        fraction3.GetTop();

        fraction1.GetBottom();
        fraction2.GetBottom();
        fraction3.GetBottom();

        string fracDisplay = fraction1.GetFractionString();
        double decDisplay = fraction1.GetDecimal();
        
        Console.WriteLine($"{fracDisplay}");
        Console.WriteLine($"{decDisplay}");
    }
}