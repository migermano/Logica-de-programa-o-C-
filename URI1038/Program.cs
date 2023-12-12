// Com base na tabela, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

// Entrada:
// O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.

// Saída:
// O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.


using System;
using System.Globalization;

namespace URI1038 {
    class Program {
        static void Main(string[] args) {

            int cod, quantidade;
            double resultado;

            string[] vet = Console.ReadLine().Split(' ');
            cod = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);
            

            if (cod == 1) {
                resultado = quantidade * 4.0;

                Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 2) { 
                resultado = quantidade * 4.5;

                Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 3) {
                resultado = quantidade * 5.0;

                Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 4) {
                resultado = quantidade * 2.0;ComDefaultInterfaceAttribute..

                Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else {
                resultado = quantidade * 1.5;

                Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            
            



        }
    }

}
