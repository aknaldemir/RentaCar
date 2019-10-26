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
        public string Kilometre { get; set; }
        public decimal GunlukFiyat { get; set; }
        public int ModelId { get; set; }
        public Model Model{ get; set; }
        public List<Resim> Resimler { get; set; }
        ///dfdfdfdfdfdf
        public int MyProperty { get; set; }

<<<<<<< HEAD
        public string Degisiklik { get; set; }

        public int deneeeeeeee { get; set; }

=======
        public string deneme { get; set; }
>>>>>>> 3fb229801f28f9adb4c51c25ae67c845f9700c0e
    }
}
