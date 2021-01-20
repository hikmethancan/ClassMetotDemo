using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musterimiz)
        {
            Console.WriteLine("Musteri eklendi" + musterimiz.Adi+ "   " + musterimiz.Soyadi + " : " + musterimiz.Id);
        }

        public void Delete(Musteri musterimiz)
        {
            Console.WriteLine("Musteri silindi" + musterimiz.Adi + "   " + musterimiz.Soyadi + " : " + musterimiz.Id);
        }



    }
}
