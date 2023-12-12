// Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, 
// cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, 
// o segundo valor tem peso 3 e o terceiro valor tem peso 5.

// Entrada:
// O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N linha a seguir contém um caso de teste com três valores com uma casa decimal cada valor.

// Saída:
// Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo abaixo.

using System;
using System.Globalization;

namespace URI1079 {

    class Program {

        static void Main(string[] args) {

            int N;
            double teste1, teste2, teste3, media;

            N = int.Parse(Console.ReadLine());

            for (int i=0; i<N; i++) {

                string[] vet = Console.ReadLine().Split(' ');
                teste1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                teste2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                teste3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = (teste1 * 2.0 + teste2 * 3.0 + teste3 * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

                }
            }
        }
     }