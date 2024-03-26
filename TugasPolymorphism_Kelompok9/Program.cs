using Bank;
using Olshop;

class Program
{
    static void Main(string[] args)
    {
        //Online Shop
        Console.WriteLine("Masukkan Keterangan Elektronik:");
        Console.Write("Nama Elektronik: ");
        string namaElektronik = Console.ReadLine();
        Console.Write("Harga Elektronik: ");
        decimal hargaElektronik = decimal.Parse(Console.ReadLine());
        Console.Write("Berat Elektronik (kg): ");
        double beratElektronik = double.Parse(Console.ReadLine());
        Console.WriteLine("\nMasukkan Keterangan Pakaian:");
        Console.Write("Nama Pakaian: ");
        string namaPakaian = Console.ReadLine();
        Console.Write("Harga Pakaian: ");
        decimal hargaPakaian = decimal.Parse(Console.ReadLine());
        Console.WriteLine("\nMasukkan Keterangan Buku:");
        Console.Write("Judul Buku: ");
        string namaBuku = Console.ReadLine();
        Console.Write("Harga Buku: ");
        decimal hargaBuku = decimal.Parse(Console.ReadLine());

        KeranjangBelanja keranjang = new KeranjangBelanja(3);
        Elektronik Elektronik = new Elektronik(beratElektronik,namaElektronik,hargaElektronik);
        Pakaian pakaian = new Pakaian(namaPakaian,hargaPakaian);
        Buku buku = new Buku(namaBuku,hargaBuku);

        Console.WriteLine("\n---Keranjang Belanja---");
        Console.WriteLine($"Nama item : {namaElektronik}, Harga item : {hargaElektronik:c}, Berat item : {beratElektronik} Kg");
        Console.WriteLine($"Nama item : {namaPakaian}, Harga item : {hargaPakaian:c}");
        Console.WriteLine($"Nama item : {namaBuku}, Harga item : {hargaBuku:c}");
        keranjang.tambahItem(Elektronik);
        keranjang.tambahItem(pakaian);
        keranjang.tambahItem(buku);
        decimal total = keranjang.hitungTotal();
        Console.WriteLine($"Total harga pada keranjang belanja : {+ total:c}");
        Console.WriteLine("\n---Ongkos Kirim---");
        Console.WriteLine($"Ongkir untuk {namaElektronik} : {Elektronik.Ongkir():c}");
        Console.WriteLine($"Ongkir untuk {namaPakaian} : {pakaian.Ongkir():c}");
        Console.WriteLine($"Ongkir untuk {namaBuku} : {buku.Ongkir():c}");
        decimal totalOngkir = keranjang.hitungTotalOngkir();
        Console.WriteLine($"Total ongkir pada keranjang belanja : {+ totalOngkir:c}");


        //Sistem Perbankan
        //RekeningTabungan tabungan = new RekeningTabungan(); 


        //Aplikasi Menggambar


    }
}