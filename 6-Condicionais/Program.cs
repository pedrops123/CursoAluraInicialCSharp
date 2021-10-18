using System;

namespace _6_Condicionais
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
            Console.WriteLine("Condicionais");


            int _idade = 16;
            int _qtdPessoas = 1;


            /* Exemplo de condicional */

            if (_idade >= 18)
            {
                Console.WriteLine("Pessoa é maior de 18. Pode entrar.");
            }
            else
            {
                if (_qtdPessoas > 1)
                {
                    Console.WriteLine("Pessoa é menor de 18 mas esta acompanhada. Pode entrar.");
                }
                else
                {
                    Console.WriteLine("Pessoa é menor de 18. Não pode entrar.");
                }

            }

            Console.WriteLine("A execução terminou... Aperte qualquer tecla para finalizar");
            Console.ReadLine();
        }
    }
}
