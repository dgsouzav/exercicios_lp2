using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    class Program
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
            string[,] matriz = new string[3, 3];
            string turno = "X";

            List<string> IndexNumeros = new List<string>(); { };


            int index = 1;

            int tentativas = 1;

            Console.WriteLine(" --JOGO DA VELHA-- ");

            //  alimentando a matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = index.ToString();
                    IndexNumeros.Add(index.ToString());
                    index++;
                }
            }
            // imprimir a matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++) ;
                {
                    Console.WriteLine($" [{matriz[i, j]}] ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write($"quer jogar [{turno}] em qual posiçao?")

            string jogada = Console.ReadLine();

            Console.Clear();

            // começa o jogo
            while (tentativas < 9)
            {
                Console.WriteLine(" --JOGO DA VELHA-- ");

                // substituir o valor na sua respectiva casa
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int i = 0; j < matriz.GetLength(1); j++)
                    {
                        if (matriz[i, j] == jogada && IndexNumeros.Contains(jogada))
                        {
                            matriz[i, j] = turno;
                            IndexNumeros.Remove(jogada);
                        }
                    }
                }

                // imprimir a matriz
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++) ;
                    {
                        Console.WriteLine($" [{matriz[i, j]}] ");
                    }
                    Console.WriteLine();
                }

                // jogar as posicoes nas matrizes
                if (turno == "X")
                {
                    turno = "O";
                }
                else
                {
                    turno = "X";
                }


                // vitoria nas diagonais
                if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] ||
                    matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                {
                    Console.WriteLine();
                    Console.WriteLine("fim de jogo")
                        Console.WriteLine($"O jogador [{turno}] venceu!");
                    break;
                }

                // vitoria nas linhas
                if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] ||
                    matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] ||
                    matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2]
                    )
                {
                    Console.WriteLine();
                    Console.WriteLine("fim de jogo")
                        Console.WriteLine($"O jogador [{turno}] venceu!");
                    break;
                }

                // vitoria nas colunas
                if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] ||
                    matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
                    matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2]
                    )
                {
                    Console.WriteLine();
                    Console.WriteLine("fim de jogo")
                        Console.WriteLine($"O jogador [{turno}] venceu!");
                    break;
                }

                Console.WriteLine();
                Console.Write($"voce quer jogar [{turno}] em qual posiçao?")

                jogada= Console.ReadLine();

                // condicao de posicao invalida
                while (!IndexNumeros.Contains(turno))
                {
                    Console.Write("Posição inválida");
                    Console.WriteLine();
                    Console.Write($"voce quer jogar [{turno}] em qual posiçao?")

                    jogada = Console.ReadLine();
                }

                tentativas++;

                Console.Clear();
            }

            // empate ou derrota
            if (tentativas == 9)
            {
                Console.WriteLine();
                Console.WriteLine("fim de jogo, ninguem ganhou")
            }

        }

            // menu 
            static void Main(string[] args)
            {
                Console.WriteLine("Escolha o exercicio:");
                Console.WriteLine("1 - Ex01");
                Console.WriteLine("2 - Ex02");
                Console.WriteLine("3 - Ex03");
                Console.WriteLine("4 - Ex04");

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
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }

            }
    }
}