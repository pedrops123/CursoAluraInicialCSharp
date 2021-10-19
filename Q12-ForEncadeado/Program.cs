using System;

namespace Q12_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executanto projeto Q12-ForEncadeado");


            /* Exemplo de for encadeado que monta uma piramide lateral */

            char ItemPiramide = '*';

            for(int Linha = 0; Linha < 10; Linha++ ) {
                Console.WriteLine();
                for(int Coluna = 0; Coluna <= Linha; Coluna++)
                {
                    Console.Write(ItemPiramide);
                }
            }
            Console.WriteLine();
            Console.WriteLine("A execução terminou... Aperte qualquer tecla para finalizar");
            Console.ReadLine();


        }
    }
}
