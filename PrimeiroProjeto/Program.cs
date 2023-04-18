using System;
using System.Globalization;

namespace PrimeiroProjeto {
    public class Program {
        public static void Main(string[] args) {

            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ", CultureInfo.InvariantCulture);
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o seu último nome, idade e altura: (mesma linha)", CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(" ");
            string lastName = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"), CultureInfo.InvariantCulture);
            



        }

    }
}