using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main (string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1} cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro {idade} anos de idade, cógdigo {codigo} e gênero {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (Três Casas Deciamais): {medida:F3}");
            Console.WriteLine($"Arredondado (Duas Casas Decimais): {medida:F2}");

        }
    }
}