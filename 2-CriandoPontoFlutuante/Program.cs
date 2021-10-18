using System;

namespace _2_CriandoPontoFlutuante
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

            double _salario = 1200.70;
            double _idade;
            Console.WriteLine("Criando ponto flutuante.");

            Console.WriteLine(_salario);

            /* 
                 Para um calculo  respeitar o ponto flutuante , é necessário ter pelo menos 1 valor com ponto flutuante
                 caso contrario , ele fará como inteiro;
            */
            _idade = 15.0 / 2;
            Console.WriteLine(_idade);


            /*
             Ao fazer um calculo sem pontos flutuantes , o valor é truncado ( é ignorado tudo depois da virgula ) e nao arredondado
            */

            _idade = 5 / 3;
            Console.WriteLine(String.Format("5 / 3 = {0}", _idade));

            _idade = 5.0 / 3;

            Console.WriteLine(String.Format("5.0 / 3 = {0}",_idade));

    

            Console.WriteLine("A execução terminou... Aperte qualquer tecla para finalizar");

            Console.ReadLine();

        }
    }
}
