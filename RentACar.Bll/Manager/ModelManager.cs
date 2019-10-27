using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Dal.Concrete;
using RentACar.Entity;

namespace RentACar.Bll.Manager
{
    public class ModelManager
    {
        private ModelDal _modelDal;
        public ModelManager()
        {
            _modelDal = new ModelDal();
        }

        public IQueryable<Model> GetAll()
        {
            return _modelDal.GetAll();
        }



    }
}
