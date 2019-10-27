using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Entity;

namespace RentACar.Dal.Concrete
{
    public class MusteriDal
    {
        public RentContext _context;
        public MusteriDal()
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
            var yeniMusteri = _context.Musteriler.Find(musteri.MusteriId);
            yeniMusteri.Ad = musteri.Ad;
            yeniMusteri.Soyad = musteri.Soyad;
            yeniMusteri.Fotokopi = musteri.Fotokopi;
            yeniMusteri.DogumTarihi = musteri.DogumTarihi;
            yeniMusteri.Memleket = musteri.Memleket;
            yeniMusteri.Mail = musteri.Mail;
            yeniMusteri.Parola = musteri.Parola;
            yeniMusteri.TcNo = musteri.TcNo;

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
            return _context.Musteriler.Find(Id);
        }
        public IQueryable<Musteri> GetAll()
        {
            return _context.Musteriler.AsQueryable();
        }
    }
}
