using System;

namespace Q10_CalculaPoupanca2
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

            Console.WriteLine("Calcula Poupança 2");
            double valorInvestido = 1000;

            // Exemplo Calcula Poupanca com for
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine(String.Format("Após {1} mês , você terá R${0}", valorInvestido, contadorMes));
            }

            Console.WriteLine("A execução terminou... Aperte qualquer tecla para finalizar");
            Console.ReadLine();

        }
    }
}
