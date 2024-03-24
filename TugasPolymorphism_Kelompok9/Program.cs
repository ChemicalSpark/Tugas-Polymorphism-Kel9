using Olshop;
//using Bank;

class Program
{
    static void Main(string[] args)
    {
        //Online Shop
        KeranjangBelanja keranjang = new KeranjangBelanja(5);
        Elektronik laptop = new Elektronik(5, "Razer Blade 18", 95000000);
        Pakaian baju = new Pakaian("T-Shirt Console.WriteLine", 50000);
        Buku komik = new Buku("Monster",150000);
        keranjang.tambahItem(laptop);
        keranjang.tambahItem(baju);
        keranjang.tambahItem(komik); 
        decimal total = keranjang.hitungTotal();
        Console.WriteLine("Total harga pada keranjang belanja ini adalah :" + total);

        //Sistem Perbankan


        //Aplikasi Menggambar


    }
}