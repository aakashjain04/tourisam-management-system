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
    
    public partial class TOUR_OFFER
    {
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> TourID { get; set; }
        public Nullable<int> OfferID { get; set; }
        public string OfferDate { get; set; }
        public byte[] UpdationDate { get; set; }
    
        public virtual COUNTRY COUNTRY { get; set; }
        public virtual OFFER OFFER { get; set; }
        public virtual TOUR TOUR { get; set; }
    }
}
