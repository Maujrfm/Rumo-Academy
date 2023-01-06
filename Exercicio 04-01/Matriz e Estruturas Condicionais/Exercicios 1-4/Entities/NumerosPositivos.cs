namespace Exercicios_1_4.Entities
{
    internal class NumerosPositivos
    {
        public void CapturaDados()
        {
           double[] numerosVetor = new double[15];
            for(int i = 0; i < 15; i++)
            {
                int j = i + 1;
                Console.Write("Digite o "+j+"º numero: ");
                numerosVetor[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("Numeros positivos digitados: ");
            for(int i = 0; i < 15; i++)
            {
                if(numerosVetor[i] > 0)
                {
                    Console.Write(numerosVetor[i]+", ");
                }
            }
        }

    }
}
