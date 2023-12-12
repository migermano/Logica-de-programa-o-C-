// O programa deve ler um valor inteiro X indefinidas vezes. (O programa irá parar quando o valor de X for igual a 0). 
// Para cada X lido, imprima a soma dos 5 pares consecutivos a partir de X, inclusive o X , se for par. Se o valor de entrada for 4, 
// por exemplo, a saída deve ser 40, que é o resultado da operação: 4+6+8+10+12, enquanto que se o valor de entrada for 11, por exempo, 
// a saída deve ser 80, que é a soma de 12+14+16+18+20.

// Entrada:
// O arquivo de entrada contém muitos valores inteiros. O último valor do arquivo é zero.

// Saída:
// Imprima a saida conforme a explicação acima e o exemplo abaixo

﻿using System;

namespace URI1159 {
    class Program {
        static void Main(string[] args) {

            int x; 
            x = int.Parse(Console.ReadLine());

            while (x != 0) {

                // se for impar, some mais 1
                if (x % 2 != 0) {
                    x = x + 1;
                }

                // expressao simplificada: 5 * x + 20
                int soma = x + x + 2 + x + 4 + x + 6 + x + 8;
                Console.WriteLine(soma);

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}