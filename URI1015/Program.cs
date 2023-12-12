// Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) 
// e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula.

// Entrada:
// O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: 
// x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

// Saída:
// Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.

using System;
using System.Globalization;

namespace URI1015 {
    class Program {
        static void Main(string[] args) {

            double x1, y1, x2, y2, p1, p2, distancia;

            string[] vet = Console.ReadLine().Split(' ');
             x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
             y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

             vet = Console.ReadLine().Split(' ');
             x2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
             y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            p1 = x1 - x2;
            p2 = y1 - y2;

            distancia = Math.Sqrt(Math.Pow(p1, 2.0) + Math.Pow(p2, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
