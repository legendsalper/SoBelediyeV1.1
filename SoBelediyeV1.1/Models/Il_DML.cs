using SoBelediyeV1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoBelediye.Models
{
    public class Il_DMS
    {

        public bool il_Insert(Il usr)
        {
            using (SobelediyeEntities sb = new SobelediyeEntities())
            {
                Il il = new Il();
                il.Il_ID = usr.Il_ID;
                il.Il1 = usr.Il1;
                il.Ilce_ID = usr.Ilce_ID;
                il.Kullanici_ID = usr.Kullanici_ID;
                sb.Il.Add(il);
                sb.SaveChanges();
            }
            return true;
        }

        public bool il_Delete(Il usr)
        {
            using (SobelediyeEntities sb = new SobelediyeEntities())
            {
                Il il = new Il();
                il.Il_ID = usr.Il_ID;
                il.Il1 = usr.Il1;
                il.Ilce_ID = usr.Ilce_ID;
                il.Kullanici_ID = usr.Kullanici_ID;
                sb.Il.Remove(il);
                sb.SaveChanges();
            }
            return true;
        }

        public bool il_Update(Il usr)
        {
            using (SobelediyeEntities sb = new SobelediyeEntities())
            {

            }
            return true;
        }
    }
}