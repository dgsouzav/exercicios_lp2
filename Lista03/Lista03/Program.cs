using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    internal class Program
    {
        static void Ex01(string[] args)
        {
            Console.WriteLine("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            float[] numeros = new float[n];
            float menor = float.MinValue;
            float maior = float.MaxValue;
            float soma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "° numero");
                numeros[i] = float.Parse(Console.ReadLine());

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }

                soma = numeros[i];
            }
            float media = soma / n;

            Console.WriteLine("Menor numero: " + menor);
            Console.WriteLine("Maior numero: " + maior);
            Console.WriteLine("Media aritimetica: " + media);

            Console.ReadKey();
        }

        static void Ex02(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("O valor deve ser maior que zero!");
                Console.WriteLine("Digite um valor");
                n = int.Parse(Console.ReadLine());
            }

            float[] numeros = new float[n];
            float soma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número: ");
                numeros[i] = float.Parse(Console.ReadLine());
                soma += numeros[i];
            }

            float media = soma / n;
            Console.WriteLine("\nNumeros maiores ou iguais as medias");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadKey();
        }

        static void Ex03(string[] args)
        {
            Console.WriteLine("Digite o tamanho do vetor:");
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                vetor[i] = rand.NextDouble() * 100;
            }

            double media = 0;
            for (int i = 0; i < n; i++)
            {
                media += vetor[i];
            }
            media /= n;

            Console.WriteLine("Números maiores ou iguais à média:");
            for (int i = 0; i < n; i++)
            {
                if (vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
            Console.ReadKey();
        }

        static void Ex04(string[] args)
        {

        }

    }

}
