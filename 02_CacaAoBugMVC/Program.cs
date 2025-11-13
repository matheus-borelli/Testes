using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CacaAoBugMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Passagem de Parâmetro por Valor ***");
            // Passa o conteúdo da variável de origem para a variável de destino
            // O método de destino não altera o valor da variável do método de origem

            double valor = 10;
            if (PassagemParametroValor(valor))
                Console.WriteLine($"Valor do método Main --> PassagemParametroValor {valor}");


            Console.WriteLine("\n\n*** Passagem de Parâmetro por Referência REF ***");
            double valor1 = 10;
            if (PassagemParametroReferenciaRef(ref valor1))
                Console.WriteLine($"Valor do método Main --> PassagemParametroReferenciaRef {valor1}");


            Console.WriteLine("\n\n*** Passagem de Parâmetro por Referência OUT ***");
            double valor2;
            if (PassagemParametroReferenciaOut(out valor2))
                Console.WriteLine($"Valor do método Main --> PassagemParametroReferenciaOut {valor2}");


            Console.WriteLine("\n\n*** Passagem de Parâmetro por Referência IN ***");
            double valor3 = 100;
            if (PassagemParametroReferenciaIN(in valor3))
                Console.WriteLine($"Valor do método Main --> PassagemParametroReferenciaIN {valor3}");
        }


        // Método para testar passagem de parâmetro por valor
        public static bool PassagemParametroValor(double valor)
        {
            valor = valor * 10;
            Console.WriteLine($"Valor do método PassagemParametroValor {valor}");
            return true;
        }


        // Método para testar passagem de parâmetro por referência REF
        public static bool PassagemParametroReferenciaRef(ref double valor1)
        {
            valor1 = valor1 * 10;
            Console.WriteLine($"Valor do método PassagemParametroReferenciaRef {valor1}");
            return true;
        }


        // Método para testar passagem de parâmetro por referência OUT
        public static bool PassagemParametroReferenciaOut(out double valor2)
        {
            valor2 = 10;
            valor2 = valor2 * 10;
            Console.WriteLine($"Valor do método PassagemParametroReferenciaOut {valor2}");
            return true;
        }


        // Método para testar passagem de parâmetro por referência IN
        public static bool PassagemParametroReferenciaIN(in double valor3)
        {
            Console.WriteLine($"Valor do método PassagemParametroReferenciaIN {valor3}");
            return true;
        }
    }
}
