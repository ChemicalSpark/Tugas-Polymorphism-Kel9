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

        public virtual decimal Ongkir()
        {
            return 0;
        }
    }

    class Elektronik : Produk
    {
        public readonly double berat;

        public Elektronik(double berat,string nama,decimal harga) : base(nama, harga) 
        { 
            this.berat = berat;
        }

        public override decimal Ongkir()
        {
            return (decimal)(berat * 10000);
        }
    }

    class Pakaian : Produk
    {
        public Pakaian(string nama,decimal harga) : base (nama, harga)
        {
        }

        public override decimal Ongkir()
        {
            return 7000;
        }
    }

    class Buku : Produk
    {
        public Buku(string nama,decimal harga) : base(nama, harga)
        {
        }

        public override decimal Ongkir()
        {
            return 5000;
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

        public decimal hitungTotalOngkir()
        {
            decimal totalOngkir = 0;
            foreach (var item in items)
            {
                if (item != null)
                {
                    totalOngkir += item.Ongkir();
                }
            }
            return totalOngkir;
        }
    }
}

