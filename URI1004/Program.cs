// Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. A seguir mostre a variável PROD com mensagem correspondente.   

// Entrada:
// O arquivo de entrada contém 2 valores inteiros.

// Saída:
// Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
// Não esqueça de imprimir o fim de linha após o produto, caso contrário seu programa apresentará a mensagem: “Presentation Error”.

using System;
using System.Globalization;

namespace URI1004{
    class Program {
        static void Main(string[] args) {

            int N1, N2, PROD;
            N1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            PROD = N1 * N2;

            Console.WriteLine("PROD = " + PROD.ToString("F0",CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
