
namespace Exercicios_1_4.Entities
{
    internal class MostrarMaisVelho
    {
        private string Nome { get; set; }
        private int Idade { get; set; }

       

        public void Executar()
        {
            var pessoa = CapturaDados();
            CalcularMaisVelho(pessoa);
            
        }
       
        private MostrarMaisVelho[] CapturaDados()
        {
            var pessoa = new MostrarMaisVelho[10];
           for(int i = 0; i < 10; i++)
            {
                int j = i + 1;
                Console.WriteLine("Digite o nome da "+j+"º pessoa: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a idade da "+j+"º pessoa: ");
                int idade = int.Parse(Console.ReadLine());
                pessoa[i] = new MostrarMaisVelho { Nome = nome, Idade = idade };
                Console.Clear();
            }
            return pessoa;
        }

        private void CalcularMaisVelho(MostrarMaisVelho[] pessoa)
        {
            string nomeMaisVelho = pessoa[0].Nome;
            int idadeMaisVelho = pessoa[0].Idade;
            for (int i = 1; i < 10; i++)
            {
                if (idadeMaisVelho < pessoa[i].Idade)
                {
                    idadeMaisVelho = pessoa[i].Idade;
                    nomeMaisVelho=pessoa[i].Nome;
                }
            }
            Console.WriteLine("O mais Velho é: "+nomeMaisVelho+" e tem: "+idadeMaisVelho);
        }
       
    }
}
