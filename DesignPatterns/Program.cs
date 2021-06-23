namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var conexao = new ConnectionFactory().GetConnection();

            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM SomeTable";
        }
    }
}
