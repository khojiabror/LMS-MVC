//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMSWebMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double CycleTime { get; set; }
        public int ShopID { get; set; }
    
        public virtual SHOP SHOP { get; set; }
    }
}
