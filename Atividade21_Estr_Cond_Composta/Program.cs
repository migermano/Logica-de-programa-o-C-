using System;

namespace Curso{
    class Program {
        static void Main(string[] args) {

            int horas;

            Console.Write("Quantas horas? ");
           horas = int.Parse(Console.ReadLine());

            if (horas < 12) {
                Console.WriteLine("Bom dia!");

            }
            else {
                Console.WriteLine("Boa tarde!");
            }

            Console.ReadLine();
        }
    }
}
