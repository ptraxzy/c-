using System;
using System.Collections.Generic;
using System.Text;

namespace pertemuan3
{
    internal class latihan9
    {
        static void Main(string[] args)
        {
            string hari = "minggu";

            switch (hari)
            {
                case "minggu":
                    Console.WriteLine("awal minggu");
                    break;
                case "jumat":
                    Console.WriteLine(" hampir weekend");
                    break;
                default:
                    Console.WriteLine("Akhir weekend");
                    break;
            }
        }
    }
}
