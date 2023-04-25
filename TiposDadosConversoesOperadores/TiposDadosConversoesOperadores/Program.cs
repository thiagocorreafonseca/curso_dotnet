namespace TiposDadosConversoesOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tipos de Dados
            int numeroInt = 10;
            int MaiorNumeroInt = int.MaxValue;
            int MenorNumeroInt = int.MinValue;

            long numeroLong = 123123123123;
            long maiorNumeroLong = long.MaxValue;
            long menorNumeroLong = long.MinValue;

            decimal numeroDecimal = 10.52m;

            double numeroDouble = 12.3;
            double menorNumeroDouble = double.MinValue;

            bool verdadeiro = true;
            bool falso = false;

            var numero = 10;

            string Nome = "Thiago Fonseca";
            char Letra = 'T';

            DateTime entradaEmpresa = new DateTime(2023, 01, 01);
            TimeSpan quantoTempoDeEmpresa = DateTime.Now - entradaEmpresa;
            #endregion

            Console.Read();
        }
    }
}