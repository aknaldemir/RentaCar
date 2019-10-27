using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entity
{
    public class Arac
    {
        public int AracId { get; set; }
        public string SasiNo { get; set; }
        public int Kilometre { get; set; }
        public decimal GunlukFiyat { get; set; }
        public int ModelId { get; set; }
        public Model Model{ get; set; }
        public List<Resim> Resimler { get; set; }
        public List<Rezervasyon> Rezervasyonlar { get; set; }

        
    }
}
