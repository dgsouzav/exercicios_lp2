using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    class Ex01
    {
        static void Main(string[] args)
        {
            double salarioMinimo, salarioPessoa, salarioLiquido;
            const double DESCONTO_INSS = 0.085; // 8,5%

            Console.Write("Digite o valor do salário-mínimo atual: ");
            salarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do salário da pessoa: ");
            salarioPessoa = double.Parse(Console.ReadLine());

            salarioLiquido = salarioPessoa - (salarioPessoa * DESCONTO_INSS);
            double salariosMinimos = salarioLiquido / salarioMinimo;

            Console.WriteLine("A pessoa ganha {0:f2} salários-mínimos líquidos.", salariosMinimos);
        }
    }

    class Ex02 
    {
        static void Main(string[] args)
        {
            double metros, centimetros, milimetros;

            Console.Write("Digite um valor em metros: ");
            metros = double.Parse(Console.ReadLine());

            centimetros = metros * 100;
            milimetros = metros * 1000;

            Console.WriteLine("{0} metros correspondem a {1} centímetros e {2} milímetros.", metros, centimetros, milimetros);
        }
    }

    class Ex03
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor em graus Fahrenheit: ");
            float fahrenheit = float.Parse(Console.ReadLine());

            float celsius1 = (fahrenheit - 32.0f) * (5.0f/9.0f);

            Console.WriteLine("O valor em graus Celsius é: " + celsius1);

            int fahrenheit2 = (int)fahrenheit;
            int celsius2 = (fahrenheit2 - 32) * (5/9);

            Console.WriteLine("O valor em graus Celsius é: " + celsius2);
        }
    }

    class Ex04
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu peso em quilogramas: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Seu peso está dentro da faixa ideal.");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Você está com sobrepeso.");
            }
            else
            {
                Console.WriteLine("Você está com obesidade.");
            }
        }
    }

    class Ex05
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            double numero3 = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso do primeiro número: ");
            double peso1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso do segundo número: ");
            double peso2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso do terceiro número: ");
            double peso3 = double.Parse(Console.ReadLine());

            double somaPesos = peso1 + peso2 + peso3;
            double mediaPonderada = (numero1 * peso1 + numero2 * peso2 + numero3 * peso3) / somaPesos;

            Console.WriteLine("A média ponderada é: " + mediaPonderada.ToString("F2"));
        }
    }

    class Ex06
    {
        static void Main(string[] args)
        {
            // Ler a distância percorrida
            Console.Write("Digite a distância percorrida (em metros): ");
            double distancia = double.Parse(Console.ReadLine());

            // Ler o tempo gasto
            Console.Write("Digite o tempo gasto (em segundos): ");
            double tempo = double.Parse(Console.ReadLine());

            // Calcular a velocidade média
            double velocidade = distancia / tempo;

            // Imprimir o resultado
            Console.WriteLine("A velocidade média é: " + velocidade.ToString("F2") + " m/s");
        }
    }

    class Ex07
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário atual do funcionário: ");
            double salarioAtual = double.Parse(Console.ReadLine());

            double novoSalario = salarioAtual * 1.337;

            Console.WriteLine("O novo salário do funcionário é: " + novoSalario.ToString("C"));
        }
    }

    class Ex08
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor em reais: ");
            double valorEmReais = double.Parse(Console.ReadLine());

            Console.Write("Digite a cotação do dólar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            double valorEmDolares = valorEmReais / cotacaoDolar;

            Console.WriteLine("O valor correspondente em dólares é: " + valorEmDolares.ToString("C"));
        }
    }
    class Ex09
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            int antecessorTriplo = (3 * numero) - 1;
            int sucessorDobro = (2 * numero) + 1;
            int resultado = antecessorTriplo + sucessorDobro;

            Console.WriteLine("A soma do antecessor do triplo com o sucessor do dobro é: " + resultado);
        }
    }
    class Ex10
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro de 4 dígitos: ");
            int numero = int.Parse(Console.ReadLine());

            int d1 = numero / 1000;
            int d2 = (numero / 100) % 10;
            int d3 = (numero / 10) % 10;
            int d4 = numero % 10;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
        }
    }
    class Ex11
    {

    }
}
