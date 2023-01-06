
namespace Exercicio_1
{
    /*Exercicio 1
     1. Faça um programa que leia o nome de um vendedor, o seu salário fixo e 
    o total de vendas efetuadas por ele no mês (em dinheiro). 
    Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, 
    informar o seu nome, o salário fixo e salário final do mês.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Fluxo fluxo = new Fluxo();
            fluxo.CapturaDados();
            Console.WriteLine(fluxo); 
            
        }
    }
}