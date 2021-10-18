using System;

namespace _1_CriandoVariaveis
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
            //Criação de variaveis

                Console.WriteLine("Criando variaveis");


                int idade;

                idade = 10 + 5;
                Console.WriteLine(idade);
                idade = 10 + 5 * 2;
                Console.WriteLine(idade);
                idade = (10 + 5) * 2;
                Console.WriteLine(idade);

                Console.WriteLine("A execução terminou... Aperte qualquer tecla para finalizar");

                Console.ReadLine();
          }
        }
}
