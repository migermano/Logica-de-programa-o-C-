// 5- Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a média aritmética somente dos números pares lidos.

// Exemplo:

// Entrada 
// 6
// 8 2 11 14 13 20

// Saída
// 11.0

using System;
using System.Globalization;

namespace Vetor {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {

                vet[i] = double.Parse(s[i]);
            }

            double soma = 0.0;
            int quantidade = 0;

            for (int i = 0; i < N; i++) {
                if (vet[i] % 2 == 0) {
                    soma = soma + vet[i];
                    quantidade++;
                }
            }

            if (quantidade == 0) {
                Console.WriteLine("Nao havia nenhum numero par");
            } else {

                double media = soma / quantidade;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadLine(); 
        }
    }
}