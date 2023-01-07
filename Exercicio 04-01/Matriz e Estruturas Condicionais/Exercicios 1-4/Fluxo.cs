using Exercicios_1_4.Entities;
namespace Exercicios_1_4
{
    internal class Fluxo
    {
        public void Executar()
        {
            Menu();
        }
        private void Menu()
        {
            Console.WriteLine("################################################");
            Console.WriteLine("########EXERCICIOS MATRIZ E CONDICIONAIS########");
            Console.WriteLine("################################################");
            Console.WriteLine("Bem vindo ao Menu dos Exercicios");
            Console.WriteLine("Escolha um das opções abaixo: ");
            Console.WriteLine("1 - Exercicio de calculo de media da turma. ");
            Console.WriteLine("2 - Exercicio de calculo de numeros positivos. ");
            Console.WriteLine("3 - Exercicio para  mostrar o mais velho ");
            Console.WriteLine("4 - Exercicio de calculo de lucro do produto ");
            Console.WriteLine("5 - Fechar o programa");
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
                    
                    Console.Clear();
                    exercicioTres();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 4)
                {
                   
                    Console.Clear();
                    exercicioQuatro();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 5)
                {
                    
                    menuSeletor = 0;
                }
                else
                {
                    Console.WriteLine("Por favor digite apenas numeros do menu");
                    Console.Clear();
                    Console.WriteLine("1 - Exercicio de calculo de media da turma. ");
                    Console.WriteLine("2 - Exercicio de calculo de numeros positivos. ");
                    Console.WriteLine("3 - Exercicio para  mostrar o mais velho ");
                    Console.WriteLine("4 - Exercicio de calculo de lucro do produto ");
                    Console.WriteLine("5 - Fechar o programa");
                    menuSeletor = int.Parse(Console.ReadLine());
                }
            }
        }

        private void exercicioUm()
        {
            MediaNotas mediaNotas = new MediaNotas();
            mediaNotas.CapturaDados();
            
        }
        private void exercicioDois()
        {
            NumerosPositivos numerosPositivos = new NumerosPositivos();
            numerosPositivos.CapturaDados();
        }
        private void exercicioTres()
        {
            MostrarMaisVelho mostrarMaisVelho = new MostrarMaisVelho();
            mostrarMaisVelho.Executar();
           
        }
        private void exercicioQuatro()
        {
            LucroProduto lucroProduto = new LucroProduto();
            lucroProduto.Executar();
        }



    }
}
