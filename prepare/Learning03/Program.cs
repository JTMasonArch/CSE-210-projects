using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Random random = new Random();

        for(int i = 0; i < 20; i++)
        {
            int newTop = random.Next(1,10);
            fraction.SetTopNumber(newTop);

            int newBottom = random.Next(1,10);
            fraction.SetBottomNumber(newBottom);

            string stringForm = fraction.GetFractionString();
            double decimalForm = fraction.GetDecimalValue();

            Console.WriteLine($"Fraction {i + 1}: String: {stringForm} Decimal {decimalForm}");
        }
    }
}