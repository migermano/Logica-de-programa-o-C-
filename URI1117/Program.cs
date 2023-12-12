// Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a média semestral.
// Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

// Entrada:
// A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.

// Saída:
// Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
// Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. O valor deve ser apresentado com duas casas após o ponto decimal.

using System;
using System.Globalization;

namespace URI1117 {
    class Program {
        static void Main(string[] args) {

            double media;
            double nota = 0;
            double soma = 0;
            int cont = 0;

            while(cont < 2) {
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Nota inválida
                    if (nota < 0.0 || nota > 10.0)
                {
                    Console.WriteLine("nota invalida");
                }
                //Nota válida
                else
                {
                    soma += nota;
                    cont++;
                }
            }

        media = soma / cont;
        Console.WriteLine($"media = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
    
 }

//  Inclusão de Bibliotecas:

// using System;
// using System.Globalization;
// Neste trecho, estamos importando duas bibliotecas: System para funcionalidades básicas e System.Globalization para lidar com a formatação de números.

// Declaração da Classe e do Método Main:

// namespace URI1117 {
//     class Program {
//         static void Main(string[] args) {
//             // Código do programa
//         }
//     }
// }
// Aqui, estamos declarando uma classe chamada Program dentro do namespace URI1117 e o método Main, que é o ponto de entrada do programa.

// Declaração de Variáveis:

// double media;
// double nota = 0;
// double soma = 0;
// int cont = 0;
// Estas são as variáveis usadas no programa:

// media: Armazena a média das notas.
// nota: Armazena temporariamente cada nota inserida.
// soma: Mantém a soma das notas válidas.
// cont: Contador para controlar quantas notas válidas foram inseridas.
// Loop While para Leitura das Notas:

// while (cont < 2) {
//     nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//     //Nota inválida
//     if (nota < 0.0 || nota > 10.0) {
//         Console.WriteLine("nota invalida");
//     }
//     //Nota válida
//     else {
//         soma += nota;
//         cont++;
//     }
// }




// Inclusão de Bibliotecas:

// using System;
// using System.Globalization;

// Neste trecho, estamos importando duas bibliotecas: System para funcionalidades básicas e System.Globalization para lidar com a formatação de números.

// ---------------------------------------------------------------------------------------------------------------------------------------------------------------

// Declaração da Classe e do Método Main:

// namespace URI1117 {
//     class Program {
//         static void Main(string[] args) {
//             // Código do programa
//         }
//     }
// }
// Aqui, estamos declarando uma classe chamada Program dentro do namespace URI1117 e o método Main, que é o ponto de entrada do programa.

// ---------------------------------------------------------------------------------------------------------------------------------------------------------------

// Declaração de Variáveis:

// double media;
// double nota = 0;
// double soma = 0;
// int cont = 0;

// Estas são as variáveis usadas no programa:

// - media: Armazena a média das notas.
//  - nota: Armazena temporariamente cada nota inserida.
// - soma: Mantém a soma das notas válidas.
// - cont: Contador para controlar quantas notas válidas foram inseridas.

// ---------------------------------------------------------------------------------------

// Loop While para Leitura das Notas:

// while (cont < 2) {
//     nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//     //Nota inválida
//     if (nota < 0.0 || nota > 10.0) {
//         Console.WriteLine("nota invalida");
//     }
//     //Nota válida
//     else {
//         soma += nota;
//         cont++;
//     }
// }

// Neste loop while, o programa continuará pedindo ao usuário para inserir notas enquanto cont for menor que 2 (ou seja, para obter duas notas). 
// Para cada nota inserida, o programa faz o seguinte:

// - Lê a nota da entrada padrão (teclado).
// - Verifica se a nota é inválida (menor que 0.0 ou maior que 10.0). Se for inválida, exibe "nota invalida".
// - Se a nota for válida, ela é somada a soma e o contador cont é incrementado.

// -------------------------------------------------------------------------------------------------------------------------------------------------------------

// Cálculo da Média e Exibição do Resultado:

// media = soma / cont;
// Console.WriteLine($"media = " + media.ToString("F2", CultureInfo.InvariantCulture));

// Após obter as duas notas válidas, o programa calcula a média dividindo a soma pelo número de notas válidas (cont). 
// A média é então formatada como uma string com duas casas decimais usando ToString("F2", CultureInfo.InvariantCulture) e
// é impressa na saída padrão junto com a mensagem "media = ".

// Resumindo, este código C# lê duas notas do usuário, verifica se são válidas, calcula a média das notas válidas e a exibe com duas casas decimais. 
// Se uma nota for inválida, o programa pede uma nova entrada até obter duas notas válidas.




