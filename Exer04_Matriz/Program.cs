// 4) Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar a soma dos elementos acima da diagonal principal.

// Entrada:
// A entrada contém o valor N, depois os dados da matriz.

// Saída:
// A saída contém a soma dos elementos da diagonal principal.

using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] mat;

            N = int.Parse(Console.ReadLine());
            mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int soma = 0; 

            for (int i = 0; i < N; i++) 
            {
                for (int j = i + 1; j < N; j++)
                { 
                    soma = soma + mat[i, j]; 
                }
            }
            Console.WriteLine(soma); 
        }
    }
}
