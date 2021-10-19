using System;

namespace _4_CaracteresETextos
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
            Console.WriteLine("Conversoes e outros tipos numericos.");

            /* Criando um caracter */

            char _caracter = 'a';


            Console.WriteLine(_caracter);

            /* Exemplo de Casting caracter */

            _caracter = (char)65;

            Console.WriteLine(_caracter);


             /* Exemplo de associação e casting para char */

            _caracter = (char)(_caracter + 1);

            Console.WriteLine(_caracter);

            /* Exemplo de string */

            string titulo = "Alura cursos de tecnologia";
            Console.WriteLine(titulo);

            /* Exemplo de string concatenado com inteiros  - O numero inteiro automaticamente é detectado e passado para string*/

            titulo = "Alura cursos de tecnologia " + 2021;
            Console.WriteLine(titulo);


            /* Exemplo quebra de linha literal ( gambiarra ) */

            string cursos = @"- PHP  
 -Java 
-Javascript ";


            Console.WriteLine(cursos);

            /* Exemplo quebra de linha simplificada */

            cursos = "- PHP\n-Java\n-Javascript ";

            Console.WriteLine(cursos);


            Console.WriteLine("A execução terminou... Aperte qualquer tecla para finalizar");

            Console.ReadLine();
        }
    }
}
