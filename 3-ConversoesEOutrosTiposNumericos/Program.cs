using System;

namespace _3_ConversoesEOutrosTiposNumericos
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

            /*
                *  O tipo short é uma variavel que aceita valores sem pontos flutuantes , e seu tamanho é de 16 bits.
                *  O tipo Int é uma variavel que aceita valores sem pontos flutuantes , e seu tamanho é de 32 bits.
                *  O tipo long é uma variavel que aceita valores sem pontos flutuantes , e seu tamanho é de 64 bits.           
             */



            /*
                Diferença entre float e double -> Float tem precisão curta e limitada apos casa decimal , double tem precião apos a virgula
                muito maior.
            */

            double _salario = 1200.50;

            Console.WriteLine("Criando Conversoes e outros tipos numericos.");

            /* 
                 Exemplo de casting entre inteiro e double   - 32 bits
            */
            int salarioEmInteiro = (int)_salario;

            /* 
                Automaticamente ao fazer o casting , o valor perde sua precisão.
            */

            Console.WriteLine(String.Format("O salario em inteiro é {0}",salarioEmInteiro));

            /*
             * Numeros inteiros nao suportam valores 64 bits somente 32bits portanto é necessario trocarmos para long , que suporta ate 64 bits 
                int idade;
                idade = 13000000000; 
             */


            /* Exemplo long 64 bits */
            long idade;
            idade = 13000000000;
            Console.WriteLine(idade);



            /* Exemplo short 16 bits */

            short quantidadeProdutos;
            quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);


            /* Exemplo float com sufixo "f" */

            float altura = 1.60f;

            Console.WriteLine("A execução terminou... Aperte qualquer tecla para finalizar");

            Console.ReadLine();

        }       
    }
}
