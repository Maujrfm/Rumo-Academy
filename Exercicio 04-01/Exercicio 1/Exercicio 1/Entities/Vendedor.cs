namespace Exercicio_1.Entities
{
    internal class Vendedor
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double TotalVendas { get; set; }

        public Vendedor()
        {

        }
        public Vendedor(string nome, double salario, double totalVendas)
        {
            Nome = nome;
            Salario = salario;
            TotalVendas = totalVendas;
        }

        public double CalculaSalario(double totalVendas)
        {
            double comissao = totalVendas * 0.15;
            double salarioFinal = Salario+comissao;
            return salarioFinal;
        }
        
    }
}
