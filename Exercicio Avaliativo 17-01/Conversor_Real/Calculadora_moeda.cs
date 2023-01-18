namespace Conversor_Real
{
    internal class Calculadora_moeda
    {
        private double ValorReal { get; set; }
        private double ValorDolar = 5.10;
        private double ValorEuro = 5.50;
        private double ValorPesoArgentino = 0.28;
        private double ValorBaht = 0.18;
        private double ValorTotal = 0.0;
        public void Executar()
        {
            MenuConversao();
        }
        
        private void MenuConversao()
        {
            Console.WriteLine("################################################");
            Console.WriteLine("###########CALCULADORA CONVERSOR REAL###########");
            Console.WriteLine("################################################");
            Console.WriteLine("Bem vindo a Calculadora de converção de Real.");
            Console.WriteLine("Escolha um das opções abaixo: ");
            Console.WriteLine("1 - Converter para Dolar. ");
            Console.WriteLine("2 - Converter para Euro. ");
            Console.WriteLine("3 - Converter para Peso Argentino.");
            Console.WriteLine("4 - Converter para Baht Tailandes.");
            Console.WriteLine("5 - Fechar o programa.");
            int menuSeletor = int.Parse(Console.ReadLine());
            while (menuSeletor != 0)
            {
                if (menuSeletor == 1)
                {
                    Console.Clear();
                    CalculadorDolar();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 2)
                {

                    Console.Clear();
                    CalculadorEuro();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 3)
                {

                    Console.Clear();
                    CalculadorPesoArgentino();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 4)
                {

                    Console.Clear();
                    CalculadorBaht();
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
                    Console.WriteLine("################################################");
                    Console.WriteLine("###########CALCULADORA CONVERSOR REAL###########");
                    Console.WriteLine("################################################");
                    Console.WriteLine("Bem vindo a Calculadora de converção de Real.");
                    Console.WriteLine("Escolha um das opções abaixo: ");
                    Console.WriteLine("1 - Converter para Dolar. ");
                    Console.WriteLine("2 - Converter para Euro. ");
                    Console.WriteLine("3 - Converter para Peso Argentino.");
                    Console.WriteLine("4 - Converter para Baht Tailandes.");
                    Console.WriteLine("5 - Fechar o programa.");
                    menuSeletor = int.Parse(Console.ReadLine());
                }
            }
        }

        private void CapturaValores()
        {
            Console.WriteLine("Insira a Quantidade de reais que deseja converter: ");
            ValorReal = double.Parse(Console.ReadLine());

        }
       
        private void CalculadorDolar()
        {
            CapturaValores();
            ValorTotal= ValorReal * ValorDolar;
            Console.WriteLine("Valor total apos Conversao para dolar U$" +ValorTotal.ToString("F2"));
        }
        private void CalculadorEuro()
        {
            CapturaValores();
            ValorTotal = ValorReal * ValorEuro;
            Console.WriteLine("Valor total apos Conversao para Euro $" + ValorTotal.ToString("F2"));
        }
        private void CalculadorPesoArgentino()
        {
            CapturaValores();
            ValorTotal = ValorReal * ValorPesoArgentino;
            Console.WriteLine("Valor total apos Conversao para Peso Argentino $" + ValorTotal.ToString("F2"));
        }
        private void CalculadorBaht()
        {
            CapturaValores();
            ValorTotal = ValorReal * ValorBaht;
            Console.WriteLine("Valor total apos Conversao para Baht Tailandes $" + ValorTotal.ToString("F2"));
        }

    }
}
