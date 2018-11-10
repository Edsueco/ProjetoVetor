using System;
namespace sistemavetor
{
    public class MaiorMenor
    {
        public int num { set; get; }
        public int maior { set; get; }
        public int menor { set; get; }

        public void leiaNumero(){
            Console.Write("Informe a quantidade: ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        public void alimenteVetor(){

            int[] vetor = new int[num];
            for (int i = 0; i < vetor.Length;i++){

                Console.Write("Informe a posição {0} do vetor: ",i);
                vetor[i] = Convert.ToInt32(Console.ReadLine());

                if(vetor[i]< menor) {menor = vetor[i];}
                if(vetor[i] > maior){maior = vetor[i];}
            }
        }

        public void exibeResultado(){
            Console.WriteLine("Menor: {0}, Maior: {1}",menor,maior);
        }

        public MaiorMenor(int Menor,int Maior)
        {
            menor = Menor;
            maior = Maior;

        }
    }
}
