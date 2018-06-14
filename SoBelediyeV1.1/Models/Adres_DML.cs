using SoBelediyeV1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoBelediye.Models
{
    public class Adres_DML
    {
        public bool adres_Insert(Adres usr)
        {
            using (SobelediyeEntities sb = new SobelediyeEntities())
            {
                Adres adres = new Adres();
                adres.AdresID = usr.AdresID;
                adres.Sokak = usr.Sokak;
                adres.Mahalle = usr.Mahalle;
                adres.Koy = usr.Koy;
                adres.Tarif = usr.Tarif;
                adres.Kullanici_ID = usr.Kullanici_ID;
                adres.Il_ID = usr.Il_ID;
                sb.Adres.Add(adres);
                sb.SaveChanges();
            }
            return true;
        }

        public bool adres_Delete(Adres usr)
        {
            using (SobelediyeEntities sb = new SobelediyeEntities())
            {
                Adres adres = new Adres();
                adres.AdresID = usr.AdresID;
                adres.Sokak = usr.Sokak;
                adres.Mahalle = usr.Mahalle;
                adres.Koy = usr.Koy;
                adres.Tarif = usr.Tarif;
                adres.Kullanici_ID = usr.Kullanici_ID;
                adres.Il_ID = usr.Il_ID;
                sb.Adres.Remove(adres);
                sb.SaveChanges();
            }
            return true;
        }

        public bool adres_Update(Adres usr)
        {
            using (SobelediyeEntities sb = new SobelediyeEntities())
            {

            }
            return true;
        }
    }
}