using System;

class Program
{
    static void Main()
    {
        // Solicita o salário fixo do vendedor
        Console.Write("Digite o salário fixo do vendedor: ");
        double salarioFixo = Convert.ToDouble(Console.ReadLine());

        // Solicita o valor total das vendas realizadas no mês
        Console.Write("Digite o valor total das vendas realizadas no mês: ");
        double totalVendas = Convert.ToDouble(Console.ReadLine());

        // Solicita o percentual que o vendedor ganha sobre as vendas
        Console.Write("Digite o percentual de comissão sobre as vendas (em %): ");
        double percentualComissao = Convert.ToDouble(Console.ReadLine());

        // Calcula a comissão do vendedor
        double comissao = totalVendas * (percentualComissao / 100);

        // Calcula o salário total do vendedor
        double salarioTotal = salarioFixo + comissao;

        // Exibe o salário total
        Console.WriteLine($"O salário total do vendedor é: R${salarioTotal:F2}");
    }
}
