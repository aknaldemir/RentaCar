using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entity
{
    public class Resim
    {
        public int ResimId { get; set; }
        public string ResimAdi { get; set; }

        public int AracId { get; set; }
        public Arac Arac { get; set; }

    }
}
