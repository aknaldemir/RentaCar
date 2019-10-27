using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Entity;

namespace RentACar.Dal.Concrete
{
   /* public class ResimManager
    {
        private RentContext _context;
        public ResimManager()
        {
            _context = new RentContext();
        }
    
        public int etkilenenKayit;
        public int Add(Resim resim)
        {
            _context.Resimler.Add(resim);
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }
        //public int Update(Resim resim)
        //{
        //    Resim newResim = _context.Resimler.FirstOrDefault(x => x.AracId == resim.AracId);
        //    newResim.SasiNo = arac.SasiNo;
        //    etkilenenKayit = _context.SaveChanges();
        //    return etkilenenKayit;

        //}
        public int Delete(Resim resim)
        {
            _context.Resimler.Remove(resim);
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }
        public List<Resim> GetByAracId(int AracId)
        {
            return _context.Resimler.Where(x => x.AracId == AracId).ToList();
        }
    }*/
}
