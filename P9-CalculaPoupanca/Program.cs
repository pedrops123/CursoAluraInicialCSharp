using System;

namespace P9_CalculaPoupanca
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
            Console.WriteLine("Calcula Poupança");
            int contadorMes = 1;
            double valorInvestido = 1000;

            //Exemplo calcula poupança com while
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine(String.Format("Após {1} mês , você terá R${0}", valorInvestido, contadorMes));
                // contadorMes = contadorMes + 1; - incremento normal
                contadorMes ++; // incremento Simplificado
            }

            Console.WriteLine("A execução terminou... Aperte qualquer tecla para finalizar");
            Console.ReadLine();
        }
    }
}
