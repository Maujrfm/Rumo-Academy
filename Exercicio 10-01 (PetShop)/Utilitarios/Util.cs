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
    }
}