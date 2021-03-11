using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlangıç İçin Temel Kurs", 
                "Java", 
                "Python", 
                "C#"};

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("---------------------------------------------");

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
