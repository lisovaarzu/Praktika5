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
        static string SplitText(string text)
        {
            string[] words = text.Split(new char[] { ' ' });
            string Text1 = ReverseWord(words);
            return Text1;
        }
        static string ReverseWord(string[] text)
        {
            Array.Reverse(text);
            string str = string.Join(" ", text);
            return str;
        }
        static void Main(string[] args)
        {
            string text2 = Console.ReadLine();
            string[] result = text2.Split(new char[] { ' ' });
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
