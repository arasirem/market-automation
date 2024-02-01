using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_otomasyonu.model
{
    public class loginTable
    {
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }
        public string email { get; set; }
        public string guvenlikSorusu { get; set; }
        public string guvenlikCevabi { get; set; }

    }
}
