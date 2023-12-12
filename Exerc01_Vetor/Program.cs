// 1- Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número
// do vetor (supor não haver empates). Mostrar também a posição do maior elemento.

// Exemplo:

// Entrada 
// 6
// 8.0 4.0 10.0 14.0 13.0 7.0

// Saída
// 14.0
// 3


using System;
using System.Globalization;

namespace Vetor {
    class Program {

        static void Main(string[] args) {
            
            
            int N;
            double[] vet; 
            
            N = int.Parse(Console.ReadLine());

            
            vet = new double[N];  

            
            string[] valores = Console.ReadLine().Split(' ');

            
            for (int i = 0; i < N; i++) {
                vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            }

            double maior = vet[0]; 
            int posicaoMaior = 0; 

            for (int i = 1; i < N; i++) {
                
                if (vet[i] > maior) {
                    maior = vet[i];
                    posicaoMaior = i; 
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture)); 
            Console.WriteLine(posicaoMaior); 
        }
    }
}
       
    