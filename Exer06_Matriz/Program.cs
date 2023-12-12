// 6) Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida, fazer as seguintes ações:

// a) calcular e imprimir a soma de todos os elementos positivos da matriz.
// b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
// c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
// d) imprimir os elementos da diagonal principal da matriz.
// e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.

// Entrada:
// A entrada contém o número inteiro N, seguido dos valores da matriz com uma casa decimal cada, seguido do índice de
// uma linha, seguido do índice de uma coluna, conforma exemplo.

// Saída:
// A saída contém os valores de saída de cada ação, com uma casa decimal, na ordem em que foram apresentadas no
// enunciado, conforme exemplo.

using System;
using System.Globalization;
namespace Matriz {
    class Program {
        static void Main(string[] args) {

            int N;
            double[,] mat;

            N = int.Parse(Console.ReadLine());
            mat = new double[N, N];

       
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            int linha; 
            int coluna; 

            linha = int.Parse(Console.ReadLine());
            coluna = int.Parse(Console.ReadLine());


            double soma = 0.0;

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] > 0.0) {
                        soma = soma + mat[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < N; j++) {
                Console.Write(mat[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
	
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++) {
                Console.Write(mat[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++) {
                Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] < 0.0) {
                        mat[i, j] = mat[i, j] * mat[i, j];
                    }
                }
            }
            Console.WriteLine("MATRIZ ALTERADA:"); 
            for (int i = 0; i < N; i++) { 
                for (int j = 0; j < N; j++) {
                    Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }

        }
    }
}