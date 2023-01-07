namespace Convercao_Portugol_CSharp.Entities
{
    internal class AutonomiaDisponivel
    {
        private double ConsumoMedio { get; set; }
        private double LitrosAbastecidos { get; set; }

        public void CapturaDados()
        {
            Console.WriteLine("Digite o Consumo medio do veiculo: ");
            ConsumoMedio = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite  quantos Litros foram abastecidos: ");
            LitrosAbastecidos = double.Parse(Console.ReadLine());
            DistanciaPercorrer();
        }
        private void DistanciaPercorrer()
        {
            Console.WriteLine("Este veiculo pode percorrer: "+
                (ConsumoMedio*LitrosAbastecidos).ToString("F2") + "Km");
        }
    }
}
