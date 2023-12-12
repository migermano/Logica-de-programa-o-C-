// 3- Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um terceiro vetor C onde
// cada elemento de C é a soma dos elementos correspondentes de A e B. Imprima o vetor C gerado.

// Exemplo:

// Entrada 
// 6
// 8 2 11 14 13 20
// 5 10 3 1 10 7

// Saída
// 13 12 14 15 23 27

using System;

namespace Vetor {
    class Program {
        static void Main(string[] args) {
            
            /
            int N; 

            N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                A[i] = int.Parse(s[i]);
            }

            s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                B[i] = int.Parse(s[i]);
            }

            int[] C = new int[N];
            for (int i = 0; i < N; i++) {
                C[i] = A[i] + B[i];
            }

            for (int i = 0; i < N; i++) {
                Console.Write(C[i] + " ");
            }

            Console.WriteLine(); 


            Console.ReadLine(); 
        }
    }
}