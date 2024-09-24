using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Witaj w aplikacji kalkulator!");


                    Console.WriteLine("Wpisz pierwszą liczbę");
                    var number1 = GetInput();

                    Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+', '-', '*', '/'");
                    var operation = Console.ReadLine();

                    Console.WriteLine("Wpisz drugą liczbę");
                    var number2 = GetInput();

                    var result = Calculate(number1, number2, operation);

                    Console.WriteLine($"Wynik Twojego działania to: {Math.Round(result, 2)}.");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }            
        }
        private static double GetInput()
        {
            if (!double.TryParse(Console.ReadLine(), out double input))
                throw new Exception("Podana wartość nie jest liczbą");
            return input;
        }
        private static double Calculate(double number1, double number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    throw new Exception("Wybrałeś złą operację");
            }
        }
    }
}