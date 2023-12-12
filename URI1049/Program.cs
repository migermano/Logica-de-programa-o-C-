// Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo,
// da esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.

// Entrada:
// A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.

// Saída:
// Imprima o nome do animal correspondente à entrada fornecida.

using System;

namespace URI1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string plvr1,
                plvr2,
                plvr3;

            plvr1 = Console.ReadLine();
            plvr2 = Console.ReadLine();
            plvr3 = Console.ReadLine();

            if (plvr1 == "vertebrado")
            {
                if (plvr2 == "ave")
                {
                    if (plvr3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                    else if (plvr3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                }
                else if (plvr2 == "mamifero")
                {
                    if (plvr3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (plvr3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (plvr1 == "invertebrado")
            {
                if (plvr2 == "anelideo")
                {
                    if (plvr3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (plvr3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
                else if (plvr2 == "inseto")
                {
                    if (plvr3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (plvr3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
            }
            else
            {
                Console.WriteLine("animal não encontrado");
            }
        }
    }
}
