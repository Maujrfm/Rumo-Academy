using Convercao_Portugol_CSharp.Entities;
namespace Convercao_Portugol_CSharp
{
    internal class Fluxo
    {
        public void Executar()
        {
            Cabecalho();
            Console.WriteLine();
            Console.WriteLine();
            Menu();

        }
        private void Cabecalho()
        {
            Console.WriteLine("#############################");
            Console.WriteLine("#####Computador de Bordo#####");
            Console.WriteLine("#############################");

        }
        private void Menu()
        {
            Console.WriteLine("Por favor escolha uma opção:");
            Console.WriteLine("1- Calculo de consumo (km/l)");
            Console.WriteLine("2- Calculo de autonomia disponivel (km a ser rodado)");
            Console.WriteLine("3- Fechar o programa");
            int menuSeletor = int.Parse(Console.ReadLine());
            while (menuSeletor != 0)
            {
                if (menuSeletor == 1)
                {
                    Console.Clear();
                    exercicioUm();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 2)
                {

                    Console.Clear();
                    exercicioDois();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 3)
                {

                    menuSeletor = 0;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Por favor digite apenas numeros do menu");
                    Console.WriteLine("Por favor escolha uma opção:");
                    Console.WriteLine("1- Calculo de consumo (km/l)");
                    Console.WriteLine("2- Calculo de autonomia disponivel (km a ser rodado)");
                    Console.WriteLine("3- Fechar o programa");
                    menuSeletor = int.Parse(Console.ReadLine());
                }
            }
        }
        private void exercicioUm()
        {
            new CalculoConsumo().CapturaDados();

        }
        private void exercicioDois()
        {
            new AutonomiaDisponivel().CapturaDados();
        }

    }
}
