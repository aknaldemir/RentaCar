using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entity
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public int MusteriId { get; set; }
        public int AracId { get; set; }
        public DateTime? CikisTarihi { get; set; }
        public DateTime? DonusTarihi { get; set; }
        public decimal? ToplamFiyat { get; set; }
        public Musteri Musteri { get; set; }
        public Arac Arac { get; set; }

    }
}
