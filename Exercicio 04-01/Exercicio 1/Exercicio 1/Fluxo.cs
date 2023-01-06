using Exercicio_1.Entities;
using System;

namespace Exercicio_1
{
    internal class Fluxo
    {
        Vendedor vendedor = new Vendedor();

        public void CapturaDados()
        {
            Console.WriteLine("Digite o nome do Vendedor: ");
            vendedor.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Salario Fixo do Vendedor: ");
            vendedor.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Total de Vendas Efetuadas: ");
            vendedor.TotalVendas = double.Parse(Console.ReadLine());
            
        }

        public override string ToString()
        {
            return "O salario do vendedor: "+vendedor.Nome+" é de R$"+vendedor.Salario
                +" e com as comissoes ficou: R$"+vendedor.CalculaSalario(vendedor.Salario);
        }


    }
}
