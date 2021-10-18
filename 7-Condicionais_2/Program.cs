using System;

namespace _7_Condicionais_2
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


            Console.WriteLine("Condicionais com booleanos e operadores logicos");


            int _idade = 18;
            int _qtdPessoas = 1;

            //Variavel booleana

            var acompanhado = _qtdPessoas >= 2;


            /* Exemplo de condicional com operador logico */

            if (_idade >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar.");
            }
            else 
            { 
                Console.WriteLine("Não pode entrar.");
            }

            Console.WriteLine("A execução terminou... Aperte qualquer tecla para finalizar");
            Console.ReadLine();

        }
    }
}
