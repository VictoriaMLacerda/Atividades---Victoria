using System;

class Program
{
    static void Main()
    {
        // Questão 3: Conversão de Fahrenheit para Celsius
        Console.Write("Informe a temperatura em Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) / 1.8;
        Console.WriteLine("Temperatura em Celsius: " + celsius);
    }
}
