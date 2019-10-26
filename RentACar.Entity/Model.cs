using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entity
{
    public class Model
    {
        public int ModelId { get; set; }
        public string ModelAdi { get; set; }
        public short Yil { get; set; }

        public int MarkaId { get; set; }
        public Marka Marka{ get; set; }
        public List<Arac> Araclar { get; set; }

    }
}
