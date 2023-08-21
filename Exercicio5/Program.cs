using System;

namespace Exercicio5_while { 
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a senha: ");

            int x = int.Parse(Console.ReadLine());


            while (x != 2002) {
                Console.WriteLine("Senha Invalida");
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}