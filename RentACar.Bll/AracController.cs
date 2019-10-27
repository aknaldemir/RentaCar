using RentACar.Dal.Concrete;
using RentACar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Bll
{
    public class AracController
    {
        AracManager manager = new AracManager();
        public List<Arac> GetAll()
        {
           return manager.GetAll();
        }

    }
}
