using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan("Hasan", "KAHRAMAN", 132456789, "BT");

            calisan.CalisanBilgileri();
            Console.ReadLine();

            Calisan calisan2 = new Calisan("Arzu", "KAHRAMAN");
            calisan2.CalisanBilgileri();
            Console.ReadLine();
            
        }
    }

     class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman){
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad){
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(){}

        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
        

    }
}
