using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entity
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string TcNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Memleket { get; set; }
        public string Fotokopi { get; set; }
        public string Mail { get; set; }
        public string Parola { get; set; }
        public List<Rezervasyon> Rezervasyonlar { get; set; }


    }
}
