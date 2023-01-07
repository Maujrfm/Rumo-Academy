using System;
using System.Collections.Generic;


namespace Exercicios_1_4.Entities
{
    internal class LucroProduto
    {
        private string NomeProduto { get; set; }
        private int QuantidadeEstoque { get; set; }
        private double PrecoCompra { get; set; }
        private double PrecoVenda { get; set; }
        private double ValorLucro { get; set; }
        private double TotalLucroEstoque { get; set; }
        public LucroProduto()
        {

        }
        public LucroProduto(string nomeProduto, int quantidadeEstoque, double precoCompra, double precoVenda, double valorLucro, double totalLucroEstoque)
        {
            NomeProduto = nomeProduto;
            QuantidadeEstoque = quantidadeEstoque;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            ValorLucro = valorLucro;
            TotalLucroEstoque = totalLucroEstoque;
        }

        public void Executar()
        {
            var estoque = CapturarDados();
            MostrarProdutoLucro(estoque); 

        }

        private List<LucroProduto> CapturarDados()
        {
            var estoque = new List<LucroProduto>();
            string nomeProduto;
            int quantidadeEstoque;
            double precoCompra, precoVenda,valorLucro,totalLucroEstoque;
            char confirmaAdição = 's';
            while (confirmaAdição != 'n')
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do produto: ");
                nomeProduto=Console.ReadLine();
                Console.WriteLine("Digite a quantidade em estoque: ");
                quantidadeEstoque=int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de compra do produto: ");
                precoCompra=double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de venda do produto: ");
                precoVenda=double.Parse(Console.ReadLine());
                valorLucro=CalculaLucro(precoCompra, precoVenda);
                totalLucroEstoque = ValorTotalLucroEstoque(quantidadeEstoque, valorLucro);
                estoque.Add(new LucroProduto(nomeProduto, quantidadeEstoque, precoCompra, precoVenda,valorLucro,totalLucroEstoque));
                Console.WriteLine("Deseja adicionar outro produto? (s/n)");
                confirmaAdição = char.Parse(Console.ReadLine());
            }
            return estoque;
        }
        private double CalculaLucro(double  valorCompra,double valorVenda)
        {
            return valorVenda - valorCompra;
        }
        private double ValorTotalLucroEstoque(int quantidadeEstoque,double valorLucro)
        {
            return valorLucro * quantidadeEstoque;
        }
        private void MostrarProdutoLucro(List<LucroProduto> estoque)
        {
            Console.Clear();
            double lucroTotalLoja = 0;
            foreach (LucroProduto produto in estoque)
            {
                Console.WriteLine("O Produto "+produto.NomeProduto+" teve um lucro individual de R$"+
                    produto.ValorLucro+" e um lucro total de R$"+produto.TotalLucroEstoque);
                lucroTotalLoja += produto.TotalLucroEstoque;
            }
            Console.WriteLine("O lucro total da loja foi de R$"+lucroTotalLoja);
        }
    }
}
