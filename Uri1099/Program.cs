using System;

namespace Uri1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maior, menor, soma;

            soma = 0;

            n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {

                string[] vetor = Console.ReadLine().Split(' ');
                int a = int.Parse(vetor[0]);
                int b = int.Parse(vetor[1]);


                if (a > b)
                {
                    maior = a;
                    menor = b;
                }
                else
                {
                    maior = b;
                    menor = a;
                }



                for (int c = menor; c < maior; c++)
                {
                    if (c % 2 != 0 && c > menor)
                    {
                        soma = soma + c;
                    }

                }



                Console.WriteLine(soma);
                soma = 0;
            }
        }
    }
}
