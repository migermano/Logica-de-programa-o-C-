// 3) Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar qual o maior elemento de cada linha. Suponha não haver empates.

// Entrada:
// A entrada contém o número N, depois os dados da matriz.

// Saída:
// A saída contém os números representando o maior elemento de cada linha da matriz.

using System;

namespace Matriz;

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

        for (int i = 0; i < N; i++) 
        {
            int maior = mat[i, 0]; 

            for (int j = 1; j < N; j++)
            {
                if (mat[i, j] > maior) 
                {
                    maior = mat[i, j];
                }
            }
            Console.WriteLine(maior); 
        }
    }
}
