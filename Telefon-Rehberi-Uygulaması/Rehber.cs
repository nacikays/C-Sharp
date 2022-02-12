using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rehber_proje1
{
    class Rehber
        {
            public string Ad { get; set; }
            
            public string Soyad { get; set; }
            
            public string Numara { get; set; }
            public Rehber(string Ad, string Soyad, string Numara)
            {
                this.Ad = Ad;
                this.Soyad = Soyad;
                this.Numara = Numara;
            }
        }  
}
