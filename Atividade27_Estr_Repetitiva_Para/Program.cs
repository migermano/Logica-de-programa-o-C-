using System;

namespace Curso {
    class Program {
        static void Main(string[] args) {

            int N, x,soma;

            N = int.Parse(Console.ReaLine());

            soma = 0;
            for (int i=1; i<=N; i++) {
                x = int.Parse(Console.ReaLine());
                soma = soma + x;
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
