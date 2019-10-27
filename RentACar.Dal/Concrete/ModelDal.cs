using RentACar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Dal.Concrete
{
    public class ModelDal
    {
        public RentContext _context;
        public ModelDal()
        {
            _context = new RentContext();
        }

        public int etkilenenKayit;
        public int Add(Model model)
        {
            _context.Modeller.Add(model);
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }
        public int Update(Model model)
        {
            Model yeniModel = _context.Modeller.Find(model.ModelId);
            yeniModel.ModelAdi = model.ModelAdi;
            yeniModel.Yil = model.Yil;
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;

        }
        public int Delete(Model model)
        {
            _context.Modeller.Remove(model);
            etkilenenKayit = _context.SaveChanges();
            return etkilenenKayit;
        }
        public Model GetById(int Id)
        {
            return _context.Modeller.Find(Id);
        }
        public IQueryable<Model> GetAll()
        {
            return _context.Modeller.AsQueryable();
        }
    }
}
