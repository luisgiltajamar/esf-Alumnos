//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAlumnos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumnos
    {
        public Alumnos()
        {
            this.Curso = new HashSet<Curso>();
        }
    
     
    
        public virtual Nacionalidades Nacionalidades { get; set; }
        public virtual ICollection<Curso> Curso { get; set; }
    }
}
