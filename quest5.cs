using System;

class Program
{
    static void Main()
    {
        // Cálculo do salário bruto
        Console.Write("Informe o número de horas trabalhadas no mês: ");
        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Informe o valor recebido por hora: ");
        double valorHora = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Informe o valor do salário família por filho: ");
        double salarioFamiliaPorFilho = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Informe o número de filhos com menos de 14 anos: ");
        int numeroFilhos = Convert.ToInt32(Console.ReadLine());
        
        double salarioBruto = (horasTrabalhadas * valorHora) + (salarioFamiliaPorFilho * numeroFilhos);
        
        Console.WriteLine("Salário bruto a ser recebido: " + salarioBruto);
    }
}
