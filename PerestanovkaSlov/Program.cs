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
        static string ReverseWord(string text)
        {
            char[] words1 = text.ToCharArray();
            Array.Reverse(words1);
            return new string(words1);
        }
        static string[] SplitText(string text)
        {
            string[] words = text.Split(new char[] { ' ' });
            return words;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] result = text.Split(new char[] { ' ' });
            string words = ReverseWord(text);

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(words);
            Console.ReadLine();
        }
    }
}
