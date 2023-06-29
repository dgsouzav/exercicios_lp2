using System;
using System.Collections.Generic;
using System.IO;

/* Trabalho prático da disciplina de Lingugem de Programação 2 - IFSP
 * Aluno: Diogo Souza.
 * Professor: Marques
 * 
 * REQUISITOS:
 *  Realizar validação em relação aos campos de entrada de dados (está ou não escolhendo uma posição que não existe);
 *  Permitir jogar com 2 jogadores (jogador1 x jogador2);
 *  Permitir jogar contra o computador;
 *  Armazenar ranking dos 10 jogadores com mais partidas vencidas;
 *  Permitir jogo com jogador cadastrado ou não (caso o jogador seja cadastrado, ele participará do ranking);
 *  Permitir cadastro de jogador com nome e cpf (validado) na plataforma do jogo;
 *  Manter o ranking e cadastro de jogadores permanentemente em memória secundária (use arquivos);
 */

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            JogoDaVelha jogo = new JogoDaVelha();
            int opcao;
            do
            {
                Console.WriteLine("******* JOGO DA VELHA *******");
                Console.WriteLine();
                Console.WriteLine("1 - Cadastrar jogador");
                Console.WriteLine("2 - Exibir jogadores cadastrados");
                Console.WriteLine("3 - Jogar contra jogador");
                Console.WriteLine("4 - Jogar contra computador");
                Console.WriteLine("5 - Ver ranking");
                Console.WriteLine("0 - Sair");
                Console.WriteLine();
                Console.WriteLine("Informe a opção desejada:");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        jogo.CadastrarJogador();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        jogo.ExibirJogadoresCadastrados();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        jogo.JogarContraJogador();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        jogo.JogarContraComputador();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        jogo.VerRanking();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por jogar!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 0);
        }
    }

    class JogoDaVelha
    {
        private char[,] tabuleiro;
        private bool jogadorAtual;
        private List<Jogador> jogadores;
        private int linha = 3;
        private int coluna = 3;


        private void InicializarJogo()
        {
            // Inicializar o tabuleiro
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    tabuleiro[i, j] = ' ';
                }
            }
        }

        public JogoDaVelha()
        {
            // Carregar dados do arquivo
            jogadores = new List<Jogador>();
            if (File.Exists("jogadores.txt"))
            {
                using (StreamReader arquivo = File.OpenText("jogadores.txt"))
                {
                    while (!arquivo.EndOfStream)
                    {
                        string linha = arquivo.ReadLine();
                        string[] campos = linha.Split(',');
                        int vitorias;
                        if (int.TryParse(campos[2], out vitorias))
                        {
                            jogadores.Add(new Jogador(campos[0], campos[1], vitorias));
                        }

                    }
                }
            }

            // Inicializar o jogo
            tabuleiro = new char[3, 3];
            jogadorAtual = true;
        }

        public void CadastrarJogador()
        {
            // Pedir nome e CPF do jogador
            Console.WriteLine("Informe seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe seu CPF:");
            string cpf = Console.ReadLine();

            // Verificar se o jogador já existe
            if (jogadores.Exists(j => j.Nome == nome))
            {
                Console.WriteLine();
                Console.WriteLine("Jogador já cadastrado!");
            }
            else
            {
                // Validar o CPF
                if (ValidarCpf(cpf))
                {
                    // Adicionar o jogador na lista
                    jogadores.Add(new Jogador(nome, cpf, 0));

                    // Salvar os dados no arquivo
                    using (StreamWriter arquivo = File.AppendText("jogadores.txt"))
                    {
                        arquivo.WriteLine($"{nome},{cpf},0");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Jogador cadastrado com sucesso!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("CPF inválido! Tente novamente.");
                    Console.WriteLine();
                }
            }
        }

        private bool ValidarCpf(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", ""); // Remover pontos e traços
            if (cpf.Length != 11)
            {
                return false;
            }

            // Calcular os dígitos verificadores
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }
            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            }
            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            // Verificar se os dígitos verificadores estão corretos
            return cpf.EndsWith($"{digito1}{digito2}");
        }

        public void ExibirJogadoresCadastrados()
        {
            Console.WriteLine("Jogadores cadastrados:");
            Console.WriteLine("======================");

            foreach (Jogador j in jogadores)
            {
                Console.WriteLine($"Nome: {j.Nome}");
                Console.WriteLine($"CPF: {j.CPF}");
                Console.WriteLine("----------------------");
            }
        }


        public void JogarContraJogador()
        {
            // Pedir nomes dos jogadores
            Console.WriteLine("Jogador 1, informe seu nome:");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Jogador 2, informe seu nome:");
            string nome2 = Console.ReadLine();

            // Inicializar o jogo
            InicializarJogo();

            // Realizar jogadas até o fim do jogo
            while (!VerificarFimDeJogo())
            {
                // Exibir o tabuleiro
                ExibirTabuleiro();

                // Pedir a jogada do jogador atual
                Console.WriteLine($"Vez de {(jogadorAtual ? nome1 : nome2)}:");
                int linha, coluna;
                do
                {
                    Console.WriteLine("Informe a linha (1 a 3):");
                    linha = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Informe a coluna (1 a 3):");
                    coluna = int.Parse(Console.ReadLine()) - 1;

                    // Verificar se a jogada é válida
                    if (!VerificarJogadaValida(linha, coluna))
                    {
                        Console.WriteLine("Jogada inválida! Tente novamente.");
                    }
                } while (!VerificarJogadaValida(linha, coluna));

                // Realizar a jogada
                RealizarJogada(linha, coluna);

                // Passar a vez para o outro jogador
                jogadorAtual = !jogadorAtual;
            }

            // Exibir o resultado do jogo
            ExibirResultado();

            // Atualizar o ranking
            AtualizarRanking(nome1, nome2);
        }

        private void RealizarJogadaComputador(int jogador, out int linha, out int coluna)
        {
            // Gerar números aleatórios até encontrar uma posição vazia
            Random r = new Random();
            do
            {
                linha = r.Next(0, 3);
                coluna = r.Next(0, 3);
            } while (tabuleiro[linha, coluna] != ' ');

            // Se o jogador atual é o X, marca a posição com O, e vice-versa
            int jogada = jogador == 1 ? 2 : 1;
            tabuleiro[linha, coluna] = (char)jogada;
        }

        public void JogarContraComputador()
        {
            // Pedir nome do jogador
            Console.WriteLine("Jogador, informe seu nome:");
            string nome = Console.ReadLine();

            // Inicializar o jogo
            InicializarJogo();

            // Realizar jogadas até o fim do jogo
            while (!VerificarFimDeJogo())
            {
                // Exibir o tabuleiro
                ExibirTabuleiro();

                // Pedir a jogada do jogador atual
                Console.WriteLine($"Vez de {(jogadorAtual ? nome : "Computador")}:");
                int linha, coluna;
                if (jogadorAtual)
                {
                    do
                    {
                        Console.WriteLine("Informe a linha (1 a 3):");
                        linha = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("Informe a coluna (1 a 3):");
                        coluna = int.Parse(Console.ReadLine()) - 1;

                        // Verificar se a jogada é válida
                        if (!VerificarJogadaValida(linha, coluna))
                        {
                            Console.WriteLine("Jogada inválida! Tente novamente.");
                        }
                    } while (!VerificarJogadaValida(linha, coluna));
                }
                else
                {
                    // Realizar a jogada
                    RealizarJogadaComputador(jogadorAtual ? 2 : 1, out linha, out coluna);
                }

                // Realizar a jogada
                RealizarJogada(linha, coluna);

                // Passar a vez para o outro jogador
                jogadorAtual = !jogadorAtual;
            }

            // Exibir o resultado do jogo
            ExibirResultado();

            // Atualizar o ranking
            AtualizarRanking(nome, "Computador");
        }

        private void ExibirTabuleiro()
        {
            Console.Clear();
            // Exibir o tabuleiro
            Console.WriteLine("  1 2 3");
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                Console.Write($"{i + 1} ");
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    Console.Write($"{tabuleiro[i, j]}{(j == tabuleiro.GetLength(1) - 1 ? "" : "|")}");
                }
                Console.WriteLine();
            }
        }

        private void RealizarJogada(int linha, int coluna)
        {
            // Realizar a jogada
            tabuleiro[linha, coluna] = jogadorAtual ? 'X' : 'O';
        }

        private bool VerificarJogadaValida(int linha, int coluna)
        {
            // Verificar se a posição está dentro do tabuleiro
            if (linha < 0 || linha >= tabuleiro.GetLength(0) || coluna < 0 || coluna >= tabuleiro.GetLength(1))
            {
                return false;
            }

            // Verificar se a posição está vazia
            return tabuleiro[linha, coluna] == ' ';
        }

        public int VerificarVencedor()
        {
            // Verificar se houve vencedor
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                if (tabuleiro[i, 0] != ' ' && tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
                {
                    return tabuleiro[i, 0] == 'X' ? 1 : 2;
                }
            }
            for (int j = 0; j < tabuleiro.GetLength(1); j++)
            {
                if (tabuleiro[0, j] != ' ' && tabuleiro[0, j] == tabuleiro[1, j] && tabuleiro[1, j] == tabuleiro[2, j])
                {
                    return tabuleiro[0, j] == 'X' ? 1 : 2;
                }
            }
            if (tabuleiro[0, 0] != ' ' && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
            {
                return tabuleiro[0, 0] == 'X' ? 1 : 2;
            }
            if (tabuleiro[0, 2] != ' ' && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
            {
                return tabuleiro[0, 2] == 'X' ? 1 : 2;
            }

            // Verificar se houve empate
            bool empate = false;
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    if (tabuleiro[i, j] == ' ')
                    {
                        empate = true;
                        break;
                    }
                }
                if (empate)
                {
                    break;
                }
            }
            if (!empate)
            {
                return 0; // empate
            }
            return -1;
        }

        private bool VerificarFimDeJogo()
        {
            // Verificar se houve vitória
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                if (tabuleiro[i, 0] != ' ' && tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
                {
                    return true;
                }
            }
            for (int j = 0; j < tabuleiro.GetLength(1); j++)
            {
                if (tabuleiro[0, j] != ' ' && tabuleiro[0, j] == tabuleiro[1, j] && tabuleiro[1, j] == tabuleiro[2, j])
                {
                    return true;
                }
            }
            if (tabuleiro[0, 0] != ' ' && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
            {
                return true;
            }
            if (tabuleiro[0, 2] != ' ' && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
            {
                return true;
            }

            // Verificar se houve empate
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    if (tabuleiro[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void ExibirResultado()
        {
            // Exibir o tabuleiro
            ExibirTabuleiro();

            // Exibir o resultado
            if (VerificarVencedor() == 1)
            {
                Console.WriteLine("Jogador 1 venceu!");
            }
            else if (VerificarVencedor() == 2)
            {
                Console.WriteLine("Jogador 2 venceu!");
            }
            else
            {
                Console.WriteLine("Empate!");
            }
        }

        private void AtualizarRanking(string nome1, string nome2)
        {
            // Atualizar o ranking
            Jogador jogador1 = jogadores.Find(j => j.Nome == nome1);
            Jogador jogador2 = jogadores.Find(j => j.Nome == nome2);
            if (jogador1 != null)
            {
                int vitorias = Convert.ToInt32(jogador1.Vitorias);
                jogador1.Vitorias = vitorias + 1;
            }

            else if (jogador2 != null)
            {
                int vitorias = Convert.ToInt32(jogador2.Vitorias);
                jogador1.Vitorias = vitorias + 1;
            }


            // Salvar os dados no arquivo
            using (StreamWriter arquivo = File.CreateText("jogadores.txt"))
            {
                foreach (Jogador j in jogadores)
                {
                    arquivo.WriteLine($"{j.Nome},{j.CPF},{j.Vitorias}");
                }
            }
        }

        public void VerRanking()
        {
            // Ordenar os jogadores por número de vitórias
            jogadores.Sort((j1, j2) => Convert.ToInt32(j2.Vitorias) > Convert.ToInt32(j1.Vitorias) ? 1 : Convert.ToInt32(j2.Vitorias) < Convert.ToInt32(j1.Vitorias) ? -1 : 0);

            Console.Clear();

            // Exibir o ranking
            Console.WriteLine("Ranking dos 10 jogadores com mais partidas vencidas:");
            Console.WriteLine();
            Console.WriteLine("Posição\tNome\t\t\tVitórias");
            Console.WriteLine();
            for (int i = 0; i < Math.Min(jogadores.Count, 10); i++)
            {
                Console.WriteLine($"{i + 1}\t{jogadores[i].Nome}\t\t\t{jogadores[i].Vitorias}");
            }
        }            
    }

    class Jogador
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public object Vitorias { get; internal set; }
        public string V1 { get; }
        public string V2 { get; }
        public string V3 { get; }

        public Jogador(string nome, string cpf, int v)
        {
            Nome = nome;
            CPF = cpf;
        }

        public Jogador(string v1, string v2, string v3)
        {
            V1=v1;
            V2=v2;
            V3=v3;
        }
    }
}
