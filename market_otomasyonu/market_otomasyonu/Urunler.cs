using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_otomasyonu
{
    public class Urunler
    {
        public string id { get; set; }
        public string qrkod { get; set; }
        public string barkodKod { get; set; }
        public DateTime olusturmaTarihi { get; set; }
        public DateTime guncellenmetarihi { get; set; }
        public string urunismi { get; set; }
        public float kilo { get; set; }
        public float fiyat { get; set;}
        public float ciro { get; set;}

    }
}
