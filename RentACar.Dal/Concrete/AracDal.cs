using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Entity;

namespace RentACar.Dal.Concrete
{
    public class AracDal
    {
        public RentContext _context;
        public AracDal()
        {
            _context = new RentContext();
        }

        public int etkilenenKayit;

        public int Add(Arac arac)
        {
            _context.Araclar.Add(arac);
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }

        public int Update(Arac arac)
        {
            // _context.Entry(arac).State = EntityState.Modified;

            var yeniArac = _context.Araclar.Find(arac.AracId);
            yeniArac.SasiNo = arac.SasiNo;
            yeniArac.Kilometre = arac.Kilometre;
            yeniArac.GunlukFiyat = arac.GunlukFiyat;
            yeniArac.ModelId = arac.ModelId;
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;

        }

        public int Delete(Arac arac)
        {
            _context.Araclar.Remove(arac);
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }

        public Arac GetById(int Id)
        {
            return _context.Araclar.Find(Id);
        }

        public IQueryable<Arac> GetAll()
        {
            var araclar = _context.Araclar.AsQueryable();
            return araclar;
        }
    }
}
