using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Entity;

namespace RentACar.Dal.Concrete
{
    public class AracManager
    {
        private RentContext _context;
        public AracManager()
        {
            _context = new RentContext();
        }
    
        public int etkilenenKayit;
        public int Add(Arac arac)
        {
            _context.Araclar.Add(arac);
            etkilenenKayit = _context.SaveChanges();
            //ResimManager manager=new ResimManager();
            //resim.AracId = arac.AracId;
            //manager.Add(resim);
            return etkilenenKayit;
        }
        public int Update(Arac arac)
        {
            Arac newArac = _context.Araclar.FirstOrDefault(x => x.AracId == arac.AracId);
            newArac.SasiNo = arac.SasiNo;
            newArac.Kilometre = arac.Kilometre;
            newArac.GunlukFiyat = arac.GunlukFiyat;
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
            return _context.Araclar.FirstOrDefault(x => x.AracId == Id);
        }
        public List<Arac> GetAll()
        {
            return _context.Araclar.ToList();
        }
    }
}
