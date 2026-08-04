using System;
using System.Collections.Generic;
using System.Text;

namespace pertemuan3
{
    internal class latihan16
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if(i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
