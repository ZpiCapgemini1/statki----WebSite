//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZpiCapgeminiProduction5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class POTYCZKI
    {
        public int ID_potyczki { get; set; }
        public string Login { get; set; }
        public string Wynik { get; set; }
    
        public virtual GRACZ GRACZ { get; set; }
    }
}
