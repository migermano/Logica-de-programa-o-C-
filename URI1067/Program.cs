// Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

// Entrada:
// O arquivo de entrada contém 1 valor inteiro qualquer.

// Saída:
// Imprima todos os valores ímpares de 1 até X, inclusive X, se for o caso.


using System;

namespace URI1067 {
    class Program {

        static void Main(string[] args) {

            int x;

             x = int.Parse(Console.ReadLine()); //o que estiver no início vai ser executado somente uma vez, então i recebe 1. O que estiver no meio é uma condição, ou seja, o que for verdadeiro executa e o que for falso pula fora,então i é menor igual a X?. No terceiro elemento executa toda vez depois de voltar, então i recebe i + 1 .

            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }

    }
}