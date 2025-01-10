using System;
using System.IO;
using System.Linq;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        // Caminho do arquivo JSON contendo os dados de faturamento
        string caminhoArquivo = "faturamento.json";

        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine("Arquivo de faturamento não encontrado.");
            return;
        }

        // Lê o conteúdo do arquivo JSON
        string json = File.ReadAllText(caminhoArquivo);

        // Desserializa os dados do JSON para um array
        decimal[] faturamentoDiario = JsonSerializer.Deserialize<decimal[]>(json);

        // Filtra os dias com faturamento (ignora zeros, que representam dias sem faturamento)
        var diasComFaturamento = faturamentoDiario.Where(valor => valor > 0).ToArray();

        // Calcula o menor e maior valor de faturamento
        decimal menorValor = diasComFaturamento.Min();
        decimal maiorValor = diasComFaturamento.Max();

        // Calcula a média de faturamento mensal
        decimal mediaMensal = diasComFaturamento.Average();

        // Conta os dias em que o faturamento foi superior à média mensal
        int diasAcimaDaMedia = diasComFaturamento.Count(valor => valor > mediaMensal);

        // Exibe os resultados
        Console.WriteLine($"Menor valor de faturamento diário: R$ {menorValor:F2}");
        Console.WriteLine($"Maior valor de faturamento diário: R$ {maiorValor:F2}");
        Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
    }
}