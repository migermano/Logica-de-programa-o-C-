// Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
// o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

// Entrada:
// O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

// Saída:
// A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". 
// O valor deverá ser apresentado com 2 casas após o ponto.

using System;
using System.Globalization;

namespace URI1010 {
    class Program {
        static void Main(string[] args) {

           int cod1, cod2, nump1, nump2;
           double valorun1, valorun2, total;

           string[] vet = Console.ReadLine().Split(' ');
           cod1 = int.Parse(vet[0]);
           nump1 = int.Parse(vet[1]);
           valorun1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

           vet = Console.ReadLine().Split(' ');
           cod2 = int.Parse(vet[0]);
           nump2 = int.Parse(vet[1]);
           valorun2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

           total = nump1 * valorun1 + nump2 * valorun2;

           Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}

