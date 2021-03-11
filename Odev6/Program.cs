using System;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            Product urun2 = new Product();
            Product urun3 = new Product();
            Product urun4 = new Product();

            urun1.urunAdi = "Hayvan Çiftliği";
            urun1.urunPuani = 4.7f;
            urun1.urunFiyati = 6.99f;
            urun1.indirimOrani = "%40";

            urun2.urunAdi = "Satranç";
            urun2.urunPuani = 4.5f;
            urun2.urunFiyati = 3.99f;
            urun2.indirimOrani = "%50";

            urun3.urunAdi = "Sinekli Bakkal";
            urun3.urunPuani = 4.2f;
            urun3.urunFiyati = 14.99f;
            urun3.indirimOrani = "%35";

            urun4.urunAdi = "Taht Oyunları";
            urun4.urunPuani = 4.3f;
            urun4.urunFiyati = 25.99f;
            urun4.indirimOrani = "%25";

            Product[] urunler = new Product[] {urun1, urun2, urun3, urun4};

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " Ürün Puanı: " + urun.urunPuani + " Ürün Fiyatı: " +
                    urun.urunFiyati + " İndirim Oranı: " + urun.indirimOrani);
            }

            Console.WriteLine("-------------------------------------------------------------------");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi + " Ürün Puanı: " + urunler[i].urunPuani + " Ürün Fiyatı: " +
                    urunler[i].urunFiyati + " İndirim Oranı: " + urunler[i].indirimOrani);
            }

            Console.WriteLine("-------------------------------------------------------------------");

            int sayi = 0;

            while (sayi < urunler.Length)
            {
                Console.WriteLine(urunler[sayi].urunAdi + " Ürün Puanı: " + urunler[sayi].urunPuani + " Ürün Fiyatı: " +
                    urunler[sayi].urunFiyati + " İndirim Oranı: " + urunler[sayi].indirimOrani);
                sayi++;
            }

        }
    }

    class Product
    {
        public string urunAdi { get; set; }
        public float urunFiyati { get; set; }
        public string indirimOrani { get; set; }
        public float urunPuani { get; set; }
    }

}
