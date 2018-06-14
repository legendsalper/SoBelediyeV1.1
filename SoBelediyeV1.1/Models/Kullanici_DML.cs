using SoBelediyeV1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/**
Pzt kullanıcı ve adres insert update delete il ilçe salı
Çarşamba
Selectler
Her sınıf 4 metod
Try catch
Transaction scope
Linq from */
namespace SoBelediye.Models
{
    public class Kullanici_DML
    {

        public bool Kullanici_Insert(Kullanici usr) //insert update delete'e yapacan tüm bunları try cath'lerin de olacak işin zor 
        {
            using (SobelediyeEntities sb = new SobelediyeEntities())
            {
                Kullanici kl = new Kullanici();
                kl.Kullanici_ID = usr.Kullanici_ID;
                kl.Ad = usr.Ad;
                kl.Soyad = usr.Soyad;
                kl.Email = usr.Email;
                kl.Telefon = usr.Telefon;
                kl.Adres = usr.Adres;
                kl.EvrakID = usr.EvrakID;
                kl.YorumID = usr.YorumID;
                kl.Istek_ID = usr.Istek_ID;
                sb.Kullanici.Add(kl);
                sb.SaveChanges();
            }
            return true;
        }

        public bool Kullanici_Delete(Kullanici usr)
        {
            using (SobelediyeEntities sb = new SobelediyeEntities())
            {
                Kullanici kl = new Kullanici();
                kl.Kullanici_ID = usr.Kullanici_ID;
                kl.Ad = usr.Ad;
                kl.Soyad = usr.Soyad;
                kl.Email = usr.Email;
                kl.Telefon = usr.Telefon;
                kl.Adres = usr.Adres;
                kl.EvrakID = usr.EvrakID;
                kl.YorumID = usr.YorumID;
                kl.Istek_ID = usr.Istek_ID;
                sb.Kullanici.Remove(kl);
                sb.SaveChanges();
            }
            return true;
        }

        public bool Kullanici_Update(Kullanici usr)
        {
            using (SobelediyeEntities sb = new SobelediyeEntities())
            {
                //sb.Kullanici.
            }
            return true;
        }

        /*public List<Kullanici> KullaniciGetir()
        {
            //List<Kullanici> kl = (linq from);
            //return kl;
        }**/
    }
}