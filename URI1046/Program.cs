// Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, 
// tendo uma duração mínima de 1 hora e máxima de 24 horas.

// Entrada:
// A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.

// Saída:
// Apresente a duração do jogo conforme exemplo abaixo.

using System;
using System.Globalization;
 
namespace URI{
    class Program{
        static void Main(string[]args){
            int horaInicio, horaFim, duracao;
 
            string[] vet = Console.ReadLine().Split(' ');
            horaInicio = int.Parse(vet[0]);
            horaFim = int.Parse(vet[1]);
 
            if (horaInicio < horaFim){
                duracao = horaFim - horaInicio;
            }
            else{
                duracao = 24 - horaInicio + horaFim;
            }
 
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}