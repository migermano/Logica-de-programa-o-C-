// 2) Ler um número N e depois uma matriz quadrada NxN com números inteiros. Depois, mostrar na tela a soma dos elementos de cada linha da matriz.

// Entrada:
// A entrada contém o número N, depois os dados da matriz.

// Saída:
// A saída contém os números representando a soma dos elementos de cada linha da matriz.

using System;

namespace Matriz {
    class Program {
        static void Main(string[] args) {

            int [,] mat; 
            int N; 
         N = N = int.Parse(Console.ReadLine()); 
         mat = new int[N, N]; 
        for (int i = 0; i < N; i++) { 
            string[] s = Console.ReadLine(). Split(' '); 
            for (int j = 0; j < N; j++) {
                mat[i, j] = int.Parse(s[j]); 
            }
        }
        for(int i = 0; i < N; i++) { 
            int soma = 0; 
            for (int j = 0; j < N; j++){
                soma = soma + mat[i, j]; 

            }
                Console.WriteLine(soma); 

            }
        }

    }
}

