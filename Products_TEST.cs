//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFSklep
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products_TEST
    {
        public int ProdID { get; set; }
        public Nullable<decimal> Price { get; set; }
        public int SubID { get; set; }
        public int ManID { get; set; }
        public string Model { get; set; }
        public string Specification { get; set; }
    
        public virtual Manufacturers Manufacturers { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}