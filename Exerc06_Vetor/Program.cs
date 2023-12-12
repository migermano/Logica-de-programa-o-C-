//  6- Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Depois, mostrar na tela o nome
//  da pessoa mais velha.

//  Exemplo:

//  Entrada
//  5
//  Joao 16
//  Maria 21
//  Teresa 15
//  Carlos 23
//  Paulo 17

//  Saída
//  Pessoa mais velha: Carlos


using System;

namespace Vetor {
    class Program {
        static void Main(string[] args) {
            
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];

            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' '); 
                nomes[i] = s[0]; 
                idades[i] = int.Parse(s[1]); 
            }

            int maiorIdade = idades[0]; 
            int posicaoMaiorIdade = 0; 

            for (int i = 1; i < N; i++) {
                if (idades[i] > maiorIdade) {
                    maiorIdade = idades[i];
                    posicaoMaiorIdade = i;
                }
            }

            Console.WriteLine("Amigo mais velho: " + nomes[posicaoMaiorIdade] + ", Idade: " + maiorIdade);

            Console.ReadLine();
        }
    }
}