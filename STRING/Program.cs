using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário uma string
        Console.WriteLine("Digite uma string para invertê-la:");
        string input = "Olá, meu nome é Lucas Martins";

        // Inicializa a string invertida
        char[] caracteres = input.ToCharArray();
        int inicio = 0;
        int fim = caracteres.Length - 1;

        // Realiza a inversão dos caracteres
        while (inicio < fim)
        {
            // Troca os caracteres
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            // Atualiza os índices
            inicio++;
            fim--;
        }

        // Converte o array de caracteres de volta para string
        string invertida = new string(caracteres);

        // Exibe a string invertida
        Console.WriteLine($"String invertida: {invertida}");
    }
}