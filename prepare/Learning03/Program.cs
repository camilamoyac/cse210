using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction defaultFraction = new Fraction();
        Fraction wholeNumber = new Fraction(5);
        Fraction fraction = new Fraction(3,4);
        Fraction fraction1 = new Fraction(10,3);
        
        Console.WriteLine(defaultFraction.getFractionString());
        Console.WriteLine(defaultFraction.getDecimalValue());

        Console.WriteLine(wholeNumber.getFractionString());
        Console.WriteLine(wholeNumber.getDecimalValue());

        Console.WriteLine(fraction.getFractionString());
        Console.WriteLine(fraction.getDecimalValue());

        Console.WriteLine(fraction1.getFractionString());
        Console.WriteLine(fraction1.getDecimalValue());
    }
}