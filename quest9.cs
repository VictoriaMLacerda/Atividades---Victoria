using System;

class Program
{
    static void Main()
    {
        // Solicita o número de segundos ao usuário
        Console.Write("Digite o número de segundos: ");
        int totalSegundos = Convert.ToInt32(Console.ReadLine());

        // Calcula o número de horas
        int horas = totalSegundos / 3600;
        // Calcula o número de minutos restantes
        int minutos = (totalSegundos % 3600) / 60;
        // Calcula os segundos restantes
        int segundos = totalSegundos % 60;

        // Exibe o resultado
        Console.WriteLine($"{totalSegundos} segundos correspondem a {horas} horas, {minutos} minutos e {segundos} segundos.");
    }
}
