using market_otomasyonu.dao;
using market_otomasyonu.enumaration;
using market_otomasyonu.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace market_otomasyonu.kontrol
{
    public class Kontrol
    {
      
        Repository repository;

        public Kontrol()
        {
            repository = new Repository();
        }

        public User login (string kullaniciadi, string sifre)
        {
            if(!string.IsNullOrEmpty(kullaniciadi) && !string.IsNullOrEmpty(sifre))
            {
                User result = repository.login(kullaniciadi,sifre);
                return result;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.eksikParametre;
                return user;
            }
        }

        public List<loginTable> getLoginTable()
        {
            List<loginTable> loginTableList = repository.getLoginTable();
            return loginTableList;
        }
        public LoginStatus doAuthentication (string kullaniciadi,string guvenliksorusu, string guvenlikcevabi)
        {
            if (!string.IsNullOrEmpty(kullaniciadi) && !string.IsNullOrEmpty(guvenliksorusu) && !string.IsNullOrEmpty(guvenlikcevabi))
            {
                LoginStatus result = repository.doAuthentication(kullaniciadi, guvenliksorusu, guvenlikcevabi);
                if (result == LoginStatus.basarili)
                {
                    return result;
                }
                else
                {
                    return LoginStatus.basarisiz;
                }
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus changepassword(string kullaniciadi, string sifre)
        {
            if(!string.IsNullOrEmpty(kullaniciadi) && !string.IsNullOrEmpty(sifre))
            {
               return repository.changepassword(kullaniciadi, sifre);//loginstatus.basarili
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus checkEmail(string kullaniciadi)
        {
            List<loginTable> loginTableList = repository.getLoginTable();
            bool kullaniciadiFound = false;

            foreach (loginTable loginTable in loginTableList)
            {
                if (loginTable.kullaniciadi.ToString().Trim().Equals(kullaniciadi.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    kullaniciadiFound = true;
                    break; 
                }
            }

            if (kullaniciadiFound)
            { 
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz; 
            }
        }


        public Urunler urunGetir(string barkod)
        {
            if(!string.IsNullOrEmpty (barkod))
            {
                return repository.urunGetir(barkod);
            }
            else
            {
                return null;
            }
        }

        public List<User> kullaniciGetir()
        {
            List<User> list = repository.Kullanicigetir();
            return list;
        }

        public LoginStatus kullaniciEkle(User user)
        {
            
            if (!string.IsNullOrEmpty(user.kullaniciadi) && !string.IsNullOrEmpty(user.sifre) && !string.IsNullOrEmpty(user.yetki) && !string.IsNullOrEmpty(user.email))
            {
                LoginStatus result = repository.kullaniciEkle(user); 
                return result;
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus kullaniciGuncelle(User user)
        {
            if (!string.IsNullOrEmpty(user.kullaniciadi) && !string.IsNullOrEmpty(user.sifre) && !string.IsNullOrEmpty(user.yetki) && !string.IsNullOrEmpty(user.email))
            {
                LoginStatus result = repository.kullaniciGuncelle(user);
                return result;
            }
            else
            {
                return LoginStatus.eksikParametre;
            }

        }

        public LoginStatus kullaniciSil(User user)
        {
            LoginStatus result = repository.kullaniciSil(user);
            return result;
        }

        public List<Urunler> TumUrunGetir()
        {
            return repository.TumUrunGetir();
        }

        public LoginStatus UrunEkle(Urunler urunler)
        {
            if (!string.IsNullOrEmpty(urunler.id) && !string.IsNullOrEmpty(urunler.urunismi) && !string.IsNullOrEmpty(urunler.barkodKod))
            {
               LoginStatus result = repository.UrunEkle(urunler);
                return result;
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus UrunGuncelle(Urunler urunler)
        {

            if (!string.IsNullOrEmpty(urunler.id) && !string.IsNullOrEmpty(urunler.urunismi) && !string.IsNullOrEmpty(urunler.barkodKod))
            {
                LoginStatus result = repository.UrunGuncelle(urunler);
                return result;
            }
            else
            {
                return LoginStatus.eksikParametre;
            }

        }



        public LoginStatus UrunSil(Urunler urunler)
        {
            if (!string.IsNullOrEmpty(urunler.id))
            {
                LoginStatus result = repository.UrunSil(urunler);
                return result;
            }
            else
            {
                return LoginStatus.eksikParametre;
            }

        }


    }



}
