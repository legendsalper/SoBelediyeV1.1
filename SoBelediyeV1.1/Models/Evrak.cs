//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoBelediyeV1._1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evrak
    {
        public int EvrakID { get; set; }
        public string Desc { get; set; }
        public string Baslik { get; set; }
        public string Tur { get; set; }
        public System.DateTime Tarih { get; set; }
        public int Kullanici_ID { get; set; }
        public Nullable<int> KurumYetkili_ID { get; set; }
        public Nullable<int> Adres_ID { get; set; }
        public Nullable<int> Istek_ID { get; set; }
        public Nullable<int> Foto_ID { get; set; }
        public Nullable<int> Video_ID { get; set; }
    
        public virtual Adres Adres { get; set; }
        public virtual Foto Foto { get; set; }
        public virtual IstekSikayet IstekSikayet { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual KurumYetkili KurumYetkili { get; set; }
        public virtual Video Video { get; set; }
    }
}
