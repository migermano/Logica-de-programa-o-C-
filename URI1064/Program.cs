// Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha, deve-se mostrar a média de todos os valores 
// positivos digitados, com um dígito após o ponto decimal.

// Entrada:
// A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números será positivo.

// Saída:
// O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve mostrar a média dos valores positivos digitados.

using System;
using System.Globalization;

namespace URI1064{
    class Program {
        static void Main(string[] args) {

            int contagem = 0;
            double soma = 0.0;

            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            if (a > 0.0) {
                contagem = contagem + 1;
                soma = soma + a;
            }
            if (b > 0.0) {
                contagem = contagem + 1;
                soma = soma + b;
            }
            if (c > 0.0) {
                contagem = contagem + 1;
                soma = soma + c;
            }
            if (d > 0.0) {
                contagem = contagem + 1;
                soma = soma + d;
            }
            if (e > 0.0) {
                contagem = contagem + 1;
                soma = soma + e;
            }
            if (f > 0.0) {
                contagem = contagem + 1;
                soma = soma + f;
            }
            Console.WriteLine(contagem + " valores positivos");

            double media = soma / contagem;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}