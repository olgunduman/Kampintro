using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Olgun";
            musteri1.SoyAdi = "Duman";
            musteri1.Tc = 123456789;
            musteri1.HesapNumarası = 456256;
            musteri1.Bakiye = 4200;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ahnet";
            musteri2.SoyAdi = "Sener";
            musteri2.Tc = 145688756;
            musteri2.HesapNumarası = 369874;
            musteri2.Bakiye = 4278;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Can";
            musteri3.SoyAdi = "Yılmaz";
            musteri3.Tc = 698741235;
            musteri3.HesapNumarası = 753951;
            musteri3.Bakiye = 1200;

            //Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            List<Musteri> musteriler = new List<Musteri>();

            for (int i = 0; i < musteriler.Count; i++)
            {
                Message.Box
                Console.WriteLine("SoyAdı :" + musteriler);
                Console.WriteLine("Tc:" + musteriler);
                Console.WriteLine("HesapNo :" + musteriler);
                Console.WriteLine("Bakiye:" + musteriler);
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("---------------------");
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("---------------------");
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine("---------------------");
            musteriManager.MusteriSil(musteri3);
            Console.WriteLine("---------------------");
            musteriManager.MusteriListele(musteriler);

        }
    }
}
