using System.IO;

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

            #region Conversões

            int notaAluno = 10;

            //conversao implicita
            double notaAlunoDouble = notaAluno;
            //conversao explicita
            int numeroDoubleComoInt = (int)notaAlunoDouble;

            //conversao utilizando Convert
            string notaString = "10";

            int notaConvert = Convert.ToInt32(notaString);

            //conversão utilizado Parse
            int notaParse = int.Parse(notaString);

            if (int.TryParse(notaString, out int notaTryParse))
            {

            }
            else 
            {
                Console.WriteLine("Número em formato inválido.");
            }
            #endregion
            Console.Read();
        }
    }
}