//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Certificado
    {
        public int Id { get; set; }
        public int Tempo { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
    }
}