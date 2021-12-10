using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ochorna_danych
{
    internal class Program
    {
        public static char szyfr(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }


        public static string szyfrowanie(string input, int klucz)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += szyfr(ch, klucz);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return szyfrowanie(input, 26 - key);
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Wpisz tekst do zaszyfrowania: ");
            string tekst = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Write("Wpisz klucz: ");
            int klucz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Zaszyfrowany tekst: ");

            string TekstCezara = szyfrowanie(tekst, klucz);
            Console.WriteLine(TekstCezara);
            Console.Write("\n");

            Console.WriteLine("Odszyfrowany tekst: ");

            string t = Decipher(TekstCezara, klucz);
            Console.WriteLine(t);
            Console.Write("\n");
            Console.ReadKey();

        }
    }
}
