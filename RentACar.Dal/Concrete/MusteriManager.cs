using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Entity;

namespace RentACar.Dal.Concrete
{
    public class MusteriManager
    {
        private RentContext _context;
        public MusteriManager()
        {
            _context = new RentContext();
        }
    
        public int etkilenenKayit;
        public int Add(Musteri musteri)
        {
            _context.Musteriler.Add(musteri);
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }
        public int Update(Musteri musteri)
        {
            Musteri newMusteri = _context.Musteriler.FirstOrDefault(x => x.MusteriId == musteri.MusteriId);
            newMusteri.Ad = musteri.Ad;
            newMusteri.Soyad = musteri.Soyad;
            newMusteri.Fotokopi = musteri.Fotokopi;
            newMusteri.DogumTarihi = musteri.DogumTarihi;
            newMusteri.Memleket = musteri.Memleket;
            newMusteri.Mail = musteri.Mail;
            newMusteri.Parola = musteri.Parola;
            newMusteri.TcNo = musteri.TcNo;

            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }
        public int Delete(Musteri musteri)
        {
            _context.Musteriler.Remove(musteri);
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }
        public Musteri GetById(int Id)
        {
            return _context.Musteriler.FirstOrDefault(x => x.MusteriId == Id);
        }
        public List<Musteri> GetAll()
        {
            return _context.Musteriler.ToList();
        }
    }
}
