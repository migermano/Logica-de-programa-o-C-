// Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos (desconsidere os valores nulos). 
// A seguir, mostre a quantidade de valores positivos digitados.

// Entrada:
// Seis valores, negativos e/ou positivos.

// Saída:
// Imprima uma mensagem dizendo quantos valores positivos foram lidos.

using System;

namespace URI1060{
    class Program{
        static void Main(string[] args){

            double a, b, c, d, e, f;
            int contagem = 0;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            e = double.Parse(Console.ReadLine());
            f = double.Parse(Console.ReadLine());


            if (a > 0.0) {
                contagem = contagem + 1;
            }
            if (b > 0.0) {
                contagem = contagem + 1;
            }
            if (c > 0.0) {
                contagem = contagem + 1;
            }
            if (d > 0.0) {
                contagem = contagem + 1;
            }
            if (e > 0.0) {
                contagem = contagem + 1;
            }
            if (f > 0.0) {
                contagem = contagem + 1;
            }

            Console.WriteLine(contagem + " valores positivos");

        }
    }
}
