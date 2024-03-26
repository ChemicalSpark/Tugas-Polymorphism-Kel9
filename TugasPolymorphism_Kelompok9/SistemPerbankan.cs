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
            // Jika jumlah penarikan tidak melebihi saldo yang dimiliki
            if (jumlah <= saldo)
            {
                saldo -= jumlah;
                Console.WriteLine($"Penarikan sebesar {jumlah:C} berhasil. Saldo sekarang: {saldo:C}.");
            }
            // Jika jumlah penarikan melebihi saldo yang dimiliki, tetapi masih dalam batas penarikan
            else if (jumlah > saldo && (saldo - jumlah) >= -batasPenarikan)
            {
                saldo -= jumlah;
                Console.WriteLine($"Penarikan sebesar {jumlah:C} berhasil. Penarikan melebihi saldo Anda. Saldo sekarang: ${saldo}");
            }
            // Jika jumlah penarikan melebihi batas penarikan
            else if (jumlah > saldo && (saldo - jumlah) < -batasPenarikan)
            {
                Console.WriteLine($"Tidak dapat melakukan penarikan. Saldo anda telah mencapai batas penarikan. Batas Penarikan anda {batasPenarikan:C}");
            }
        }

        public override void CekSaldo()
        {
            Console.WriteLine($"Saldo {pemilik}: {saldo:C}");
        }
    }
}
