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
    
    public partial class TOUR_ENQUIRY
    {
        public Nullable<int> UserId { get; set; }
        public string UserEmail { get; set; }
        public Nullable<int> Contact { get; set; }
        public byte[] UpdationDate { get; set; }
    
        public virtual USER USER { get; set; }
    }
}
