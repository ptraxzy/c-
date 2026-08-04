using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan1
{
    internal class tugas2
    {
        static void Main(string[] args)
        {
            // Meminta panjang dan lebar dari pengguna
            Console.Write("Masukkan panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar: ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            // Menghitung luas dan keliling persegi panjang
            double luas = panjang * lebar;
            double keliling = 2 * (panjang + lebar);

            // Menampilkan hasil perhitungan
            Console.WriteLine("Luas = " + luas);
            Console.WriteLine("Keliling = " + keliling);
        }
    }
}
