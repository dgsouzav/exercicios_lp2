using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lista04
{
    public class MinhaCLasseBase
    {

    }

    public class MinhaClasseDerivada : MinhaCLasseBase
    {

    }

    public class Program
    {
        public static void Main(string[] args)
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

            //// EndsWith
            //String[] strings = {"Essa é uma string.", "Ola!", "Nada.", "Ola mundo.", "Ola mundo cruel"};
            //foreach (var value in strings)
            //{
            //    bool endsInPeriod = value.EndsWith(".");
            //    Console.WriteLine("'{0}' termina em: {1}", value, endsInPeriod);
            //}

            // Equals
            //string[] threeIs = { "i", "ı", "I" };
            //Type scType = typeof(StringComparison);
            //Console.WriteLine("The current culture is {0}.\n",
            //                  System.Globalization.CultureInfo.CurrentCulture.Name);
            //foreach (string scName in Enum.GetNames(scType))
            //{
            //    StringComparison sc = (StringComparison)Enum.Parse(scType, scName);
            //    Console.WriteLine("Comparisons using {0}:", sc);
            //    for (int ctr = 0; ctr <= 1; ctr++)
            //    {
            //        string instanceChar = threeIs[ctr];
            //        for (int innerCtr = ctr + 1; innerCtr <= threeIs.GetUpperBound(0); innerCtr++)
            //        {
            //            string otherChar = threeIs[innerCtr];
            //            Console.WriteLine("{0} (U+{1}) = {2} (U+{3}): {4}",
            //                              instanceChar, Convert.ToInt16(Char.Parse(instanceChar)).ToString("X4"),
            //                              otherChar, Convert.ToInt16(Char.Parse(otherChar)).ToString("X4"),
            //                              instanceChar.Equals(otherChar, sc));
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //// GetType
            //MinhaCLasseBase minhaBase = new MinhaCLasseBase();
            //MinhaClasseDerivada minhaDerivada = new MinhaClasseDerivada();
            //object o = minhaDerivada;
            //MinhaCLasseBase b = minhaDerivada;
            //Console.WriteLine("minhaBase: o tipo é {0}", minhaBase.GetType());
            //Console.WriteLine("minhaDerivada: o tipo é {0}", minhaDerivada.GetType());
            //Console.WriteLine("objeto o = minhaDerivada: o tipo é {0}", o.GetType());
            //Console.WriteLine("MinhaClasseBase b = minhaDerivada: o tipo é {0}", b.GetType());

            //// Empty
            //string teste = "";
            //switch (teste)
            //{
            //    case "":
            //        Console.WriteLine("Case 1");
            //        break;
            //    case String.Empty:
            //        Console.WriteLine("Case 2");
            //        break;
            //}

            //// Insert
            //String original = "aaabbb";
            //Console.WriteLine("The original string: '{0}'", original);
            //String modified = original.Insert(3, " ");
            //Console.WriteLine("The modified string: '{0}'", modified);

            //// LastIndexOf
            //public static void Main()
            //{
            //    string filename;
            //    filename = ExtractFilename(@"C:\temp\");
            //    Console.WriteLine("{0}", String.IsNullOrEmpty(filename) ? "<none>" : filename);
            //    filename = ExtractFilename(@"C:\temp\delegate.txt");
            //    Console.WriteLine("{0}", String.IsNullOrEmpty(filename) ? "<none>" : filename);
            //    filename = ExtractFilename("delegate.txt");
            //    Console.WriteLine("{0}", String.IsNullOrEmpty(filename) ? "<none>" : filename);
            //    filename = ExtractFilename(@"C:\temp\notafile.txt");
            //    Console.WriteLine("{0}", String.IsNullOrEmpty(filename) ? "<none>" : filename);

            //}
            //public static string ExtractFilename(string filepath)
            //{
            //    if (filepath.Trim().EndsWith(@"\"))
            //        return String.Empty;

            //    int position = filepath.LastIndexOf('\\');
            //    if (position == -1)
            //    {
            //        if (File.Exists(Environment.CurrentDirectory + Path.DirectorySeparatorChar + filepath))
            //            return filepath;
            //        else
            //            return String.Empty;
            //    }
            //    else
            //    {
            //        if (File.Exists(filepath))
            //            return filepath.Substring(position + 1);
            //        else
            //            return String.Empty;
            //    }

            //// Remove
            //String str = "GeeksForGeeks";
            //Console.WriteLine("Given String : " + str);
            //Console.WriteLine("New String1 : " + str.Remove(5));
            //Console.WriteLine("New String2 : " + str.Remove(8));

            // Replace
            //String str = "Geeks For Geeks";
            //Console.WriteLine("OldString : " + str);
            //Console.WriteLine("NewString: " + str.Replace('s', 'G'));
            //Console.WriteLine("\nOldString: " + str);
            //Console.WriteLine("NewString: " + str.Replace('e', ' '));

            // StartsWith
            //string str = "https://www.geeksforgeeks.org/placement-guide/";
            //string[] m = new string[] {
            //"https://geeksforgeeks.org",
            //"https://www.geeksforgeeks.org",
            //"https://www.geeksforgeeks.org/placement"};
            //foreach (string s in m)
            //{
            //    if (str.StartsWith(s))
            //    {
            //        Console.WriteLine(s);
            //        return;
            //    }
            //}

            // ToLower
            //string str1 = "GeeksForGeeks";
            //string lowerstr1 = str1.ToLower();
            //Console.WriteLine(lowerstr1);

            // ToUpper
            //string str1 = "GeeksForGeeks";
            //string upperstr1 = str1.ToUpper();
            //Console.WriteLine(upperstr1);

            // ToString
            // short s1 = 15;
            //CultureInfo provider = new CultureInfo("en-us");
            //string str = s1.ToString(provider);
            //Console.WriteLine("The Value is {0} and provider is {1}",
            //                         str, provider.Name);


            //// string.IsNullOrEmpty
            //string s1 = "GeeksforGeeks";
            //string s2 = "";
            //string s3 = null;
            //bool b1 = string.IsNullOrEmpty(s1);
            //bool b2 = string.IsNullOrEmpty(s2);
            //bool b3 = string.IsNullOrEmpty(s3);
            //Console.WriteLine(b1);
            //Console.WriteLine(b2);
            //Console.WriteLine(b3);


            Console.ReadKey();
        }
    }
}
