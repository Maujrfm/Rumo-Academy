    namespace Exercicios_1_4.Entities
{
    internal class MediaNotas
    {
        private int TamanhoTurma { get; set; }
        private double SomaNotas { get; set; }
               
        public void CapturaDados()
        {
            Console.WriteLine("Digite a Quantidade de notas que será lançada: ");
            TamanhoTurma = int.Parse(Console.ReadLine());
            for(int i = 1; i <= TamanhoTurma; i++)
            {
                Console.Write("Digite a "+i+"º nota: ");
                SomaNotas += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(MediaTurma());
        }
        private string MediaTurma()
        {
            double media = (SomaNotas / TamanhoTurma);
            return "A media da turma de "+ TamanhoTurma + " alunos, foi: "+media.ToString("F2");
        }
    }
}
