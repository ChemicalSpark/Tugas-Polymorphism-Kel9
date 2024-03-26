using System;
using System.ComponentModel.Design;
using System.Globalization; // Add this namespace for CultureInfo

namespace Bank
{
    abstract class Rekening
    {
        protected string pemilik;
        protected double saldo;

        public Rekening(string pemilik, double saldo)
        {
            this.pemilik = pemilik;
            this.saldo = saldo;
        }

        public double Saldo { get { return saldo; } }


        public virtual void Setoran(double jumlah)
        {
            saldo += jumlah;
            Console.WriteLine($"Setoran sebesar {jumlah:C} berhasil. Saldo sekarang {saldo:C}");
        }

        public abstract void Penarikan(double jumlah);
        public abstract void CekSaldo();
    }

    class RekeningTabungan : Rekening
    {
        private double bunga;

        public RekeningTabungan(string pemilik, double saldo, double bunga) : base(pemilik, saldo)
        {
            this.bunga = bunga;
        }

        public override void Setoran(double jumlah)
        {
            base.Setoran(jumlah);
            Console.WriteLine($"Bunga {bunga * 100}% telah ditambahkan. Saldo sekarang {saldo:C}");
        }

        public override void Penarikan(double jumlah)
        {
            if (jumlah > saldo)
                Console.WriteLine("Saldo tidak mencukupi untuk penarikan.");
            else
            {
                saldo -= jumlah;
                Console.WriteLine($"Penarikan sebesar {jumlah:C} berhasil. Saldo sekarang {saldo:C}");
            }
        }

        public override void CekSaldo()
        {
            Console.WriteLine($"Saldo {pemilik}: {saldo:C}");
        }
    }


    class RekeningGiro : Rekening
    {
        private double batasPenarikan;

        public RekeningGiro(string pemilik, double saldo, double batasPenarikan) : base(pemilik, saldo)
        {
            this.batasPenarikan = batasPenarikan;
        }

        public override void Penarikan(double jumlah)
        {
            if (jumlah <= saldo)
            {
                saldo -= jumlah;
                Console.WriteLine($"Penarikan sebesar {jumlah:C} berhasil. Saldo sekarang: {saldo:C}.");
            }
            else if (jumlah > saldo + batasPenarikan)
            {
                Console.WriteLine("Tidak dapat melakukan penarikan. Penarikan melebihi batas penarikan.");
            }
            else
            {

                saldo = (saldo + batasPenarikan) - jumlah; // melakukan perhitungan awal, menjumlah total saldo dengan batas
                saldo = saldo - batasPenarikan;

                Console.WriteLine($"Penarikan sebesar {jumlah:C} berhasil. Penarikan melebihi saldo Anda. Saldo sekarang ${saldo}");

            }
        }


        public override void CekSaldo()
        {
            Console.WriteLine($"Saldo {pemilik}: {saldo:C}");
        }
    }
}
