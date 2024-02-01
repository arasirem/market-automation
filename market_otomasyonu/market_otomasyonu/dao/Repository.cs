using market_otomasyonu.enumaration;
using market_otomasyonu.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_otomasyonu.dao
{
    //cmd.ExecuteNonQuery ---> insert,delete,update
    //cmd.ExecuteScalar   ---> tek coulmn gelecekse
    //cmd.ExecuteReader   ---> selectlerde


    public class Repository
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;


        List<loginTable> loginTableList;

        public Repository() 
        {
            conn = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS01;Initial Catalog=market;User ID=sa; password=1");

        }

        public void baglantiayarla()
        {
            if(conn.State==System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                conn.Open();
            }
        }

        public User login (string kullaniciadi,string sifre)
        {
            conn.Open ();
            SqlCommand cmd = new SqlCommand("select * from loginTable where kullaniciadi = @kullaniciadi and sifre = @sifre", conn);
            cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
            cmd.Parameters.AddWithValue ("@sifre", sifre);
            dr = cmd.ExecuteReader();
          
            if (dr.Read())
            {
                User user= new User();
                user.id = (int) dr["id"];
                user.kullaniciadi = dr["kullaniciadi"].ToString();
                user.sifre = dr["sifre"].ToString() ;
                user.yetki = dr["yetki"].ToString();
                user.email = dr["email"].ToString();
                user.guvenlikSorusu = dr["guvenliksorusu"].ToString();
                user.guvenlikCevabi = dr["guvenlikcevabi"].ToString();
                user.status = LoginStatus.basarili; //kulad ve sifre dogruysa dr girer ve loginstatus basarili olmuş olur
                return user;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.basarisiz;
                return user;
            }
        }

        public List<loginTable> getLoginTable()
        {
            try
            {
                loginTableList = new List<loginTable>(); //yeni liste oluşturup bilgileri eklemek için
                conn.Open();
                SqlCommand cmd = new SqlCommand("guvenlikSorusuGetir_sp", conn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    loginTable login = new loginTable();
                    login.id = int.Parse(dr["id"].ToString());
                    login.kullaniciadi = dr["kullaniciadi"].ToString();
                    login.sifre = dr["sifre"].ToString();
                    login.yetki = dr["yetki"].ToString();
                    login.email = dr["email"].ToString();
                    login.guvenlikSorusu = dr["guvenliksorusu"].ToString();
                    login.guvenlikCevabi = dr["guvenlikcevabi"].ToString();

                    loginTableList.Add(login); //loginTableList koleksiyonuma ekledim
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu!");

            }
            return loginTableList;
        }


        public LoginStatus doAuthentication (string kullaniciadi, string guvenlikSorusu,string guvenlikCevabi)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count (*) from loginTable where kullaniciadi = @kullaniciadi and guvenliksorusu=@guvenliksorusu and guvenlikcevabi=@guvenlikcevabi", conn);
            cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
            cmd.Parameters.AddWithValue("@guvenliksorusu", guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikcevabi", guvenlikCevabi);
            returnvalue = (int) cmd.ExecuteScalar();
            conn.Close ();

            if ( returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
               return LoginStatus.basarisiz;
            }
        }


        public LoginStatus changepassword(string kullaniciadi, string sifre)
        {
            conn.Open ();
            SqlCommand cmd = new SqlCommand("sifreguncelle_sp",conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
            cmd.Parameters.AddWithValue ("@sifre", sifre);
            cmd.ExecuteNonQuery();
            conn.Close ();
            return LoginStatus.basarili;    
        }



        public string checkEmail(string kullaniciadi)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select email from loginTable where kullaniciadi = @kullaniciadi",conn);
            cmd.Parameters.AddWithValue("@kullaniciadi",kullaniciadi);
            string email = (string)cmd.ExecuteScalar();
            conn.Close();
            return email;
        }


        public Urunler urunGetir(string barkod)
        {
            conn.Open();
            cmd = new SqlCommand("select * from urunler where barkodKod = @barkod",conn);
            cmd.Parameters.AddWithValue("@barkod", barkod);
            dr = cmd.ExecuteReader();
            Urunler urunler = new Urunler();

            while (dr.Read())
            {
                urunler.id = dr["id"].ToString();
                urunler.qrkod = dr["qrkod"].ToString();
                urunler.barkodKod = dr["barkodKod"].ToString() ;
                urunler.urunismi = dr["urunismi"].ToString ();
                urunler.kilo = float.Parse(dr["kilo"].ToString ()) ;
                urunler.fiyat = float.Parse(dr["fiyat"].ToString());
             


            }
            conn.Close();
            return urunler;                
        }


        public List<User> Kullanicigetir()
            {
                conn.Open ();
                cmd = new SqlCommand("select * from loginTable", conn);
                dr = cmd.ExecuteReader();
                List<User> list = new List<User>();

                while (dr.Read())
                {
                    User user = new User();
                    user.id = int.Parse(dr["id"].ToString());
                    user.kullaniciadi = dr["kullaniciadi"].ToString () ;
                    user.sifre = dr["sifre"].ToString();
                    user.yetki = dr["yetki"].ToString();
                    user.bolge = dr["bölge"].ToString();
                    user.email = dr["email"].ToString ();
                    user.guvenlikSorusu = dr["guvenliksorusu"].ToString();
                    user.guvenlikCevabi = dr["guvenlikcevabi"].ToString();
                    list.Add(user);
                }

                conn.Close ();
                return list;
            }

        public List<string> bolgeGetir()
        {
            conn.Open();
            cmd = new SqlCommand("select bölge from loginTable", conn);
            dr = cmd.ExecuteReader();
            List<string> listBolge = new List<string>();
            while (dr.Read())
            {
                string bolge = dr["bölge"].ToString();
                listBolge.Add(bolge);
            }
            conn.Close();
            return listBolge;
        }


        public List <string> guvenliksorusuGetir()
        {
            conn.Open ();
            cmd = new SqlCommand("select guvenliksorusu from loginTable",conn);
            dr=cmd.ExecuteReader();

            List<string> listguvenliksorusu = new List<string>();
            while (dr.Read())
            {
                string guvenliksorusu = dr["guvenliksorusu"].ToString ();
                listguvenliksorusu.Add(guvenliksorusu);
            }
            conn.Close();
            return listguvenliksorusu;
        }


        public LoginStatus kullaniciEkle(User user)
        {
            conn.Open();
            cmd = new SqlCommand("kullaniciekle_sp", conn);
            cmd.CommandType =System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciadi", user.kullaniciadi);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@bolge", user.bolge);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@guvenliksorusu", user.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikcevabi", user.guvenlikCevabi);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            
            if (result == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }


        public LoginStatus kullaniciGuncelle (User user)
        {
            conn.Open();
            cmd = new SqlCommand("kullaniciguncelle_sp", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@kullaniciadi", user.kullaniciadi);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@bolge", user.bolge);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@guvenliksorusu", user.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikcevabi", user.guvenlikCevabi);
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            if (result == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }

        }

        public LoginStatus kullaniciSil(User user)
        {
            conn.Open();
            cmd = new SqlCommand("kullanicisil_sp", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", user.id);
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            if (result == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }


        public List<Urunler> TumUrunGetir()
        {
            conn.Open();
            cmd = new SqlCommand("select * from urunler",conn);
            dr = cmd.ExecuteReader();
            List<Urunler> listUrun = new List<Urunler>();
            while (dr.Read())
            {
                Urunler urunler = new Urunler();
                urunler.id = dr["id"].ToString();
                urunler.qrkod = dr["qrkod"].ToString();
                urunler.barkodKod = dr["barkodKod"].ToString();
                urunler.olusturmaTarihi = DateTime.Parse(dr["olusturma_tarih"].ToString());
                if (!string.IsNullOrEmpty(dr["guncellenme_tarih"].ToString()))
                {
                    urunler.guncellenmetarihi = DateTime.Parse(dr["guncellenme_tarih"].ToString());
                }
                urunler.urunismi = dr["urunismi"].ToString() ;
                urunler.kilo = float.Parse(dr["kilo"].ToString());
                urunler.fiyat = float.Parse(dr["fiyat"].ToString());
                if (!string.IsNullOrEmpty(dr["ciro"].ToString()))
                {
                    urunler.ciro = float.Parse(dr["ciro"].ToString());
                }

                listUrun.Add(urunler);
            }
            conn.Close();

            return listUrun;
        } 


        public LoginStatus UrunEkle(Urunler urunler)
        {
            conn.Open();

            //ID aynıysa başarısız, ID yoksa ekleme yapacak
            SqlCommand checkCmd = new SqlCommand("select count (*) from urunler where id = @id", conn);
            checkCmd.Parameters.AddWithValue("@id", urunler.id);
            int existingRecords = (int)checkCmd.ExecuteScalar();

            if (existingRecords > 0)
            {
                conn.Close();
                return LoginStatus.basarisiz;
            }
            else
            {
                cmd = new SqlCommand("UrunEkle", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", urunler.id);
                cmd.Parameters.AddWithValue("@qrkod", urunler.qrkod);
                cmd.Parameters.AddWithValue("@barkodKod", urunler.barkodKod);
                cmd.Parameters.AddWithValue("@olusturma_tarih", urunler.olusturmaTarihi);
                cmd.Parameters.AddWithValue("@guncellenme_tarih", urunler.guncellenmetarihi);
                cmd.Parameters.AddWithValue("@urunismi", urunler.urunismi);
                cmd.Parameters.AddWithValue("@kilo", urunler.kilo);
                cmd.Parameters.AddWithValue("@fiyat", urunler.fiyat);
                cmd.Parameters.AddWithValue("@ciro", urunler.ciro);
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (result == 1)
                {
                    return LoginStatus.basarili;
                }
                else
                {
                    return LoginStatus.basarisiz;
                }

            }
        }



        public LoginStatus UrunGuncelle(Urunler urunler)
        {
                conn.Open();
                cmd = new SqlCommand("UrunGuncelle_sp", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", urunler.id);
                cmd.Parameters.AddWithValue("@qrkod", urunler.qrkod);
                cmd.Parameters.AddWithValue("@barkodKod", urunler.barkodKod);
                cmd.Parameters.AddWithValue("@olusturma_tarih", urunler.olusturmaTarihi);
                cmd.Parameters.AddWithValue("@guncellenme_tarih", urunler.guncellenmetarihi);
                cmd.Parameters.AddWithValue("@urunismi", urunler.urunismi);
                cmd.Parameters.AddWithValue("@kilo", urunler.kilo);
                cmd.Parameters.AddWithValue("@fiyat", urunler.fiyat);
                cmd.Parameters.AddWithValue("@ciro", urunler.ciro);
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (result == 1)
                {
                    return LoginStatus.basarili;
                }
                else
                {
                    return LoginStatus.basarisiz;
                }
        }



        public LoginStatus UrunSil (Urunler urunler)
        {
            conn.Open();
            cmd = new SqlCommand("UrunSil_sp", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", urunler.id);
            int result = cmd.ExecuteNonQuery();
            conn.Close ();

            if (result == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }

    }
}
