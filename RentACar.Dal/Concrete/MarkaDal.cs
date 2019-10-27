using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Entity;

namespace RentACar.Dal.Concrete
{
    public class MarkaDal
    {
        public RentContext _context;
        public MarkaDal()
        {
            _context = new RentContext();
        }
    
        public int etkilenenKayit;
        public int Add(Marka marka)
        {
            _context.Markalar.Add(marka);
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }
        public int Update(Marka marka)
        {
            Marka yeniMarka = _context.Markalar.Find(marka.MarkaId);
            yeniMarka.MarkaAdi = marka.MarkaAdi;
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;

        }
        public int Delete(Marka marka)
        {
            _context.Markalar.Remove(marka);
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }
        public Marka GetById(int Id)
        {
            return _context.Markalar.Find(Id);
        }
        public IQueryable<Marka> GetAll()
        {
            return _context.Markalar.AsQueryable();
        }
    }
}
