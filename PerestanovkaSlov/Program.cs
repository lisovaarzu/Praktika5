using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PerestanovkaSlov
{
    internal class Program
    {
        static string ReverseWord(string[] text)
        {
            Array.Reverse(text);
            string str = string.Join(" ", text);
            return str;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' });
            string text2 = ReverseWord(words);

            foreach (string str in words)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
