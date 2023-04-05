using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrokiNaSlova
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' });

            foreach (string str in words)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
