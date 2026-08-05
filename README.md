# Praktik Dasar C#

Kumpulan latihan dan tugas mata kuliah **Praktik Dasar C#** (.NET 10), disusun per pertemuan.

## Struktur

| Folder | Isi |
| --- | --- |
| `pertemuan1/` | Dasar: `Console.WriteLine`, variabel, konstanta, input keyboard, 2 tugas |
| `pertemuan3/` | Casting, `Math`, `string` method, boolean, kondisi, perulangan, `break`/`continue`, 1 tugas |

Kedua proyek terdaftar di `praktik dasar c#.slnx`.

## Menjalankan

Setiap folder adalah satu proyek console yang berdiri sendiri:

```bash
cd pertemuan3
dotnet run
```

Karena satu proyek berisi banyak file latihan, yang dijalankan ditentukan oleh
`<StartupObject>` di dalam file `.csproj`. Contoh di `pertemuan3/pertemuan3.csproj`:

```xml
<StartupObject>pertemuan3.tugas1</StartupObject>
```

Untuk menjalankan latihan lain, ganti isi `StartupObject` ke nama class-nya,
misalnya `pertemuan3.latihan14`, lalu `dotnet run` lagi.

> Class di `pertemuan1/latihan1.cs`–`latihan4.cs` memakai method `Jalankan()`
> (bukan `Main`), jadi tidak bisa dijadikan `StartupObject`. Panggil dari
> `Main` yang aktif, misalnya `latihan1.Jalankan();`.

## Isi per Pertemuan

### `pertemuan1/`

| File | Materi |
| --- | --- |
| `latihan1.cs` | Hello World |
| `latihan2.cs` | Variabel dan tipe data |
| `latihan3.cs` | Konstanta (`const`) |
| `latihan4.cs` | Input dari keyboard (`Console.ReadLine`) |
| `tugas1.cs` | Menampilkan data diri dari variabel |
| `tugas2.cs` | Hitung luas & keliling persegi panjang dari input |

### `pertemuan3/`

| File | Materi |
| --- | --- |
| `latihan1.cs` | Implicit casting (`int` → `double`) |
| `latihan2.cs` | Explicit casting (`double` → `int`) |
| `latihan3.cs` | Casting dengan `Convert` |
| `latihan4.cs` | Method `Math` (`Abs`, `Sqrt`, `Pow`) |
| `latihan5.cs` | Method `string` (`Length`, `ToUpper`, `Substring`) |
| `latihan6.cs` | Boolean dan operasinya |
| `latihan7.cs` | `if` / `else` |
| `latihan8.cs` | `else if` bertingkat |
| `latihan9.cs` | `switch` |
| `latihan10.cs` | `if` tanpa `else` |
| `latihan11.cs` | Perulangan `for` |
| `latihan12.cs` | Perulangan `while` |
| `latihan13.cs` | Perulangan `do-while` |
| `latihan14.cs` | Perulangan `foreach` |
| `latihan15.cs` | `break` |
| `latihan16.cs` | `continue` |
| `latihan17.cs` | Percabangan nilai lulus/tidak lulus |
| `tugas1.cs` | **Tugas 1** — kasir tiket bioskop |

## Dokumentasi

- [`pertemuan3/PENJELASAN-tugas1.md`](pertemuan3/PENJELASAN-tugas1.md) — penjelasan
  baris per baris Tugas 1 bioskop: 6 materi yang dipakai, alur program, dan contoh hasilnya.
