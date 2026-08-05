# Penjelasan Kode — Tugas 1 Bioskop

- **File:** `pertemuan3/tugas1.cs`
- **Bahasa:** C# (.NET 10, Console Application)
- **Menjalankan:** dari folder `pertemuan3`, jalankan `dotnet run`
  (`StartupObject` di `pertemuan3.csproj` sudah diarahkan ke `pertemuan3.tugas1`)

Tugas meminta memilih **6 materi** dari 10 materi yang sudah dipelajari, lalu
membuat satu program yang memanfaatkannya. Dokumen ini menjelaskan 6 materi yang
dipilih, di mana letaknya di kode, kenapa ditulis seperti itu, dan apa akibatnya
kalau tidak begitu.

---

## Daftar Isi

1. [Ringkasan Program](#ringkasan-program)
2. [6 Materi yang Dipilih](#6-materi-yang-dipilih)
3. [Materi 1 — Konstanta](#materi-1--konstanta)
4. [Materi 2 — Inputan dari Keyboard](#materi-2--inputan-dari-keyboard)
5. [Materi 3 — Casting](#materi-3--casting)
6. [Materi 4 — Kondisi](#materi-4--kondisi)
7. [Materi 5 — Perulangan](#materi-5--perulangan)
8. [Materi 6 — Break dan Continue](#materi-6--break-dan-continue)
9. [Alur Program](#alur-program)
10. [Jalannya Kode dari Atas ke Bawah](#jalannya-kode-dari-atas-ke-bawah)
11. [Contoh Hasil Program](#contoh-hasil-program)
12. [Kalimat untuk Presentasi](#kalimat-untuk-presentasi)

---

## Ringkasan Program

Program kasir tiket bioskop sederhana. Alurnya:

1. Menerima data pembelian dari keyboard: nama, jenis tiket, jumlah, status pelajar
2. Memvalidasi jenis dan jumlah tiket
3. Menghitung subtotal, memberi diskon 10% untuk pelajar
4. Mencetak struk
5. Mengulang transaksi sampai pembeli memilih berhenti
6. Menampilkan jumlah transaksi dan total pembayaran

---

## 6 Materi yang Dipilih

| # | Materi | Letak di `tugas1.cs` |
|---|---|---|
| 1 | **Konstanta** | baris 10–14 |
| 2 | **Inputan dari Keyboard** | baris 26, 29, 40, 49, 86 |
| 3 | **Casting** | baris 40 (`int.TryParse`), baris 64 (`int` → `double`) |
| 4 | **Kondisi** | baris 32, 42, 54–61, 66, 88 |
| 5 | **Perulangan** | baris 22 (`while (true)`) |
| 6 | **Break dan Continue** | baris 35, 45 (`continue`), baris 90 (`break`) |

> **Catatan kalau ditanya guru:** materi lain seperti *tipe data dan variabel*,
> *operator*, dan *boolean* memang ikut terlihat di kode — itu tidak bisa
> dihindari, karena program C# apa pun pasti butuh variabel dan operator. Tapi
> yang **sengaja dipilih dan dibahas** dalam tugas ini adalah 6 materi di atas.

---

## Materi 1 — Konstanta

**Apa itu:** variabel yang nilainya dikunci — tidak bisa diubah saat program
berjalan. Ditandai kata kunci `const`.

```csharp
const int Harga_reguler = 40000;                            // baris 10
const int Harga_premium = 60000;                            // baris 11
const string Nama_bioskop = "studio gamodal";               // baris 12
const string diskon_pelajar_str = "diskon untuk pelajar 10%"; // baris 13
const double diskon_pelajar = 0.10;                         // baris 14
```

**Kenapa dipakai:** harga tiket, nama bioskop, dan besaran diskon adalah data
tetap. Nilainya tidak boleh berubah di tengah program, jadi lebih aman dikunci
sebagai konstanta.

**Kenapa `0.10`, bukan `10`:** karena 10% dalam rumus adalah `10 / 100 = 0,10`.
Kalau ditulis `10`, diskonnya menjadi **10 kali harga**, bukan 10 persen.

**Kenapa ditulis di luar `Main` (baris 10–14):** supaya bisa dipakai di mana pun
di dalam class, dan supaya semua data tetap terkumpul rapi di satu tempat paling
atas — gampang dicari kalau harganya mau diubah.

> **Kalau tidak pakai konstanta:** angkanya ditulis langsung berulang-ulang,
> misalnya `subtotal = 40000 * jumlah;`. Begitu harga naik jadi 45.000, kamu
> harus mencari dan mengganti semua angka 40.000 di seluruh kode, dan satu saja
> yang terlewat, hasil hitungannya salah. Dengan konstanta, cukup ubah satu baris.

---

## Materi 2 — Inputan dari Keyboard

**Apa itu:** mengambil data yang diketik pengguna lewat `Console.ReadLine()`.
Pasangannya `Console.Write()` untuk menampilkan pertanyaannya.

```csharp
Console.Write("nama pembeli: ");                    // baris 25
string nama = Console.ReadLine();                   // baris 26

Console.Write("jenis tiket (reguler/premium): ");   // baris 28
string jenis = Console.ReadLine().Trim().ToLower(); // baris 29

bool berhasil = int.TryParse(Console.ReadLine(), out jumlah);  // baris 40

Console.Write("pelajar atau bukan? (y/n): ");       // baris 48
string jawab = Console.ReadLine().Trim().ToLower(); // baris 49
bool isPelajar = (jawab == "y");                    // baris 50
```

**`Write()` vs `WriteLine()`:** `Write()` tidak pindah baris, jadi jawaban
pengguna muncul di samping pertanyaan:

```
nama pembeli: Putra              ← pakai Write()

nama pembeli:                    ← pakai WriteLine()
Putra
```

**Kenapa ada `.Trim().ToLower()`:** merapikan input sebelum diperiksa.

| Method | Fungsi | Contoh |
|---|---|---|
| `Trim()` | membuang spasi di awal & akhir | `" premium "` → `"premium"` |
| `ToLower()` | menyeragamkan jadi huruf kecil | `"PREMIUM"` → `"premium"` |

> **Kalau tidak dirapikan:** pembeli mengetik `PREMIUM` atau tidak sengaja
> menekan spasi, inputnya dianggap berbeda dari `"premium"` lalu ditolak sebagai
> tidak valid — padahal maksudnya sudah benar.

**Kenapa nama pembeli tidak di-`Trim()`:** nama cuma dicetak ulang di struk,
tidak dibandingkan dengan apa pun, jadi bentuk aslinya tetap dipakai.

> **Catatan teknis:** saat di-`build`, compiler memberi *warning* CS8600/CS8602
> di baris 26, 29, 49, dan 86 karena `Console.ReadLine()` secara teori bisa
> bernilai `null` (misalnya kalau input ditutup paksa). Program tetap jalan
> normal saat dipakai lewat keyboard. Kalau ingin warning-nya hilang, tulis
> `Console.ReadLine() ?? ""` — tanda `??` artinya "kalau null, pakai teks kosong".

---

## Materi 3 — Casting

**Apa itu:** mengubah data dari satu tipe ke tipe lain. Di program ini ada dua
bentuk casting.

### a. Teks → angka (`int.TryParse`)

```csharp
Console.Write("jumlah tiket: ");                              // baris 38
int jumlah = 0;                                               // baris 39
bool berhasil = int.TryParse(Console.ReadLine(), out jumlah); // baris 40
```

Input dari keyboard **selalu** berupa `string`, padahal jumlah tiket harus
berupa `int` supaya bisa dikalikan. `int.TryParse()` mencoba mengubahnya, lalu
melaporkan berhasil atau tidak lewat `bool`. Hasil angkanya dikirim ke variabel
`jumlah` lewat kata kunci `out`.

| Yang diketik | `berhasil` | `jumlah` |
|---|---|---|
| `3` | `true` | `3` |
| `tiga` | `false` | `0` |
| `3.5` | `false` | `0` |

**Kenapa `TryParse`, bukan `int.Parse`:**

> `int.Parse("tiga")` membuat program **crash** dan langsung berhenti.
> `TryParse("tiga")` aman — ia cuma menghasilkan `false`, sehingga program
> sempat menampilkan pesan "jumlah tiket tidak valid" dan meminta ulang.

### b. Angka bulat → desimal (otomatis)

```csharp
double subtotal = harga * jumlah;   // baris 64
```

`harga` bertipe `int` dan `jumlah` bertipe `int`, tapi hasilnya disimpan ke
`double`. C# melakukan casting otomatis dari `int` ke `double` karena `double`
mampu menampung semua nilai `int`.

**Kenapa subtotalnya `double`, bukan `int`:** karena setelah dipotong diskon
10%, hasilnya bisa punya koma. `int` akan memotong bagian komanya, sehingga
totalnya meleset beberapa rupiah.

**Lalu kenapa masih ada `Math.Round` di baris 73:** supaya nominal yang dicetak
di struk tetap bulat dan rapi, tapi perhitungannya sendiri tetap dilakukan
dengan ketelitian penuh dulu.

---

## Materi 4 — Kondisi

**Apa itu:** menjalankan kode hanya jika syarat tertentu terpenuhi (`if`).

### a. Validasi jenis tiket

```csharp
if (jenis != "reguler" && jenis != "premium")   // baris 32
{
    Console.WriteLine("jenis tiket tidak valid.");
    continue;
}
```

| Simbol | Arti |
|---|---|
| `!=` | tidak sama dengan |
| `&&` | dan |

Maksudnya: *jika jenis tiket bukan reguler **dan** juga bukan premium, berarti
input salah.*

**Kenapa `&&`, bukan `||`:**

> Kalau ditulis `jenis != "reguler" || jenis != "premium"`, hasilnya **selalu
> benar**. Contohnya pembeli mengetik `reguler`: memang sama dengan reguler, tapi
> tetap "tidak sama dengan premium" — sehingga input yang benar pun ikut
> dianggap salah dan tidak ada transaksi yang bisa jalan.

### b. Validasi jumlah tiket

```csharp
if (!berhasil || jumlah <= 0)   // baris 42
{
    Console.WriteLine("jumlah tiket tidak valid.");
    continue;
}
```

| Simbol | Arti |
|---|---|
| `!berhasil` | input gagal diubah jadi angka |
| `\|\|` | atau |
| `<=` | kurang dari atau sama dengan |

Input ditolak kalau pembeli mengetik huruf, **atau** jumlahnya 0, **atau** minus.

> **Kalau validasi ini tidak ada:** pembeli bisa memasukkan `-2` tiket, dan
> subtotalnya jadi negatif — struknya seolah-olah bioskop membayar pembeli.

### c. Memilih harga (`if-else`)

```csharp
int harga = 0;                    // baris 53
if (jenis == "reguler")           // baris 54
{
    harga = Harga_reguler;        // baris 56
}
else                              // baris 58
{
    harga = Harga_premium;        // baris 60
}
```

**Kenapa aman memakai `else` untuk premium:** karena input selain
reguler/premium **sudah ditolak** di baris 32. Jadi saat sampai di baris ini,
isinya pasti salah satu dari dua itu.

Blok ini bisa dipersingkat jadi satu baris memakai ternary, hasilnya sama persis:

```csharp
int harga = jenis == "reguler" ? Harga_reguler : Harga_premium;
```

### d. Kondisi diskon

```csharp
if (isPelajar)                                              // baris 66
{
    double potongan = subtotal * diskon_pelajar;            // baris 68
    subtotal = subtotal - potongan;                         // baris 69
    Console.WriteLine("Anda mendapat " + diskon_pelajar_str); // baris 70
}
```

```
subtotal awal  = 80.000
potongan       = 80.000 × 0,10 = 8.000
subtotal akhir = 80.000 − 8.000 = 72.000
```

> **Kalau `if (isPelajar)` tidak ada:** semua pembeli mendapat potongan 10%,
> termasuk yang bukan pelajar, dan pemasukan bioskop berkurang terus.

---

## Materi 5 — Perulangan

**Apa itu:** mengulang blok kode berkali-kali. Di sini memakai `while`.

```csharp
while (true)   // baris 22
{
    // seluruh proses satu transaksi
}
```

**Kenapa syaratnya `true`:** `true` selalu benar, jadi perulangannya tidak
pernah berhenti sendiri — ia baru berhenti saat menemukan `break` di baris 90.
Bentuk ini dipilih karena kita **tidak tahu dari awal** pembeli akan
bertransaksi berapa kali; yang tahu hanya pembelinya sendiri, saat ditanya
"beli lagi?".

**Kenapa dua variabel ini ditulis di luar `while` (baris 18–19):**

```csharp
double TotalBelanja = 0;    // baris 18
int JumlahTransaksi = 0;    // baris 19
// ditaruh di sini, jangan di dalam while nanti kereset

while (true)                // baris 22
```

Supaya nilainya menumpuk dari transaksi ke transaksi.

> **Kalau ditaruh di dalam `while`:** setiap transaksi baru nilainya kembali nol,
> sehingga laporan akhir hanya menghitung transaksi yang terakhir saja — dua
> transaksi 72.000 dan 60.000 akan dilaporkan sebagai total 60.000.

---

## Materi 6 — Break dan Continue

**Apa itu:** dua perintah untuk mengendalikan jalannya perulangan.

| Perintah | Artinya |
|---|---|
| `continue` | batalkan sisa putaran ini, **kembali ke awal** perulangan |
| `break` | **keluar** dari perulangan sepenuhnya |

### `continue` — mengulang input yang salah

```csharp
continue;   // baris 35, saat jenis tiket tidak valid
continue;   // baris 45, saat jumlah tiket tidak valid
```

Ketika input salah, sisa proses (hitung harga, cetak struk) dilewati dan program
kembali menanyakan dari awal.

> **Kalau tidak ada `continue`:** program lanjut menghitung memakai data yang
> salah, misalnya jumlah tiket `0` dari `TryParse` yang gagal — struknya mencetak
> 0 tiket seharga Rp0, tapi tetap dihitung sebagai satu transaksi.

### `break` — menghentikan transaksi

```csharp
Console.Write("beli lagi? (y/n): ");                 // baris 85
string lagi = Console.ReadLine().Trim().ToLower();   // baris 86

if (lagi != "y")                                     // baris 88
{
    break;   // keluar loop                          // baris 90
}
```

Kalau jawabannya bukan `y`, `break` mengeluarkan program dari `while (true)`,
lalu program lanjut ke laporan akhir di bawahnya.

> **Kalau tidak ada `break`:** karena syarat `while`-nya `true`, program tidak
> akan pernah berhenti — laporan akhir tidak pernah tercetak dan satu-satunya
> cara keluar adalah menutup paksa terminal.

---

## Alur Program

```
        mulai
          │
          ▼
  TotalBelanja = 0
 JumlahTransaksi = 0            ← di luar while (Materi 5)
          │
          ▼
   ┌─► while (true) ──────────────────────┐   ← Materi 5
   │      │                               │
   │      ▼                               │
   │  input nama                          │   ← Materi 2
   │      │                               │
   │      ▼                               │
   │  input jenis tiket                   │
   │      │                               │
   │      ▼                               │
   │  valid? ──── tidak ──► continue ─────┤   ← Materi 4 + 6
   │      │ ya                            │
   │      ▼                               │
   │  input jumlah tiket (TryParse)       │   ← Materi 3
   │      │                               │
   │      ▼                               │
   │  valid? ──── tidak ──► continue ─────┘   ← Materi 4 + 6
   │      │ ya
   │      ▼
   │  input status pelajar
   │      │
   │      ▼
   │  harga dari konstanta, hitung subtotal   ← Materi 1 + 3
   │      │
   │      ▼
   │  pelajar? ── ya ──► potong diskon 10%    ← Materi 4
   │      │
   │      ▼
   │  bulatkan & cetak struk
   │      │
   │      ▼
   │  TotalBelanja += subtotal
   │  JumlahTransaksi++
   │      │
   │      ▼
   │  beli lagi? ── ya ──┘
   │      │ tidak
   │      ▼
   └──► break                                 ← Materi 6
          │
          ▼
   cetak laporan akhir
          │
          ▼
        selesai
```

---

## Jalannya Kode dari Atas ke Bawah

Ringkasan urutan eksekusi, buat jaga-jaga kalau ditanya "baris ini fungsinya apa":

| Baris | Kode | Fungsi |
|---|---|---|
| 1–3 | `using System;` dll. | mengambil `Console` dan `Math` |
| 5 | `namespace pertemuan3` | pengelompokan kode, seperti folder |
| 7 | `internal class tugas1` | kode C# harus berada di dalam class |
| 9–14 | `const ...` | **Materi 1** — harga, nama bioskop, besaran diskon |
| 16 | `static void Main(...)` | titik awal program saat `dotnet run` |
| 18–19 | `TotalBelanja`, `JumlahTransaksi` | penampung total, sengaja di luar `while` |
| 22 | `while (true)` | **Materi 5** — mulai perulangan transaksi |
| 25–26 | `Write` + `ReadLine` | **Materi 2** — input nama |
| 28–29 | `ReadLine().Trim().ToLower()` | input jenis tiket, langsung dirapikan |
| 32–36 | `if (...) { continue; }` | **Materi 4 + 6** — tolak jenis tiket salah |
| 38–40 | `int.TryParse(...)` | **Materi 3** — ubah teks jadi angka |
| 42–46 | `if (!berhasil \|\| jumlah <= 0)` | **Materi 4 + 6** — tolak jumlah tidak masuk akal |
| 48–50 | `jawab == "y"` | input status pelajar, hasilnya `true`/`false` |
| 53–61 | `if-else` harga | **Materi 4** — pilih harga sesuai jenis tiket |
| 64 | `harga * jumlah` | **Materi 3** — `int` masuk ke `double`, hitung subtotal |
| 66–71 | `if (isPelajar)` | **Materi 4** — potong 10% khusus pelajar |
| 73 | `Math.Round(subtotal)` | bulatkan agar nominalnya rapi |
| 76–80 | `Console.WriteLine(...)` | cetak struk, `ToUpper()` untuk judulnya |
| 82–83 | `+` dan `++` | tambahkan ke total, hitung satu transaksi |
| 85–91 | `if (lagi != "y") break;` | **Materi 6** — berhenti kalau jawabannya bukan `y` |
| 93 | `Console.WriteLine();` | baris kosong pemisah antar transaksi |
| 97–100 | laporan akhir | di luar `while`, jadi hanya tampil sekali |
| 101 | `Console.ReadKey()` | menahan jendela supaya tidak langsung tertutup |

---

## Contoh Hasil Program

```
nama pembeli: Putra
jenis tiket (reguler/premium): reguler
jumlah tiket: 2
pelajar atau bukan? (y/n): y
Anda mendapat diskon untuk pelajar 10%
--- STRUK STUDIO GAMODAL ---
Nama     : Putra
Tiket    : reguler
Jumlah   : 2
Subtotal : Rp72000
beli lagi? (y/n): y

nama pembeli: Budi
jenis tiket (reguler/premium): premium
jumlah tiket: 1
pelajar atau bukan? (y/n): n
--- STRUK STUDIO GAMODAL ---
Nama     : Budi
Tiket    : premium
Jumlah   : 1
Subtotal : Rp60000
beli lagi? (y/n): n
=================================
Jumlah transaksi : 2
Total bayar      : Rp132000
Terima kasih telah membeli di studio gamodal
```

Perhitungannya: `40.000 × 2 = 80.000`, dipotong 10% jadi `72.000`. Ditambah
tiket premium `60.000`, totalnya `132.000`.

---

## Kalimat untuk Presentasi

> "Program ini adalah kasir tiket bioskop. Dari 10 materi, saya memakai enam:
> konstanta, inputan dari keyboard, casting, kondisi, perulangan, serta break
> dan continue. Program menerima data pembelian dari keyboard, memvalidasi jenis
> dan jumlah tiket, menghitung subtotal dari harga yang disimpan sebagai
> konstanta, memberi diskon 10 persen untuk pelajar, mencetak struk, lalu
> mengulang transaksi sampai pembeli memilih tidak membeli lagi. Setelah itu
> program menampilkan jumlah transaksi dan total pembayaran."

### Kalau ditanya guru

| Pertanyaan | Jawaban singkat |
|---|---|
| Kenapa pakai `const`? | Harga itu data tetap; kalau berubah cukup edit satu baris |
| Kenapa diskon ditulis `0.10`? | 10% = 10/100; kalau ditulis 10, potongannya jadi 10 kali harga |
| Kenapa `TryParse`, bukan `Parse`? | `Parse` bikin program crash kalau pembeli mengetik huruf |
| Apa fungsi `out` di `TryParse`? | Menampung hasil angkanya ke variabel `jumlah` |
| Kenapa subtotal bertipe `double`? | Hasil potongan diskon bisa berkoma, `int` akan memotongnya |
| Kenapa `&&` di validasi jenis? | Pakai `\|\|` hasilnya selalu benar, input yang benar pun ikut ditolak |
| Kenapa variabel total di luar `while`? | Kalau di dalam, nilainya kembali nol tiap transaksi |
| Kenapa `while (true)` + `break`? | Jumlah transaksi tidak diketahui dari awal, pembeli yang menentukan |
| Bedanya `continue` dan `break`? | `continue` mengulang dari awal, `break` keluar dari perulangan |
| Kenapa `Trim().ToLower()`? | Supaya `"PREMIUM"` dan `" premium "` tetap diterima |
| Kenapa ada `Console.ReadKey()`? | Menahan jendela biar hasilnya sempat dibaca sebelum tertutup |
