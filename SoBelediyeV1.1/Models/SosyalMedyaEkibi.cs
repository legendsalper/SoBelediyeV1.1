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
    
    public partial class SosyalMedyaEkibi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SosyalMedyaEkibi()
        {
            this.IstekSikayet = new HashSet<IstekSikayet>();
            this.Yorumlar = new HashSet<Yorumlar>();
        }
    
        public int YetkiliID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }
        public string Nick { get; set; }
        public string Cevap { get; set; }
        public int Onay_Durum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IstekSikayet> IstekSikayet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorumlar> Yorumlar { get; set; }
    }
}
