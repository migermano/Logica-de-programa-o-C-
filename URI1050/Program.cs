// Leia um número inteiro que representa um código de DDD para discagem interurbana. Em seguida, informe à qual cidade o DDD pertence, considerando a tabela.

// Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o programa deverá informar:
// DDD nao cadastrado

// Entrada:
// A entrada consiste de um único valor inteiro.

// Saída:
// Imprima o nome da cidade correspondente ao DDD existente na entrada. Imprima DDD nao cadastrado caso não existir DDD correspondente ao número digitado.

using System;

namespace URI1050{
    class Program{
        static void Main(string[] args){

            int DDD;

            DDD = int.Parse(Console.ReadLine());

            if (DDD == 61) {
            Console.WriteLine("Brasilia");
            }
        
            else if (DDD == 71) {
                 Console.WriteLine("Salvador");
            }

            else if (DDD == 11) {
                 Console.WriteLine("Sao Paulo");
            }

            else if (DDD == 21) {
                 Console.WriteLine("Rio de Janeiro");
            }

            else if (DDD == 32) {
                 Console.WriteLine("Juiz de Fora");
            }
 
            else if (DDD == 19) {
                 Console.WriteLine("Campinas");
            }

            else if (DDD == 27) {
                 Console.WriteLine("Vitoria");
            }

            else if (DDD == 31) {
                 Console.WriteLine("Belo Horizonte");
            }

            else {
                 Console.WriteLine("DDD nao cadastrado");
            }



        }
    }
}
