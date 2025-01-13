using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Person
    {
        // Özellikler
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        // Yapıcı metot (constructor)
        public Person(string ad, string soyad, DateTime dogumTarihi)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = dogumTarihi;
        }

        // Bilgileri yazdıran metot
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi.ToShortDateString()}");
        }
    }








}

