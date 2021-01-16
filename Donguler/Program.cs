using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelitirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıc için temel kurs";
            string kurs3 = "Java";

            //array -dizi

            string[] kurslar = new string[] { "Yazılım Gelitirici Yetiştirme Kampı", 
                "Programlamaya başlangıc için temel kurs",
                "Java","Python","C#" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti..");
            Console.WriteLine();
            //forech kullanımı dizileri daha rahat dolasmak için kullanılır.
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");

        }
    }
}
