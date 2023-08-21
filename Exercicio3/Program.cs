using System;

namespace Exercicio3_if_else { 
    internal class Program { 
        static void Main(string[] args) {

            Console.WriteLine("Entre com um número: ");
            
            int a = int.Parse(Console.ReadLine());

            if (a < 0) {
                Console.WriteLine("Negativo");
            }
            else {
                Console.WriteLine("Não Negativo");

            }
        }    
    }
}
