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
    
    public partial class Curso
    {
        public Curso()
        {
            this.Profesores_Curso = new HashSet<Profesores_Curso>();
            this.Alumnos = new HashSet<Alumnos>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public System.DateTime inicio { get; set; }
        public System.DateTime fin { get; set; }
    
        public virtual ICollection<Profesores_Curso> Profesores_Curso { get; set; }
        public virtual ICollection<Alumnos> Alumnos { get; set; }
    }
}
