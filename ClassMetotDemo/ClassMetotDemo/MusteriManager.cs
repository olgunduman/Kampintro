using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri adı giriniz:" + musteri.Adi + 
                "Müşteri SoyAdını giriniz :" + musteri.SoyAdi + "Müşteri Tc :" + musteri.Tc + "Müşteri Bakiye :" + musteri.Bakiye);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Silinicek Müşteri Tc :" + musteri.Tc);
            
        }
        public void MusteriListele(List<Musteri> musteriler)
        {
            Console.WriteLine("Müşteri Listesi");
            Console.WriteLine("----------------------");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı:" + musteri.Adi + "Müşteri SoyAdı" + musteri.SoyAdi + "Müşteri Bakiye :" + musteri.Bakiye);
            }
            

        }

    }
}
