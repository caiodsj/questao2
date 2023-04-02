using Newtonsoft.Json;

class Program {
    static void Main(string[] args) {
        string json = File.ReadAllText("dados.json");
        Faturamento faturamento = JsonConvert.DeserializeObject<Faturamento>(json);

        double total = 0;
        int numDias = 0;
        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;

        foreach (double valor in faturamento.Valores) {
            if (valor == 0) {
                continue;
            }
            if (valor < menorFaturamento) {
                menorFaturamento = valor;
            }
            if (valor > maiorFaturamento) {
                maiorFaturamento = valor;
            }
            total += valor;
            numDias++;
        }

        double media = total / numDias;
        int numDiasAcimaDaMedia = 0;

        foreach (double valor in faturamento.Valores) {
            if (valor > media) {
                numDiasAcimaDaMedia++;
            }
        }

        Console.WriteLine("Menor faturamento: {0}", menorFaturamento);
        Console.WriteLine("Maior faturamento: {0}", maiorFaturamento);
        Console.WriteLine("Número de dias acima da média: {0}", numDiasAcimaDaMedia);
    }
}

class Faturamento {
    public double[] Valores { get; set; }
}
