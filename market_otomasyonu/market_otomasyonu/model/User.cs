using market_otomasyonu.enumaration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_otomasyonu.model
{
    public class User
    {
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }
        public string bolge { get; set; }
        public string email { get; set; }
        public string guvenlikSorusu { get; set; }
        public string guvenlikCevabi { get; set; }
        public LoginStatus status { get; set; }
    }
}
