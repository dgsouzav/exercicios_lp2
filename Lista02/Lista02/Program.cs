using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02
{
    public class Program
    {
        static void Ex01(string[] args)
        {
            int[] valores = new int[172];
            int menor = int.MaxValue;
            int maior = int.MinValue;
            int somaParesMenoresCem = 0;
            int quantidadeParesMenoresCem = 0;

            Random random = new Random();
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = random.Next(23, 9569);

                if (valores[i] < menor)
                {
                    menor = valores[i];
                }
                if (valores[i] > maior)
                {
                    maior = valores[i];
                }

                if (valores[i] % 2 == 0 && valores[i] < 100)
                {
                    somaParesMenoresCem += valores[i];
                    quantidadeParesMenoresCem++;
                }
            }

            double mediaParesMenoresCem = 0;
            if (quantidadeParesMenoresCem > 0)
            {
                mediaParesMenoresCem = (double)somaParesMenoresCem / quantidadeParesMenoresCem;
            }

            Console.WriteLine("Menor valor encontrado: " + menor);
            Console.WriteLine("Maior valor encontrado: " + maior);
            Console.WriteLine("Média aritmética dos valores pares e menores que 100: " + mediaParesMenoresCem);
        }

        static void Ex02(string[] args)
        {
            int quantidade = 0;
            int soma = 0;

            Console.WriteLine("Digite uma sequência de números. Para encerrar, digite um número negativo.");

            while (true)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    break;
                }

                quantidade++;
                soma += numero;
            }

            double media = 0;
            if (quantidade > 0)
            {
                media = (double)soma / quantidade;
            }

            Console.WriteLine("A média dos números digitados é: " + media);
        }

        static void Ex03(string[] args)
        {
            Console.WriteLine("Digite os valores de X e Y (separados por espaço):");
            string[] valores = Console.ReadLine().Split(' ');

            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            Console.WriteLine("Os números com resto 3 ou 5 ao dividir por 7 são:");

            for (int i = x; i <= y; i++)
            {
                if (i % 7 == 3 || i % 7 == 5)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Ex04(string[] args)
        {
            Console.WriteLine("Digite um número positivo:");
            int p = int.Parse(Console.ReadLine());

            int quantidade = 0;
            int numero = 0;

            while (quantidade < p)
            {
                numero += 2;

                if (numero % 4 == 0 && numero % 6 != 0)
                {
                    Console.WriteLine(numero);
                    quantidade++;
                }
            }
        }

        static void Ex05(string[] args)
        {
            Console.WriteLine("Digite o número de linhas:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o caractere a ser utilizado:");
            char c = char.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }

        static void Ex06(string[] args)
        {
            Console.WriteLine("Digite o número de linhas:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o caractere a ser utilizado:");
            char c = char.Parse(Console.ReadLine());

            int espacos = n - 1;
            int caracteres = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= espacos; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= caracteres; j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                espacos--;
                caracteres += 2;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercício:");
            Console.WriteLine("1 - Ex01");
            Console.WriteLine("2 - Ex02");
            Console.WriteLine("3 - Ex03");
            Console.WriteLine("4 - Ex04");
            Console.WriteLine("5 - Ex05");
            Console.WriteLine("6 - Ex06");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Ex01(args);
                    break;
                case 2:
                    Ex02(args);
                    break;
                case 3:
                    Ex03(args);
                    break;
                case 4:
                    Ex04(args);
                    break;
                case 5:
                    Ex05(args);
                    break;
                case 6:
                    Ex06(args);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}

    //// menu
    //class Menu
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Escolha o exercício:");
    //        Console.WriteLine("1 - Ex01");
    //        Console.WriteLine("2 - Ex02");
    //        Console.WriteLine("3 - Ex03");
    //        Console.WriteLine("4 - Ex04");
    //        Console.WriteLine("5 - Ex05");
    //        Console.WriteLine("6 - Ex06");

    //        int opcao = int.Parse(Console.ReadLine());

    //        switch (opcao)
    //        {
    //            case 1:
    //                Ex01(args);
    //                break;
    //            case 2:
    //                Ex02(args);
    //                break;
    //            case 3:
    //                Ex03(args);
    //                break;
    //            case 4:
    //                Ex04(args);
    //                break;
    //            case 5:
    //                Ex05(args);
    //                break;
    //            case 6:
    //                Ex06(args);
    //                break;
    //            default:
    //                Console.WriteLine("Opção inválida!");
    //                break;
    //        }
    //    }
    //}