using System;

class Program
{
    static void Main()
    {
        // Questão 2: Preço com acréscimo de 10%
        Console.Write("Informe o valor do produto: ");
        double preco = Convert.ToDouble(Console.ReadLine());
        double novoPreco = preco * 1.10;
        Console.WriteLine("Novo valor do produto: " + novoPreco);
    }
}
