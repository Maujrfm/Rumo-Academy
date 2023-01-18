namespace Conversor_Real
{
    internal class CalculadoraSalarioProfessor
    {
        private double NivelHoraTrabalho { get; set; }
        private double HorasTrabalhadas { get; set; }
        private double  TotalSalario { get; set; }


        public void Executar()
        {
            CapturarValores();
            SeletorNivel();
            CalculoValorSalario();
        }

        private void CapturarValores()
        {
            Console.WriteLine("Por favor informe quantas horas o professor trabalhou: ");
            HorasTrabalhadas = double.Parse(Console.ReadLine());
        }

        private void SeletorNivel()
        {
            int nivelHoraTrabalho = 0;
            while (nivelHoraTrabalho == 0)
            {
                Console.WriteLine("Por favor selecione o nivel da hora de trabalho: ");
                Console.WriteLine("1 - Nivel 1");
                Console.WriteLine("2 - Nivel 2");
                Console.WriteLine("3 - Nivel 3");
                nivelHoraTrabalho = int.Parse(Console.ReadLine());
                if (nivelHoraTrabalho == 1)
                {
                    NivelHoraTrabalho = 12.0;

                }
                else if (nivelHoraTrabalho == 2)
                {
                    NivelHoraTrabalho = 18.0;
                }
                else if (nivelHoraTrabalho == 3)
                {
                    NivelHoraTrabalho = 25.0;
                }
                else
                {
                    Console.WriteLine("Por favor digite um dos niveis abaixo");
                    NivelHoraTrabalho = 0;
                }
            }
        }

        private void CalculoValorSalario()
        {
            Console.WriteLine("Este professor receberá: R$"+(HorasTrabalhadas*NivelHoraTrabalho).ToString("F2"));
        }
    }
}
