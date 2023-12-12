// Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso.

// Entrada:
// A entrada será um valor inteiro positivo.

// Saída:
// A saída será uma sequência de seis números ímpares.

using System;

namespace URI1070 {
    class Program {
        static void Main(string[] args) {

            int X;

            X = int.Parse(Console.ReadLine());

            if (X % 2 == 0) {
                X = X + 1;
            }

            Console.WriteLine(X);
            Console.WriteLine(X + 2);
            Console.WriteLine(X + 4);
            Console.WriteLine(X + 6);
            Console.WriteLine(X + 8);
            Console.WriteLine(X + 10);

        }
    }
}