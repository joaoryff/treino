//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HitechEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OId { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> ReqDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public Nullable<int> CId { get; set; }
        public Nullable<int> QoO { get; set; }
        public Nullable<double> Total { get; set; }
        public string ISBN { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
