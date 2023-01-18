namespace Conversor_Real
{
    internal class Classificador_de_Idade
    {
        private int IdadeNarrador { get; set; }

        public void Executar()
        {
            CapturarIdade();
            ClassificarNarrador();
        }

        private void CapturarIdade()
        {
            Console.WriteLine("Digite a idade do Narrador: ");
            IdadeNarrador = int.Parse(Console.ReadLine());
        }

        private void ClassificarNarrador()
        {

            if (IdadeNarrador >= 5 || IdadeNarrador <= 7)
            {
                Console.WriteLine("Seu narrador está classificado como: Infantil A");
            }
            else if (IdadeNarrador >= 8 || IdadeNarrador <= 10)
            {
                Console.WriteLine("Seu narrador está classificado como: Infantil B");
            }
            else if (IdadeNarrador >= 11 || IdadeNarrador <= 13)
            {
                Console.WriteLine("Seu narrador está classificado como: Juvenil A");
            }
            else if (IdadeNarrador >= 14 || IdadeNarrador <= 17)
            {
                Console.WriteLine("Seu narrador está classificado como: Juvenil B");
            }
            else if (IdadeNarrador >= 18 || IdadeNarrador <= 25)
            {
                Console.WriteLine("Seu narrador está classificado como: Senior");
            }
            else
            {
                Console.WriteLine("Infelizmente a idade informada está fora dos padrões classificaveis.");
            }
        }


    }
}
