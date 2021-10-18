using System;

namespace _8_Escopo
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
            Console.WriteLine("Escopo");

            // Variavel de escopo esta sendo utilizada por todo o bloco main
            string msgAdicional;

            int _idade = 18;
            int _qtdPessoas = 2;

            //Variavel booleana

            var acompanhado = _qtdPessoas >= 2;

            if (acompanhado)
            {
                msgAdicional = "Pessoa esta acompanhada.";
                // Nao é necessario a linha abaixo pois a variavel ja esta sendo utilizada no 
                // escopo atual.
                // string msgAdicional = "Pessoa esta acompanhada.";
            }
            else
            {

                msgAdicional = "Pessoa não esta acompanhada.";
                // Nao é necessario a linha abaixo pois a variavel ja esta sendo utilizada no 
                // escopo atual.
                // string msgAdicional = "Pessoa não esta acompanhada.";
            }

            /* Exemplo de condicional com operador logico */

            if (_idade >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar.");
                // Ao criarmos a variavel global , todo codigo dentro de main consegue visualizar
                // Se criassemos dentro do if else , estes nao conseguiriam se localizar.
                Console.WriteLine(msgAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
                Console.WriteLine(msgAdicional);
            }

            Console.WriteLine("A execução terminou... Aperte qualquer tecla para finalizar");
            Console.ReadLine();


        }
    }
}
