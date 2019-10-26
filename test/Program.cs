using RentACar.Dal.Concrete;
using RentACar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            RentContext context=new RentContext();
           /* List<Marka> markalar = new List<Marka>()
            {
                new Marka(){MarkaAdi = "Opel"},
                new Marka(){MarkaAdi = "Mercedes"},
                new Marka(){MarkaAdi = "Renault"},
                new Marka(){MarkaAdi = "Fiat"}
            };

            context.Markalar.AddRange(markalar);
            context.SaveChanges();*/


            List<Model> modeller = new List<Model>()
            {
                new Model(){ModelAdi = "Corsa",Yil =2019,MarkaId = 1},
                new Model(){ModelAdi = "A180D",Yil =2018,MarkaId = 2},
                new Model(){ModelAdi = "Clio",Yil =2012,MarkaId = 3},
                new Model(){ModelAdi = "Albea",Yil =2019,MarkaId = 4}

            };
            context.Modeller.AddRange(modeller);
            context.SaveChanges();


            List<Arac> araclar = new List<Arac>()
            {
                new Arac(){SasiNo = "TR999995999999999",Kilometre = 100000,GunlukFiyat = 10,ModelId = 1},
                new Arac(){SasiNo = "TR888888588888888",Kilometre = 200000,GunlukFiyat = 10,ModelId = 1},
                new Arac(){SasiNo = "TR999995999999997",Kilometre = 300000,GunlukFiyat = 10,ModelId = 1},
                new Arac(){SasiNo = "TR999995999999996",Kilometre = 4000,GunlukFiyat = 10,ModelId = 1},
                new Arac(){SasiNo = "TR999999599999995",Kilometre = 5000,GunlukFiyat = 10,ModelId = 1}

            };
            context.Araclar.AddRange(araclar);
            context.SaveChanges();

            List<Musteri> musteriler = new List<Musteri>()
            {
                new Musteri(){TcNo = "50277752468",Ad = "Akın",Soyad = "Aldemir",Mail = "aknaldemir@gmail.com",Parola = "123456789",Fotokopi = "fotokopi1.jpg",Memleket = "Zonguldak",DogumTarihi = DateTime.Now.AddYears(-26)},
                new Musteri(){TcNo = "58275774468",Ad = "Yusuf",Soyad = "Cansız",Mail = "aknaldemir@gmail.com",Parola = "123456789",Fotokopi = "fotokopi2.jpg",Memleket = "Zonguldak",DogumTarihi = DateTime.Now.AddYears(-26)},
                new Musteri(){TcNo = "50375772468",Ad = "FatmaGül",Soyad = "Polat",Mail = "aknaldemir@gmail.com",Parola = "123456789",Fotokopi = "fotokopi3.jpg",Memleket = "Zonguldak",DogumTarihi = DateTime.Now.AddYears(-26)},
                new Musteri(){TcNo = "50227752468",Ad = "Serkan",Soyad = "Yıldırım",Mail = "aknaldemir@gmail.com",Parola = "123456789",Fotokopi = "fotokopi4.jpg",Memleket = "Zonguldak",DogumTarihi = DateTime.Now.AddYears(-26)},
            };
            context.Musteriler.AddRange(musteriler);
            context.SaveChanges();

            List<Resim> resimler = new List<Resim>()
            {
                new Resim(){ResimAdi = "Corsa1.jpg",AracId = 1},
                new Resim(){ResimAdi = "Corsa2.jpg",AracId = 1},
                new Resim(){ResimAdi = "Corsa3.jpg",AracId = 1},
                new Resim(){ResimAdi = "Corsa4.jpg",AracId = 1},
                new Resim(){ResimAdi = "Corsa5.jpg",AracId = 1},
                new Resim(){ResimAdi = "A180D1.jpg",AracId = 2},
                new Resim(){ResimAdi = "A180D2.jpg",AracId = 2},
                new Resim(){ResimAdi = "A180D3.jpg",AracId = 2},
                new Resim(){ResimAdi = "A180D4.jpg",AracId = 2},
                new Resim(){ResimAdi = "A180D5.jpg",AracId = 2},
                new Resim(){ResimAdi = "Clio1.jpg",AracId = 3},
                new Resim(){ResimAdi = "Clio2.jpg",AracId = 3},
                new Resim(){ResimAdi = "Clio3.jpg",AracId = 3},
                new Resim(){ResimAdi = "Clio4.jpg",AracId = 3},
                new Resim(){ResimAdi = "Clio5.jpg",AracId = 3},
                new Resim(){ResimAdi = "Albea1.jpg",AracId = 4},
                new Resim(){ResimAdi = "Albea2.jpg",AracId = 4},
                new Resim(){ResimAdi = "Albea3.jpg",AracId = 4},
                new Resim(){ResimAdi = "Albea4.jpg",AracId = 4},
                new Resim(){ResimAdi = "Albea5.jpg",AracId = 4}

            };
            context.Resimler.AddRange(resimler);
            context.SaveChanges();



            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>()
            {
                new Rezervasyon(){MusteriId = 1,AracId = 1,CikisTarihi = DateTime.Now,DonusTarihi = DateTime.Now.AddDays(5)},
                new Rezervasyon(){MusteriId = 2,AracId = 2,CikisTarihi = DateTime.Now,DonusTarihi = DateTime.Now.AddDays(14)},
                new Rezervasyon(){MusteriId = 3,AracId = 3,CikisTarihi = DateTime.Now,DonusTarihi = DateTime.Now.AddDays(20)},
                new Rezervasyon(){MusteriId = 4,AracId = 4,CikisTarihi = DateTime.Now,DonusTarihi = DateTime.Now.AddDays(70)}
            };
            context.Rezervasyonlar.AddRange(rezervasyonlar);

            context.SaveChanges();
        }
    }
}
