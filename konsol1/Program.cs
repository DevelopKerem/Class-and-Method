using System;

namespace konsol1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {
                "Yazılım", "Donanım", "Algoritma", "Veri Analizi",
        };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
       
    }
}
