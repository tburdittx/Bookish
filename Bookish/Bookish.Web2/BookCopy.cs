//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookish.Web2
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookCopy
    {
        public int BookCopyID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public string BookID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Books1 Books1 { get; set; }
        public virtual BookCopy BookCopy1 { get; set; }
        public virtual BookCopy BookCopy2 { get; set; }
        public virtual Books1 Books11 { get; set; }
    }
}
