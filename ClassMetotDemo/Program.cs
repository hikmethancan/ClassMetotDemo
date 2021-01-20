    using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri kayit1 = new Musteri();
            kayit1.Adi = "Hikmethan ";
            kayit1.Soyadi = " CAN";
            kayit1.Id = 10;
            kayit1.Cinsiyeti = "Erkek";

            

            Musteri kayit2 = new Musteri();
            kayit2.Adi = " Tunay Uzbay";
            kayit2.Soyadi = " YELCE";
            kayit2.Id = 11;
            kayit2.Cinsiyeti = " Erkek";

            

            Musteri kayit3 = new Musteri();
            kayit3.Adi = " Mehmet";
            kayit3.Soyadi = " TUZCU";
            kayit3.Id = 12;
            kayit3.Cinsiyeti = " Erkek ";

            Musteri[] musteriler = new Musteri[] { kayit1, kayit2, kayit3 };

            foreach (var musterimiz in musteriler)

            {
                Console.WriteLine(musterimiz.Adi);
                Console.WriteLine(musterimiz.Soyadi);
                Console.WriteLine(musterimiz.Id);
                Console.WriteLine(musterimiz.Cinsiyeti);
                Console.WriteLine("-------diger müsteri-------");

            }

            Console.WriteLine("-------------ekleme ve silme----------");

            MusteriManager manager = new MusteriManager();

            manager.Add(kayit1);

            manager.Delete(kayit2);




            


        }
    }
}
