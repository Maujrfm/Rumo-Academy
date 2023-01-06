using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_1_4.Entities
{
    internal class MediaNotas
    {
        int tamanhoTurma = 0;
        double somaNotas = 0;
        public void CapturaDados()
        {
            Console.WriteLine("Digite a Quantidade de notas que será lançada: ");
            tamanhoTurma = int.Parse(Console.ReadLine());
            for(int i = 1; i <= tamanhoTurma; i++)
            {
                Console.Write("Digite a "+i+"º nota: ");
                somaNotas +=double.Parse(Console.ReadLine());
            }
            Console.WriteLine(MediaTurma());
        }
        public string MediaTurma()
        {
            double media = (somaNotas / tamanhoTurma);
            return "A media da turma de "+tamanhoTurma+" alunos, foi: "+media.ToString("F2");
        }
    }
}
