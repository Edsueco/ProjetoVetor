using System;
namespace sistemavetor
{
    public class Vetor
    {
        public void lerNomes(){

            Console.WriteLine("Informe a quantidade de palavras do seu nome");
            string[] nome = new string[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine("Informe seu nome ou sobrenome");
                nome[i] = Console.ReadLine();
            }

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);
            }
        }

        public void quebraNome(){
            Console.WriteLine("Informe o nome:");
            string nome = Console.ReadLine();

            string[] partes = nome.Split(" ");

            for (int i = 0; i < partes.Length;i++){
                Console.WriteLine("Posição {0}, Valor {1}",i,partes[i]);
            }
        }

        public Vetor()
        {
        }
    }
}
