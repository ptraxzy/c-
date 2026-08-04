using System;
using System.Collections.Generic;
using System.Text;

namespace pertemuan3
{
    internal class latihan5
    {
        static void Main()
        {
            string teks = " hello world ";
            Console.WriteLine(teks.Length);
            Console.WriteLine(teks.ToUpper());
            Console.WriteLine(teks.Substring(5));
            Console.WriteLine(teks.Replace("hello", "c#"));
        }
    }
}

