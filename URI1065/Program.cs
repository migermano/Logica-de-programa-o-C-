// Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.

// Entrada:
// O arquivo de entrada contém 5 valores inteiros quaisquer.

// Saída:
// Imprima a mensagem conforme o exemplo fornecido, indicando a quantidade de valores pares lidos.

using System;

namespace URI1065 {
    class Program{
        static void Main(string[] args) {

            int a, b, c ,d , e;
            int contagem = 0;

            a = int.Parse(Console.ReadLine());
            
            b = int.Parse(Console.ReadLine());
            
            c = int.Parse(Console.ReadLine());
            
            d = int.Parse(Console.ReadLine());
            
            e = int.Parse(Console.ReadLine());

        
            if (a % 2 == 0) {
                contagem = contagem + 1;
            }
            if (b % 2 == 0) {
                contagem = contagem + 1;
            }
            if (c % 2 == 0) {
                contagem = contagem + 1;
            }
            if (d % 2 == 0) {
                contagem = contagem + 1;
            }
            if (e % 2 == 0) {
                contagem = contagem + 1;
            }
            Console.WriteLine(contagem + " valores pares");
        }
    }
}
        
