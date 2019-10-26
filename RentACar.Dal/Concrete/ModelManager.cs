using RentACar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Dal.Concrete
{
    public class ModelManager
    {
        private RentContext _context;
        public ModelManager()
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
            Model newModel = _context.Modeller.FirstOrDefault(x => x.ModelId == model.ModelId);
            newModel.ModelAdi = model.ModelAdi;
            newModel.Yil = model.Yil;
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
            return _context.Modeller.FirstOrDefault(x => x.ModelId == Id);
        }
        public List<Model> GetAll()
        {
            return _context.Modeller.ToList();
        }
    }
}
