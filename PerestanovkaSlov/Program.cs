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
        static string[] SplitText(string text)
        {
            string[] splittext = text.Split(' ');
            string Text1 = ReverseWord(splittext);
            return Text1;
        }
        static string[] ReverseWord(string[] text)
        {
            Array.Reverse(text);
            string s = string.Join(" ", text);
            return s;
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
