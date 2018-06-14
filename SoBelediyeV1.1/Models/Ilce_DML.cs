using SoBelediyeV1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoBelediye.Models
{
    public class Ilce_DMS
    {
        public bool ilce_Insert(Ilce usr)
        {
            using (SobelediyeEntities sb = new SobelediyeEntities())
            {
                Ilce ilcec = new Ilce();
                ilcec.Ilce_ID = usr.Ilce_ID;
                ilcec.Ilce1 = usr.Ilce1;
                sb.Ilce.Add(ilcec);
                sb.SaveChanges();
            }
            return true;
        }

        public bool ilce_Delete(Ilce usr)
        {
            using (SobelediyeEntities sb = new SobelediyeEntities())
            {
                Ilce ilcec = new Ilce();
                ilcec.Ilce_ID = usr.Ilce_ID;
                ilcec.Ilce1 = usr.Ilce1;
                sb.Ilce.Remove(ilcec);
                sb.SaveChanges();
            }
            return true;
        }

        public bool ilce_Update(Ilce usr)
        {
            using (SobelediyeEntities sb = new SobelediyeEntities())
            {

            }
            return true;
        }
    }
}