using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Real
{
    internal class Fluxo
    {
        public void Executar()
        {
            MenuExercicios();
        }
        private void MenuExercicios()
        {
            Console.WriteLine("################################################");
            Console.WriteLine("###########PROGRAMA PROVA 17/01/2023############");
            Console.WriteLine("################################################");
            Console.WriteLine("Olá escolha qual dos programas deseja Executar:");
            Console.WriteLine("1 - Calculadora de Moeda. ");
            Console.WriteLine("2 - Classificador de Idade. ");
            Console.WriteLine("3 - Calculo Salario Professor.");
            Console.WriteLine("4 - Calculo Valor a ser pago de energia.");
            Console.WriteLine("5 - Fechar o programa.");
            int menuSeletor = int.Parse(Console.ReadLine());
            while (menuSeletor != 0)
            {
                if (menuSeletor == 1)
                {
                    Console.Clear(); 
                    new Calculadora_moeda().Executar();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 2)
                {

                    Console.Clear();
                    new Classificador_de_Idade().Executar();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 3)
                {

                    Console.Clear();
                    new CalculadoraSalarioProfessor().Executar();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 4)
                {

                    Console.Clear();
                    new CalculadoraConsumoEletrico().Executar();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 5)
                {

                    menuSeletor = 0;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("################################################");
                    Console.WriteLine("###########PROGRAMA PROVA 17/01/2023############");
                    Console.WriteLine("################################################");
                    Console.WriteLine("Olá escolha qual dos programas deseja Executar:");
                    Console.WriteLine("1 - Calculadora de Moeda. ");
                    Console.WriteLine("2 - Classificador de Idade. ");
                    Console.WriteLine("3 - Calculo Salario Professor.");
                    Console.WriteLine("4 - Calculo Valor a ser pago de energia.");
                    Console.WriteLine("5 - Fechar o programa.");
                    menuSeletor = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
