using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace PetCenter.Entidades
{
    internal class Cliente
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private DateTime DataNascimento { get; set; }

        private List<Cliente> Clientes = new List<Cliente>();

        public Cliente()
        {

        }
        public Cliente(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public void Executar()
        {
            MenuCliente();

        }
        private void MenuCliente()
        {
            Console.WriteLine("################################################");
            Console.WriteLine("###############PETSHOP PETCENTER################");
            Console.WriteLine("################################################");
            Console.WriteLine("Bem vindo PETSHOP PETCENTER");
            Console.WriteLine("Escolha um das opções abaixo: ");
            Console.WriteLine("1 - Cadastrar Cliente. ");
            Console.WriteLine("2 - Mostrar Clientes cadastrados. ");
            Console.WriteLine("3 - Buscar Cliente por CPF.");
            Console.WriteLine("4 - Listar Aniversariantes.");
            Console.WriteLine("5 - Fechar o programa.");
            int menuSeletor = int.Parse(Console.ReadLine());
            while (menuSeletor != 0)
            {
                if (menuSeletor == 1)
                {
                    Console.Clear();
                    CadastrarCliente();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 2)
                {

                    Console.Clear();
                    MostrarClientesCadastrados();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 3)
                {

                    Console.Clear();
                    BuscarClientesPorCpf();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 4)
                {

                    Console.Clear();
                    ListarAniversariantesMes();
                    Console.ReadKey();
                    menuSeletor = 6;
                }
                else if (menuSeletor == 5)
                {

                    menuSeletor = 0;
                }
                else
                {
                    Console.WriteLine("Por favor digite apenas numeros do menu");
                    Console.Clear();
                    Console.WriteLine("Escolha um das opções abaixo: ");
                    Console.WriteLine("1 - Cadastrar Cliente. ");
                    Console.WriteLine("2 - Mostrar Clientes cadastrados. ");
                    Console.WriteLine("3 - Buscar Cliente por CPF.");
                    Console.WriteLine("4 - Listar Aniversariantes.");
                    Console.WriteLine("5 - Fechar o programa.");
                    menuSeletor = int.Parse(Console.ReadLine());
                }
            }
        }
        private void CadastrarCliente()
        {

            while (true)
            {
                Console.WriteLine("Por favor Insira o nome do Cliente: ");
                string nomeDigitado = Console.ReadLine().Trim();
                var nomeCorreto = Util.ValidarNomeCliente(nomeDigitado);
                if (!nomeCorreto)
                {
                    Console.WriteLine("O nome deve ter de 3-80 caracteres, digite novamente.");
                    continue;
                }
                Nome = nomeDigitado;
                break;
            }
            while (true)
            {
                Console.WriteLine("Por favor digite o CPF do Cliente:");
                string cpfDigitado = Console.ReadLine();
                cpfDigitado = cpfDigitado.Trim();
                cpfDigitado = cpfDigitado.Replace(".", "").Replace("-", "");
                var cpfValido = Util.ValidiadorCPF(cpfDigitado);
                if (!cpfValido)
                {
                    Console.WriteLine("Por favor, digite um CPF Valido.");
                    continue;
                }

                Cpf = cpfDigitado.Substring(0, 3) + "." + cpfDigitado.Substring(3, 3) + "."
                    + cpfDigitado.Substring(6, 3) + "-" + cpfDigitado.Substring(9, 2);
                break;
            }

            while (true)
            {
                Console.WriteLine("Por favor digite a Data de Nascimento do Cliente: ");
                string dataDigitada = Console.ReadLine();
                dataDigitada = dataDigitada.Trim();
                dataDigitada = dataDigitada.Replace("/", "").Replace("-", "");
                var dataValida = Util.ValidadorData(dataDigitada);
                if (!dataValida)
                {
                    Console.WriteLine("Por favor digite uma da Valida!");
                    Console.WriteLine("Lembrando que a pessoa não pode ter menos de 16 anos e mais de 120 anos.");
                    Console.WriteLine("Deve ser digitado no formato dd/MM/yyyy");
                    continue;
                }
                dataDigitada = dataDigitada.Substring(0, 2) + "/" + dataDigitada.Substring(2, 2) + "/" + dataDigitada.Substring(4, 4);
                DataNascimento = DateTime.Parse(dataDigitada);
                break;
            }
            Clientes.Add(new Cliente(Nome, Cpf, DataNascimento));

        }
        private void MostrarClientesCadastrados()
        {
            foreach (Cliente cliente in Clientes)
            {
                Console.WriteLine("Cliente Nome: " + cliente.Nome.ToUpper());
                Console.WriteLine("CPF: " + cliente.Cpf);
                Console.WriteLine("Data de Nascimento: " + cliente.DataNascimento.ToString("dd/MM/yyyy"));
            }
        }
        private void BuscarClientesPorCpf()
        {
            string cpfBusca;
            while (true)
            {
                Console.WriteLine("Por favor digite o CPF do Cliente:");
                string cpfDigitado = Console.ReadLine();
                cpfDigitado = cpfDigitado.Trim();
                cpfDigitado = cpfDigitado.Replace(".", "").Replace("-", "");
                var cpfValido = Util.ValidiadorCPF(cpfDigitado);
                if (!cpfValido)
                {
                    Console.WriteLine("Por favor, digite um CPF Valido.");
                    continue;
                }

                cpfBusca = cpfDigitado.Substring(0, 3) + "." + cpfDigitado.Substring(3, 3) + "."
                    + cpfDigitado.Substring(6, 3) + "-" + cpfDigitado.Substring(9, 2);
                break;
            }
            var clienteExiste = Clientes.Where(x => x.Cpf == cpfBusca).ToList();
            foreach (var cliente in clienteExiste)
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("CPF: " + cliente.Cpf);
                Console.WriteLine("Data Nascimento: " + cliente.DataNascimento);
            }
            if (clienteExiste.Count() == 0)
            {
                Console.WriteLine("Cliente não encontrado.");
            }
            else
            {
                Console.WriteLine("Deseja realizar alguma alteração? (s/n)");
                char menuAlteraCliente = char.Parse(Console.ReadLine());
                if (menuAlteraCliente == 's')
                {
                    Clientes.RemoveAll(x => x.Cpf == cpfBusca);
                    string nome, cpf;
                    DateTime dataNascimento;
                    while (true)
                    {
                        Console.WriteLine("Por favor Insira o nome do Cliente: ");
                        nome = Console.ReadLine();
                        var nomeCorreto = Util.ValidarNomeCliente(nome);
                        if (!nomeCorreto)
                        {
                            Console.WriteLine("O nome deve ter de 3-80 caracteres, digite novamente.");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {
                        Console.WriteLine("Por favor digite o CPF do Cliente:");
                        string cpfDigitado = Console.ReadLine();
                        cpfDigitado = cpfDigitado.Trim();
                        cpfDigitado = cpfDigitado.Replace(".", "").Replace("-", "");
                        var cpfValido = Util.ValidiadorCPF(cpfDigitado);
                        if (!cpfValido)
                        {
                            Console.WriteLine("Por favor, digite um CPF Valido.");
                            continue;
                        }

                        cpf = cpfDigitado.Substring(0, 3) + "." + cpfDigitado.Substring(3, 3) + "."
                            + cpfDigitado.Substring(6, 3) + "-" + cpfDigitado.Substring(9, 2);
                        break;
                    }
                    while (true)
                    {
                        Console.WriteLine("Por favor digite a Data de Nascimento do Cliente: ");
                        string dataDigitada = Console.ReadLine();
                        dataDigitada = dataDigitada.Trim();
                        dataDigitada = dataDigitada.Replace("/", "").Replace("-", "");
                        var dataValida = Util.ValidadorData(dataDigitada);
                        if (!dataValida)
                        {
                            Console.WriteLine("Por favor digite uma da Valida, lembrando que a pessoa não pode ter menos de 16 anos e mais de 120 anos.");
                            continue;
                        }
                        dataDigitada = dataDigitada.Substring(0, 2) + "/" + dataDigitada.Substring(2, 2) + "/" + dataDigitada.Substring(4, 4);
                        dataNascimento = DateTime.Parse(dataDigitada);
                        break;
                    }
                    Clientes.Add(new Cliente(nome, cpf, dataNascimento));
                }
            }
        }
        private void ListarAniversariantesMes()
        {
            DateTime mesAtual = DateTime.Now;
            var clienteExiste = Clientes.Where(x => x.DataNascimento.Month == mesAtual.Month).ToList();
            foreach (var cliente in clienteExiste)
            {
                Console.WriteLine("Nome: " + cliente.Nome.ToUpper());
                Console.WriteLine("CPF: " + cliente.Cpf);
                Console.WriteLine("Data Nascimento: " + cliente.DataNascimento.ToString("dd/MM/yyyy"));
            }
            if (clienteExiste.Count() == 0)
            {
                Console.WriteLine("Não Existem aniversariantes este mes.");
            }
        }

    }
}

