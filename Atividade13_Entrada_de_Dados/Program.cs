using System;
using System.Globalization;
namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Entre com seu nome completo:");
			string nomeCompleto = Console.ReadLine();
			Console.WriteLine("Quantos quartos tem na sua casa?");
			int quartos = int.Parse(Console.ReadLine());
			Console.WriteLine("Entre com o preço de um produto:");
			double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");

			string[] vet = Console.ReadLine().Split(' ');
			Console.WriteLine("Você digitou:");
			string pNome = vet[0];
			int idade = int.Parse(vet[1]);
			double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

			Console.WriteLine(nomeCompleto);
			Console.WriteLine(quartos);
			Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine(pNome);
			Console.WriteLine(idade);
			Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}