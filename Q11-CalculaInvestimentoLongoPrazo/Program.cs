using System;
using System.Globalization;
using System.Threading;

namespace Q11_CalculaInvestimentoLongoPrazo
{
    /// <summary>
    ///  Classe principal do projeto
    /// </summary>
    class Program
    {
        /// <summary>
        ///  Metodo principal do projeto
        /// </summary>
        /// <param name="args">Argumentos iniciais</param>
        static void Main(string[] args)
        {
             
            Console.WriteLine("Executanto projeto Q11-CalculaInvestimentoLogoPrazo");

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;

            for(int ano = 1; ano <= 5; ano++)
            {
                for(int contadorMes = 1; contadorMes  <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.0010;
            }

            Console.WriteLine(String.Format("Ao termino do investimento , você terá R$ {0}", valorInvestido.ToString(CultureInfo.InvariantCulture)));

            Console.WriteLine("A execução terminou... Aperte qualquer tecla para finalizar");
            Console.ReadLine();
        }
    }
}
