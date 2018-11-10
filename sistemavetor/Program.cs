using System;

namespace sistemavetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetor v1 = new Vetor();
            MaiorMenor m1 = new MaiorMenor(999,0);

            //v1.lerNomes();
            //v1.quebraNome();

            m1.leiaNumero();
            m1.alimenteVetor();
            m1.exibeResultado();

        }
    }
}
