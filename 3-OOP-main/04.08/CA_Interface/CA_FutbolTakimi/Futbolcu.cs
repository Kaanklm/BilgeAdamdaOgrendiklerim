﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FutbolTakimi
{
    public abstract class Futbolcu
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string FormaNumarasi { get; set; }

        public abstract int SutGucu { get; set; }
        public int Agresiflik { get; set; }
        public int TopCalma { get; set; }
        public int Kondisyon { get; set; }

    }
}
