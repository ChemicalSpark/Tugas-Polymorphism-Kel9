namespace AplikasiMenggambar
{
    public class Shape
    {
        public string Warna;

        public Shape(string Warna)
        {
            this.Warna = Warna;
        }

        public virtual void ShapeDraw()
        {
            Console.WriteLine("Dengan warna : " + Warna);
        }
    }

    public class SegiTiga : Shape
    {
        public string JenisSegiTiga;

        public SegiTiga(string JenisSegiTiga, string Warna) : base(Warna)
        {
            this.JenisSegiTiga = JenisSegiTiga;
        }

        public override void ShapeDraw()
        {
            Console.WriteLine("Menggambar segitiga berjenis : " + JenisSegiTiga);
            base.ShapeDraw();
        }
    }

    public class Lingkaran : Shape
    {
        public int Diameter;

        public Lingkaran(int Diameter, string Warna) : base(Warna)
        {
            this.Diameter = Diameter;
        }


        public override void ShapeDraw()
        {
            Console.WriteLine("Menggambar Lingkaran dengan Diameter : " + Diameter);
            base.ShapeDraw();
        }
    }

    public class Persegi : Shape
    {
        public int Sisi;

        public Persegi(int Sisi, string Warna) : base(Warna)
        {
            this.Sisi = Sisi;
        }

        public override void ShapeDraw()
        {
            Console.WriteLine("Menggambar Persegi dengan panjang sisi : " + Sisi);
            base.ShapeDraw();
        }
    }

    public class JajarGenjang : Shape
    {
        public int Diagonal;

        public JajarGenjang(int Diagonal, string Warna) : base(Warna)
        {
            this.Diagonal = Diagonal;
        }

        public override void ShapeDraw()
        {
            Console.WriteLine("Menggambar Jajar Genjang dengan diagonal :" + Diagonal);
            base.ShapeDraw();
        }
    }

    public class Canvas
    {
        public void CreateShape(Shape shape)
        {
            shape.ShapeDraw();
        }
    }
}