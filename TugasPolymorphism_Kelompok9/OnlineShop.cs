namespace Olshop
{
    class Produk
    {
        public readonly string nama;
        public readonly decimal harga;

        public Produk(string nama, decimal harga)
        {
            this.nama = nama;
            this.harga = harga;
        }
    }

    class Elektronik : Produk
    {
        public readonly decimal berat;

        public Elektronik(decimal berat,string nama,decimal harga) : base(nama, harga) 
        { 
            this.berat = berat;
        }
    }

    class Pakaian : Produk
    {
        public Pakaian(string nama,decimal harga) : base (nama, harga)
        {

        }
    }

    class Buku : Produk
    {
        public Buku(string nama,decimal harga) : base(nama, harga)
        {

        }
    }

    class KeranjangBelanja
    {
        private Produk[] items;
        private int hitungItem;

        public KeranjangBelanja(int kapasitas)
        {
            items = new Produk[kapasitas];
            hitungItem = 0;
        }

        public void tambahItem(Produk item)
        {
            if(items.Length > hitungItem)
            {
                items[hitungItem] = item;
                hitungItem++;   
            }
            else
            {
                Console.WriteLine("Keranjang sudah penuh!");
            }
        }

        public decimal hitungTotal()
        {
            decimal total = 0;
            foreach(var item in items)
            {
                if (item != null)
                {
                    total += item.harga;
                }
            }
            return total;
        }
    }
}

