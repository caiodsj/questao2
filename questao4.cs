using System;

class Program {
    static void Main(string[] args) {
        double faturamentoSP = 67836.43;
        double faturamentoRJ = 36678.66;
        double faturamentoMG = 29229.88;
        double faturamentoES = 27165.48;
        double faturamentoOutros = 19849.53;

        double faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

        double percentualSP = (faturamentoSP / faturamentoTotal) * 100;
        double percentualRJ = (faturamentoRJ / faturamentoTotal) * 100;
        double percentualMG = (faturamentoMG / faturamentoTotal) * 100;
        double percentualES = (faturamentoES / faturamentoTotal) * 100;
        double percentualOutros = (faturamentoOutros / faturamentoTotal) * 100;

        Console.WriteLine("Percentual de representação de cada estado no faturamento mensal da distribuidora:");
        Console.WriteLine("SP: {0:F2}%", percentualSP);
        Console.WriteLine("RJ: {0:F2}%", percentualRJ);
        Console.WriteLine("MG: {0:F2}%", percentualMG);
        Console.WriteLine("ES: {0:F2}%", percentualES);
        Console.WriteLine("Outros: {0:F2}%", percentualOutros);
    }
}
