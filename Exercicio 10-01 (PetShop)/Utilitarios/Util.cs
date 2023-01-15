
namespace Utilitarios
{
    public static class Util
    {
        public static bool ValidarNomeCliente(string? texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return false;
            }
            if (texto.Length < 3 || texto.Length > 80)
            {
                return false;
            }

            return true;
        }
        public static bool ValidiadorCPF(string? cpfDigitado)
        {
            if (string.IsNullOrEmpty(cpfDigitado))
            {
                return false;
            }
            int[] multiplicadorCpf1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadorCpf2 = new int[10] {11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string auxCpf,digito;
            int soma = 0, resto;
            
            auxCpf = cpfDigitado.Substring(0, 9);

            for(int i = 0; i < 9; i++)
            {
                soma += int.Parse(auxCpf[i].ToString() )* multiplicadorCpf1[i];
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito = resto.ToString();

            auxCpf = auxCpf + digito;

            soma = 0;

            for(int i = 0; i < 10; i++)
            {
                soma += int.Parse(auxCpf[i].ToString()) * multiplicadorCpf2[i];
            }
            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            auxCpf = auxCpf + resto;

            if(cpfDigitado== auxCpf)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidadorData(string? dataDigitada)
        {
            if (string.IsNullOrEmpty(dataDigitada))
            {
                return false;
            }
            if (dataDigitada.Length < 8)
            {
                return false;
            }
            dataDigitada = dataDigitada.Substring(0, 2) + "/" + dataDigitada.Substring(2, 2) + "/" + dataDigitada.Substring(4, 4);
            DateTime dataFormatada = DateTime.Parse(dataDigitada);
            DateTime dataAtual = DateTime.Now;
            var calculoAnos = (dataFormatada.Subtract(dataAtual));
            double totalAnos = (calculoAnos.TotalDays) / 365;
            if (totalAnos >= 16.0 || totalAnos <= 120.0)
            {
                return true;
            }           
            else
            {
                return false;
            }
        }

    }
}