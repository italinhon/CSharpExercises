using System;

namespace Exercicio4_if_else {
    internal class Program { 
    
        static void Main(string[] args) {

            Console.WriteLine("Entre com um número: ");
            
            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0) {
                Console.WriteLine("Par");
            }
            else {
                Console.WriteLine("Impar");
            }
        }
    }

}
