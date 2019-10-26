using RentACar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Dal.Concrete
{
    public  class RezervasyonManager
    {
        private RentContext _context;
        public RezervasyonManager()
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
            Rezervasyon newRezervasyon = _context.Rezervasyonlar.FirstOrDefault(x => x.RezervasyonId == rezervasyon.RezervasyonId);
            newRezervasyon.MusteriId = rezervasyon.MusteriId;
            newRezervasyon.AracId = rezervasyon.AracId;
            newRezervasyon.CikisTarihi = rezervasyon.CikisTarihi;
            newRezervasyon.DonusTarihi = rezervasyon.DonusTarihi;
            newRezervasyon.ToplamFiyat = rezervasyon.ToplamFiyat;
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
            return _context.Rezervasyonlar.FirstOrDefault(x => x.RezervasyonId == Id);
        }
        public List<Rezervasyon> GetAll()
        {
            return _context.Rezervasyonlar.ToList();
        }
    }
}
