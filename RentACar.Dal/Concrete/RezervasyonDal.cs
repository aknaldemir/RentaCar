using RentACar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Dal.Concrete
{
    public  class RezervasyonDal
    {
        public RentContext _context;
        public RezervasyonDal()
        {
            _context = new RentContext();
        }
        public int etkilenenKayit;
        public int Add(Rezervasyon rezervasyon)
        {
            _context.Rezervasyonlar.Add(rezervasyon);
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }
        public int Update(Rezervasyon rezervasyon)
        {
            var yeniRezervasyon = _context.Rezervasyonlar.Find(rezervasyon.RezervasyonId);
            yeniRezervasyon.MusteriId = rezervasyon.MusteriId;
            yeniRezervasyon.AracId = rezervasyon.AracId;
            yeniRezervasyon.CikisTarihi = rezervasyon.CikisTarihi;
            yeniRezervasyon.DonusTarihi = rezervasyon.DonusTarihi;
            yeniRezervasyon.ToplamFiyat = rezervasyon.ToplamFiyat;
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }
        public int Delete(Rezervasyon rezervasyon)
        {
            _context.Rezervasyonlar.Remove(rezervasyon);
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }
        public Rezervasyon GetById(int Id)
        {
            return _context.Rezervasyonlar.Find(Id);
        }
        public IQueryable<Rezervasyon> GetAll()
        {
            return _context.Rezervasyonlar.AsQueryable();
        }
    }
}
