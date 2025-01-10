using System;

class Program
{
    static void Main(string[] args)
    {
        // Valores de faturamento por estado
        decimal sp = 67836.43m;
        decimal rj = 36678.66m;
        decimal mg = 29229.88m;
        decimal es = 27165.48m;
        decimal outros = 19849.53m;

        // Calcula o faturamento total
        decimal faturamentoTotal = sp + rj + mg + es + outros;

        // Calcula os percentuais de representação
        decimal percentualSP = (sp / faturamentoTotal) * 100;
        decimal percentualRJ = (rj / faturamentoTotal) * 100;
        decimal percentualMG = (mg / faturamentoTotal) * 100;
        decimal percentualES = (es / faturamentoTotal) * 100;
        decimal percentualOutros = (outros / faturamentoTotal) * 100;

        // Exibe os resultados
        Console.WriteLine("Percentual de representação por estado:");
        Console.WriteLine($"SP: {percentualSP:F2}%");
        Console.WriteLine($"RJ: {percentualRJ:F2}%");
        Console.WriteLine($"MG: {percentualMG:F2}%");
        Console.WriteLine($"ES: {percentualES:F2}%");
        Console.WriteLine($"Outros: {percentualOutros:F2}%");
    }
}