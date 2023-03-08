using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// length
            //string letras = "abcdefghijklmnopqrstuvwxyz";
            //Console.WriteLine(letras.Length); // exibe o tamanho da string


            //// ToCharArray
            //string letras = "abcdefghijklmnopqrstuvwxyz";
            //char[] chars = letras.ToCharArray();

            //Console.WriteLine("String letras: {0}", letras);  // exibe a string
            //Console.WriteLine("Array:"); // exibe o array
            //for (int ctr = 0; ctr < chars.Length; ctr++) 
            //{
            //    Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
            //}

            //// Trim
            //char[] charToTrim = { '*', ' ', '\'' };
            //string banner = "***** Olá mundo *****";
            //string resultado = banner.Trim(charToTrim); // remove os caracteres especificados

            //Console.WriteLine("'{0}' -> '{1}'", banner, resultado); // exibe o resultado
            //Console.ReadLine();

            //// SubString
            //string[] info = { "Nome: Joao", "Idade: 18", "Profissao: Pedreiro", "Salario: R$15"};

            //int found = 0;

            //Console.WriteLine("O inicio do array é: ");
            //foreach (string s in info)
            //{
            //    Console.WriteLine("   {0}", s);
            //}

            //Console.WriteLine("Apenas informacoes");
            //foreach (string s in info)
            //{
            //    found = s.IndexOf(":");
            //    if (found > 0)
            //    {
            //        Console.WriteLine("   {0}", s.Substring(found + 1));
            //    }
            //}

            //// Split
            //string frase = "O rato roeu a roupa do rei de roma";

            //string[] strings = frase.Split(new char[] { ' ' });
            //Console.WriteLine(strings[0]);
            //Console.WriteLine(strings[1]);
            //Console.WriteLine(strings[2]);
            //Console.WriteLine(strings[3]);
            //Console.WriteLine(strings[4]);
            //Console.WriteLine(strings[5]);
            //Console.WriteLine(strings[6]);
            //Console.WriteLine(strings[7]);
            //Console.WriteLine(strings[8]);

            //// Contains
            //string frase = "O rato roeu a roupa do rei de roma";
            //string palavra = "rei";
            //bool resultado = frase.Contains(palavra);
            //Console.WriteLine("'{1}' está na string '{0}': {2}", frase, palavra, resultado);


            //if(resultado)
            //{
            //    int posicao = frase.IndexOf(palavra);
            //    if(posicao > 0)
            //    {
            //        Console.WriteLine("'{0}' está na posição {1} da string", palavra, posicao + 1);
            //    }
            //}

            // EndsWith
            String[] strings = {"Essa é uma string.", "Ola!", "Nada.", "Ola mundo.", "Ola mundo cruel"};

            foreach (var value in strings)
            {
                bool endsInPeriod = value.EndsWith(".");
                Console.WriteLine("'{0}' termina em: {1}", value, endsInPeriod);
            }


            Console.ReadKey();
        }
    }
}
