namespace Conversor_Real
{
    internal class CalculadoraConsumoEletrico
    {
        private double ValorKiloWatt { get; set; }
        private int PotenciaWatt { get; set; }
        private double QuantidadeHoras { get; set; }
        private int QuantidadeDias { get; set; }

        private double ValorPagarEnergia { get; set; }

        public void Executar()
        {
            CapturarDados();
        }

        private void CapturarDados()
        {
            Console.WriteLine("Por favor informe o valor do Kilo Watt: ");
            ValorKiloWatt=double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a potencia do seu Eletrodomestico? ");
            PotenciaWatt=int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas por dias ele fica ligado? ");
            QuantidadeHoras = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dias ele fica ligado este tempo?");
            QuantidadeDias=int.Parse(Console.ReadLine());
            CalculaValorConsumo();
        }

        private void CalculaValorConsumo()
        {
            ValorPagarEnergia = ((PotenciaWatt * (QuantidadeHoras * QuantidadeDias)) / 1000) * ValorKiloWatt;
            Console.WriteLine("O valor da sua conta é de : R$"+ValorPagarEnergia.ToString("F2"));
        }



    }
}
