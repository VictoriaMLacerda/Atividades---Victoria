using System;

class Program
{
    static void Main()
    {
        // Solicita o total de veículos e o total de rodas no estacionamento
        Console.Write("Digite o total de veículos no estacionamento: ");
        int totalVeiculos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o total de rodas no estacionamento: ");
        int totalRodas = Convert.ToInt32(Console.ReadLine());

        // Verifica se a entrada é válida
        if (totalRodas < totalVeiculos * 2 || totalRodas > totalVeiculos * 4)
        {
            Console.WriteLine("Os valores informados são inválidos. Verifique os dados e tente novamente.");
        }
        else
        {
            // Calcula o número de carros e motos
            int carros = (totalRodas - totalVeiculos * 2) / 2;
            int motos = totalVeiculos - carros;

            // Exibe o resultado
            Console.WriteLine($"No estacionamento há {carros} carros e {motos} motos.");
        }
    }
}
