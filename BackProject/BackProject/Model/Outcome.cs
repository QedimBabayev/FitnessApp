//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Outcome
    {
        public int Id { get; set; }
        public Nullable<long> Tools { get; set; }
        public Nullable<long> Cleaning { get; set; }
        public Nullable<int> WhichService { get; set; }
        public Nullable<System.DateTime> Mont { get; set; }
    
        public virtual Service Service { get; set; }
    }
}