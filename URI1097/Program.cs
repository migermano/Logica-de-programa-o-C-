﻿// Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo:

// I=1 J=7
// I=1 J=6
// I=1 J=5
// I=3 J=9
// I=3 J=8
// I=3 J=7
// ...
// I=9 J=15
// I=9 J=14
// I=9 J=13

// Entrada:
// Não há nenhuma entrada neste problema.

// Saída:
// Imprima a sequencia conforme exemplo abaixo.

﻿using System;

namespace URI1097 {
    class Program {
        static void Main(string[] args) {

            int j = 7;
            for (int i = 1; i <= 9; i = i + 2) {
                Console.WriteLine("I=" + i + " J=" + j);
                Console.WriteLine("I=" + i + " J=" + (j - 1));
                Console.WriteLine("I=" + i + " J=" + (j - 2));
                j = j + 2;
            }
        }
    }
}