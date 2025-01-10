using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração das variáveis
        int INDICE = 13, SOMA = 0, K = 0;

        // Estrutura de repetição
        while (K < INDICE)
        {
            K = K + 1; // Incrementa K
            SOMA = SOMA + K; // Adiciona K à SOMA
        }

        // Imprime o valor final de SOMA
        Console.WriteLine("O valor da variável SOMA é: " + SOMA);
    }
}