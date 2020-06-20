//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourismMangementSystemService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class COUNTRY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COUNTRY()
        {
            this.CITies = new HashSet<CITY>();
            this.TOUR_COUNTRY = new HashSet<TOUR_COUNTRY>();
            this.TOUR_OFFER = new HashSet<TOUR_OFFER>();
        }
    
        public int CountryID { get; set; }
        public Nullable<int> RegionID { get; set; }
        public string CountryName { get; set; }
        public byte[] UpdationDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CITY> CITies { get; set; }
        public virtual REGION REGION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOUR_COUNTRY> TOUR_COUNTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOUR_OFFER> TOUR_OFFER { get; set; }
    }
}
