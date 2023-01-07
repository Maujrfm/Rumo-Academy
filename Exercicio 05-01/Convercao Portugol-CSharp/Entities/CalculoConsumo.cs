namespace Convercao_Portugol_CSharp.Entities
{
    internal class CalculoConsumo
    {
        private double KmRodado { get; set; }
        private double LitrosAbastecidos { get; set; }

        public void CapturaDados()
        {
            Console.WriteLine("Digite quantos KM foram rodados: ");
            KmRodado=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite  quantos Litros foram abastecidos: ");
            LitrosAbastecidos=double.Parse(Console.ReadLine());
            ConsumoMedio();
        }
        private void ConsumoMedio()
        {
            Console.WriteLine("Este veiculo fez: "+(KmRodado/LitrosAbastecidos).ToString("F2")+"Km/L");
        }
    }
}
