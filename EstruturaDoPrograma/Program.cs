using System;
using EstruturaDoPrograma.Exemplos;

namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(2);
            s.Empilha(3);
            s.Empilha(4);
            s.Empilha(5);
            s.Empilha(6);
            s.Empilha(7);
            s.Empilha(8);
            s.Empilha(9);
            s.Empilha(10);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}
