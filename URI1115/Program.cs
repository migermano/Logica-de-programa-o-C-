// Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. 
// Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas 
// for NULA (nesta situação sem escrever mensagem alguma).

// Entrada:
// A entrada contém vários casos de teste. Cada caso de teste contém 2 valores inteiros.

// Saída:
// Para cada caso de teste mostre em qual quadrante do sistema cartesiano se encontra a coordenada lida, conforme o exemplo.

using System;
using System.Collections.Generic;

namespace URI1115 {
    class Program {
        static void Main(string[] args) {
            int x, y;
            List<string> quadrantes = new List<string>();

            while (true) {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x == 0 || y == 0) {
                    break; 
                }

                if (x > 0 && y > 0) {
                    quadrantes.Add("primeiro");
                }
                else if (x < 0 && y > 0) {
                    quadrantes.Add("segundo");
                }
                else if (x < 0 && y < 0) {
                    quadrantes.Add("terceiro");
                }
                else {
                    quadrantes.Add("quarto");
                }
            }

           
            foreach (var quadrante in quadrantes) {
                Console.WriteLine(quadrante);
            }
        }
    }
}