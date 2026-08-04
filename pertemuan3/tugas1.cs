using System;
using System.Collections.Generic;
using System.Text;

namespace pertemuan3
{
    internal class tugas1
    {
        // harga tiket
        const int Harga_reguler = 40000;
        const int Harga_premium = 60000;
        const string Nama_bioskop = "studio gamodal";
        const string diskon_pelajar_str = "diskon untuk pelajar 10%";
        const double diskon_pelajar = 0.10;   // 10%

        static void Main(string[] args)
        {
            double TotalBelanja = 0;
            int JumlahTransaksi = 0;
            // ditaruh di sini, jangan di dalam while nanti kereset

            while (true)
            {
                // input
                Console.Write("nama pembeli: ");
                string nama = Console.ReadLine();

                Console.Write("jenis tiket (reguler/premium): ");
                string jenis = Console.ReadLine().Trim().ToLower();

                // validasi jenis tiket
                if (jenis != "reguler" && jenis != "premium")
                {
                    Console.WriteLine("jenis tiket tidak valid.");
                    continue;
                }

                Console.Write("jumlah tiket: ");
                int jumlah = 0;
                bool berhasil = int.TryParse(Console.ReadLine(), out jumlah);   // anti crash kalau diisi huruf

                if (!berhasil || jumlah <= 0)
                {
                    Console.WriteLine("jumlah tiket tidak valid.");
                    continue;
                }

                Console.Write("pelajar atau bukan? (y/n): ");
                string jawab = Console.ReadLine().Trim().ToLower();
                bool isPelajar = (jawab == "y");

                // tentukan harga satuan
                int harga = 0;
                if (jenis == "reguler")
                {
                    harga = Harga_reguler;
                }
                else
                {
                    harga = Harga_premium;
                }

                // hitung
                double subtotal = harga * jumlah;

                if (isPelajar)
                {
                    double potongan = subtotal * diskon_pelajar;
                    subtotal = subtotal - potongan;
                    Console.WriteLine("Anda mendapat " + diskon_pelajar_str);
                }

                subtotal = Math.Round(subtotal);

                // cetak struk
                Console.WriteLine("--- STRUK " + Nama_bioskop.ToUpper() + " ---");
                Console.WriteLine("Nama     : " + nama);
                Console.WriteLine("Tiket    : " + jenis);
                Console.WriteLine("Jumlah   : " + jumlah);
                Console.WriteLine("Subtotal : Rp" + subtotal);

                TotalBelanja = TotalBelanja + subtotal;
                JumlahTransaksi++;

                Console.Write("beli lagi? (y/n): ");
                string lagi = Console.ReadLine().Trim().ToLower();

                if (lagi != "y")
                {
                    break;   // keluar loop
                }

                Console.WriteLine();
            }

            // rekap
            Console.WriteLine("=================================");
            Console.WriteLine("Jumlah transaksi : " + JumlahTransaksi);
            Console.WriteLine("Total bayar      : Rp" + TotalBelanja);
            Console.WriteLine("Terima kasih telah membeli di " + Nama_bioskop);
            Console.ReadKey();   // biar gak langsung ketutup
        }
    }
}