﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrokiNaSlova
{
    class Program
    {
        static string[] SplitText(string text)
        {
            string[] words = text.Split(new char[] { ' ' });
            return words;
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] result = SplitText(text);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}