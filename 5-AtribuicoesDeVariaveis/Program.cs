using System;

namespace _5_AtribuicoesDeVariaveis
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
            Console.WriteLine("Atribuições de variaveis");

            /*
                O codigo funcionará em ordem portanto a variavel _segundaIdade seu valor ficara como 20 pois nao foi efetuado nenhuma agragação
                já a variavel _primeiraIdade seu valor será 40 pois antes de ser printado o valor anterior , foi alterado pelo valor 40.

             */

            int _primeiraIdade = 20;
            int _segundaIdade = _primeiraIdade;

            _primeiraIdade = 40;

            Console.WriteLine("_primeiraIdade : " + _primeiraIdade);
            Console.WriteLine("_segundaIdade : " + _segundaIdade);

            Console.WriteLine("A execução terminou... Aperte qualquer tecla para finalizar");

            Console.ReadLine();
        }
    }
}
