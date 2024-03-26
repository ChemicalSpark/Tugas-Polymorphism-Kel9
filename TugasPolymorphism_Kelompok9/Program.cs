
﻿using Olshop;
using Bank;


class Program
{
    static void Main(string[] args)
    {
        //Online Shop
        KeranjangBelanja keranjang = new KeranjangBelanja(3);
        Elektronik laptop = new Elektronik(5, "Razer Blade 18", 95000000);
        Pakaian baju = new Pakaian("T-Shirt Console.WriteLine", 50000);
        Buku komik = new Buku("Monster", 150000);

        Console.WriteLine("---Keranjang Belanja---");
        Console.WriteLine($"Nama item : {laptop.nama}, Harga item : {laptop.harga:c}, Berat item : {laptop.berat} Kg");
        Console.WriteLine($"Nama item : {baju.nama}, Harga item : {baju.harga:c}");
        Console.WriteLine($"Nama item : {komik.nama}, Harga item : {komik.harga:c}");
        keranjang.tambahItem(laptop);
        keranjang.tambahItem(baju);
        keranjang.tambahItem(komik);
        decimal total = keranjang.hitungTotal();
        Console.WriteLine($"Total harga pada keranjang belanja : {+ total:c}");
        Console.WriteLine("\n---Ongkos Kirim---");
        Console.WriteLine($"Ongkir untuk {laptop.nama} : {laptop.Ongkir():c}");
        Console.WriteLine($"Ongkir untuk {baju.nama} : {baju.Ongkir():c}");
        Console.WriteLine($"Ongkir untuk {komik.nama} : {komik.Ongkir():c}");
        decimal totalOngkir = keranjang.hitungTotalOngkir();
        Console.WriteLine($"Total ongkir pada keranjang belanja : {+ totalOngkir:c}");


        //Sistem Perbankan
        
        Console.WriteLine("\n == Sistem Perbankan == \n");

        

        // Membuat objek RekeningTabungan
        RekeningTabungan tabunganBudi = new RekeningTabungan("Budi", 5000, 0.05);

        // Setoran awal
        tabunganBudi.Setoran(1000);

        // Cek saldo
        tabunganBudi.CekSaldo();
        
        // Penarikan
        tabunganBudi.Penarikan(2000);

        // Cek saldo setelah penarikan
        tabunganBudi.CekSaldo();

        Console.WriteLine();

        // Membuat objek RekeningGiro
        RekeningGiro giroAni = new RekeningGiro("Ani", 3000, 1000);

        // Setoran awal
        giroAni.Setoran(2000);

        // Cek saldo
        giroAni.CekSaldo();
        

        // Penarikan
        giroAni.Penarikan(2500);

        // Cek saldo setelah penarikan
        giroAni.CekSaldo();
        


        // Penarikan melebihi saldo dan batas penarikan
        giroAni.Penarikan(1500);

        // Cek saldo setelah penarikan
        giroAni.CekSaldo();

        giroAni.Penarikan(1500);


        //Aplikasi Menggambar



    }
}