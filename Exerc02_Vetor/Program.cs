using System.Data;

// 2- Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
//            - todos os números pares
//            - a quantidade de números pares

// Exemplo:

// Entrada 
// 6
// 8 2 11 14 13 20

// Saída
// 8 2 14 20
// 4

using System;

namespace Vetor {
    class Program {
        static void Main(string[] args) {

            int N; 
            int[] vet; 

            N = int.Parse(Console.ReadLine());

            vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vet[i] = int.Parse(s[i]);
            }

            int contador = 0; 

            for (int j = 0; j < N; j++) {
                if (vet[j] % 2 == 0) {
                    contador++; 
                }
            }

            for (int j = 0; j < N; j++) {
                if (vet[j] % 2 == 0) {
                    Console.Write(vet[j] + " "); 
                }
            }


            Console.WriteLine("Quantidade de pares: " + contador);

            Console.ReadLine();
        }
    }
}