﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entity
{
    public class Marka
    {
        public int MarkaId { get; set; }
        public string MarkaAdi { get; set; }
        public List<Model> Modeller { get; set; }

    }
}
