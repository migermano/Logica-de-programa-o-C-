// Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. 

// Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

// Entrada:
// O arquivo de entrada contém três valores inteiros.

// Saída:
// Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

using System;

namespace URI1013 {
    class Program {
        static void Main(string[] args) {

            int a, b, c, MaiorAB, maior;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            MaiorAB = (a+b+Math.Abs(a-b)) / 2;
            maior = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;

            Console.WriteLine(maior + " eh o maior");

        }
    }
}


            

            