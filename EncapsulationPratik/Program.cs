using EncapsulationPratik;
using System;

namespace ArabaApp
{
   
    class Program
    {
        static void Main(string[] args)
        {
            // Geçerli kapı sayısı (2) ile araba nesnesi oluşturma
            
            Araba araba1 = new Araba("Mercedes", "GLE", "Gri", 2);
            araba1.PrintInfo();

            // Geçersiz kapı sayısı (3) ile araba nesnesi oluşturma
            Araba araba2 = new Araba("Porsche", "Taycan", "Siyah", 3);
            araba2.PrintInfo();
        }
    }
}