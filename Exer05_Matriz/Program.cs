// 5) Fazer um programa para ler duas matrizes de números inteiros A e B, contendo de M linhas e N colunas cada. Depois, gerar uma terceira matriz C onde cada elemento desta 
//é a soma dos elementos correspondentes das matrizes originais. Imprimir na tela a matriz gerada.

// Entrada:
// A entrada contém os valores de M e N, depois os valores da primeira matriz A, depois os valores da segunda matriz B,
// conforme exemplo.

// Saída:
// A saída contém os valores da matriz gerada C, conforme exemplo.

using System;
namespace Matriz {
    class Program {
        static void Main(string[] args) {

            int M; 
            int N; 
            int [,] A;
            int [,] B;
            int [,] C; 

            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            A = new int [M, N];
            B = new int [M, N];
            C = new int [M, N];

            for (int i = 0; i < M; i++) {
               s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            
            for (int i = 0; i < M; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    B[i, j] = int.Parse(s[j]);
                }
            }

            
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    C[i, j] = A[i, j] + B[i, j]; 
                }
            }

            
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}