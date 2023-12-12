// O sargento Silva organiza seu pelotão em M filas numeradas a partir de 1, sendo cada fila com a mesma quantidade de soldados. 

// Um dos exercícios que o sargento Silva realiza com o pelotão é o exercício "girar fila", que consiste em dizer o número de uma fila, de modo que os soldados desta fila devem 
// se mover para a direita, e o último soldado da direita vai para a posição mais à esquerda. Você deve fazer um programa para ler a formação do pelotão e executar o exercício "girar fila".

// Entrada:
// A entrada consiste em um inteiro M representando o número de filas, um inteiro N representado a quantidade de soldados
// por fila, as M filas de soldados (cada soldado é representado por um número inteiro), e o número inteiro para o exercício
// "girar fila".

// Saída:
// A saída contém a formação do pelotão após a execução do exercício "girar fila".

﻿using System;
namespace Matriz {
    class Program {
        static void Main(string[] args) {

            int M;
            int N;

            int[,] mat;

            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());

            mat = new int[M,N];

            for (int i = 0; i < M; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int fila = int.Parse(Console.ReadLine());

            fila = fila - 1;

            int ultimoDaFila = mat[fila, N - 1];

            for (int j = N - 1; j > 0; j--) {
                mat[fila, j] = mat[fila, j - 1];
            }

            mat[fila, 0] = ultimoDaFila;

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}