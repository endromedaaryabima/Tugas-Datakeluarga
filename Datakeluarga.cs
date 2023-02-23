using System;

public class simpledataklg
{
    static public void Main()
    {
      datakeluarga ok = new datakeluarga();
      datakeluarga ayahku = new Ayah();
      ayahku.Nama = "Dedik Adi Wijaya";
      ayahku.Umur = 45;
      ayahku.Nohp = "-";
      Console.WriteLine("Data Ayah:");
      Console.WriteLine(ayahku.Nama);
      Console.WriteLine(ayahku.Umur);
      Console.WriteLine(ayahku.Nohp);
      ayahku.Hobi();
      datakeluarga ibuku = new Ibu();
      ibuku.Nama = "Sanik Susilowati";
      ibuku.Umur = 38;
      ibuku.Nohp = +62895601128866;
      Console.Write("Data Ibu:");
      Console.WriteLine(ibuku.Nama);
      Console.WriteLine(ibuku.Umur);
      Console.WriteLine(ibuku.Nohp);
      ibuku.Hobi();
      Console.WriteLine("Data Diriku");
      datakeluarga aku = new Anak();
      aku.Nama = "Endromeda AryaBima W";
      aku.Umur = 16;
      aku.Nohp = +6281331490204;
      Console.WriteLine(aku.Nama);
      Console.WriteLine(aku.Umur);
      Console.WriteLine(aku.Nohp);
      aku.Hobi();      
    }
    class datakeluarga 
    {
        private string nama;
        public string Nama
        {
            get { return nama;}
            set { nama = value;}
        }
        private int umur;
        public int Umur
        {
            get {return umur;}
            set {umur = value;}
        }
        private long nohp;
        public long Nohp
        {
            get {return nohp;}
            set {nohp = value;}
        }
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ayah:datakeluarga
    {
        public override void Hobi()
        {
            Console.WriteLine("Travelling");
        }
    }
    class Ibu:datakeluarga 
    {
        public override void Hobi()
        {
            Console.WriteLine("Berkebun");
        }
    }
    class Anak:datakeluarga 
    {
        public override void Hobi()
        {
            Console.WriteLine("Bermain Game");
        }
    }

}
