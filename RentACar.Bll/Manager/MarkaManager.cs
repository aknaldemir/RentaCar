using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Dal.Concrete;
using RentACar.Entity;

namespace RentACar.Bll.Manager
{
    public class MarkaManager
    {
        private MarkaDal _markaDal;
        public MarkaManager()
        {
            _markaDal=new MarkaDal();
        }

        public IQueryable<Marka> GetAll()
        {
            return _markaDal.GetAll();
        }



    }
}
