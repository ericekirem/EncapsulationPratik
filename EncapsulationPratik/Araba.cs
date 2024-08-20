using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPratik
{

    public class Araba
    {
        // Property'ler
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        private int kapiSayisi;

        // Kapı Sayısı için encapsulation (kapsülleme)
        public int KapiSayisi
        {
            get { return kapiSayisi; }
            set
            {
                if (value == 2 || value == 4)
                {
                    kapiSayisi = value;
                }
                else
                {
                    Console.WriteLine("Uyarı: Kapı sayısı sadece 2 veya 4 olabilir! Kapı sayısı -1 olarak ayarlandı.");
                    kapiSayisi = -1;
                }
            }
        }

        // Constructor
        public Araba(string marka, string model, string renk, int kapiSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            KapiSayisi = kapiSayisi; // Bu, KapiSayisi property'nin set metodunu çağırır.
        }

        // Araba bilgilerini yazdırmak için bir metot
        public void PrintInfo()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}, Renk: {Renk}, Kapı Sayısı: {KapiSayisi}");
        }
    }

}
