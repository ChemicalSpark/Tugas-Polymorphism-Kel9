namespace Olshop
{
    class Produk
    {
        public string nama;
        public int harga;

        public Produk(string nama, int harga)
        {
            this.nama = nama;
            this.harga = harga;
        }
    }

    class Elektronik : Produk
    {
        public double berat;

        public Elektronik(double berat,string nama,int harga) : base(nama, harga) 
        { 
            this.berat = berat;
        }
    }

    class Pakaian : Produk
    {
        public Pakaian(string nama,int harga) : base (nama, harga)
        {

        }
    }

    class Buku : Produk
    {
        public Buku(string nama,int harga) : base(nama, harga)
        {

        }
    }

    class KeranjangBelanja
    {

    }
}