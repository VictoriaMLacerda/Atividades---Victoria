using System;

class Program
{
    static void Main()
    {
        // Conversão de Fahrenheit para Celsius
        Console.Write("Informe a temperatura em Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) / 1.8;
        Console.WriteLine("Temperatura em Celsius: " + celsius);
    }
}
