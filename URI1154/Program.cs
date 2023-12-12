// Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. O último dado, 
// que não entrará nos cálculos, contém o valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.

// Entrada:
// A entrada contém um número indeterminado de inteiros. A entrada será encerrada quando um valor negativo for lido.

// Saída:
// A saída contém um valor correspondente à média de idade dos indivíduos.

// A média deve ser impressa com dois dígitos após o ponto decimal.

using System;

class Program
{
    static void Main(string[] args)
    {
        int somaIdades = 0;
        int quantidadePessoas = 0;

        while (true)
        {
            int idade = int.Parse(Console.ReadLine());

            if (idade < 0)
                break; // Encerra o loop se uma idade negativa for lida

            somaIdades += idade;
            quantidadePessoas++;
        }

        if (quantidadePessoas > 0)
        {
            double mediaIdades = (double)somaIdades / quantidadePessoas;
            Console.WriteLine(mediaIdades.ToString("F2"));
        }
        else
        {
            Console.WriteLine("0.00"); // Evita a divisão por zero se não houver dados de entrada
        }
    }
}
