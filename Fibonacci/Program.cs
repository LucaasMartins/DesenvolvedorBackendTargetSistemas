using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita um número ao usuário
        Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int numero))
        {
            Console.WriteLine("Por favor, insira um número válido.");
            return;
        }

        // Variáveis para calcular a sequência de Fibonacci
        int a = 0, b = 1, temp;

        // Verifica se o número pertence à sequência
        bool pertence = false;
        while (a <= numero)
        {
            if (a == numero)
            {
                pertence = true;
                break;
            }
            temp = a;
            a = b;
            b = temp + b;
        }

        if (pertence)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }
}