namespace Bank
{
    public abstract class Rekening
    {
        public string Pemilik;
        public double Saldo;

        public Rekening(string pemilik, double saldo)
        {
            Pemilik = pemilik;
            Saldo = saldo;
        }

        public virtual void Setor(double jumlah)
        {
            Saldo += jumlah;
        }

        public virtual bool Tarik(double jumlah)
        {
            if (jumlah <= Saldo)
            {
                Saldo -= jumlah;
                return true;
            }
            return false;
        }

        public virtual bool Transfer(Rekening tujuan, double jumlah)
        {
            if (jumlah <= Saldo)
            {
                Saldo -= jumlah;
                tujuan.Setor(jumlah);
                return true;
            }
            return false;
        }

        public virtual double CekSaldo()
        {
            return Saldo;
        }
    }

    public class RekeningTabungan : Rekening
    {
        public double Bunga;

        public RekeningTabungan(string pemilik, double saldo, double bunga)
            : base(pemilik, saldo)
        {
            Bunga = bunga;
        }

        public override void Setor(double jumlah)
        {
            base.Setor(jumlah);
            BerikanBunga();
        }

        private void BerikanBunga()
        {
            double bungaTahunan = Saldo * (Bunga / 100);
            Saldo += bungaTahunan;
        }

        public string InfoTabungan()
        {
            return $"Info Rekening Tabungan {Pemilik} - Saldo: {Saldo} - Bunga: {Bunga}%";
        }
    }
    public class RekeningGiro : Rekening
    {
        public double Bunga;
        public DateTime JangkaWaktu;

        public RekeningGiro(string pemilik, double saldo, double bunga, DateTime jangkaWaktu)
            : base(pemilik, saldo)
        {
            Bunga = bunga;
            JangkaWaktu = jangkaWaktu;
        }

        public override void Setor(double jumlah)
        {
            base.Setor(jumlah);
            BerikanBunga();
        }

        private void BerikanBunga()
        {
            double bungaBulanan = Saldo * (Bunga / 100 / 12);
            Saldo += bungaBulanan;
        }

        public override bool Tarik(double jumlah)
        {

            if (DateTime.Now <= JangkaWaktu)
            {
                return base.Tarik(jumlah);
            }
            return false;
        }

        public string InfoGiro()
        {
            return $"Info Rekening Giro {Pemilik} - Saldo: {Saldo} - Bunga: {Bunga}% - Jangka Waktu sampai : {JangkaWaktu} tahun";
        }
    }
}