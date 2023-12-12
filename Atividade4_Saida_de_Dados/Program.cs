// Leia 2 valores inteiros e armazene-os nas variáveis A e B. Efetue a soma de A e B atribuindo o seu resultado na variável X. Imprima X conforme exemplo apresentado abaixo. Não apresente mensagem alguma além daquilo que está sendo especificado e não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

// Entrada
// A entrada contém 2 valores inteiros.

// Saída
// Imprima a mensagem "X = " (letra X maiúscula) seguido pelo valor da variável X e pelo final de linha.

using System;
using System.Globalization;

namespace Curso {
	class Program {
		static void Main(string[] args) {

			double x = 10.35784;
			int y = 32;
			string z = "Maria";
			char w = 'F';

			Console.Write("Olá mundo!");
			Console.WriteLine("Bom dia!");
			Console.WriteLine("Até mais!");
			Console.WriteLine();
			Console.WriteLine(x);
			Console.WriteLine(x.ToString("F2"));
			Console.WriteLine(x.ToString("F4"));
			Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine();
			Console.WriteLine("RESULTADO = " + x);
			Console.WriteLine("O valor do troco é " + x + " reais");
			Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
			Console.WriteLine();
			Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
			Console.ReadLine();
		}
	}
}