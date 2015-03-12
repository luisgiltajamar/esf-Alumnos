using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAlumnos.Models
{
   public partial class Alumnos
    {
       public List<int> idCursos { get; set; }

       [RegularExpression("^[0-9]{8}[A-Z]{1}$")]
       [DisplayName("DNI")]
       public string dni { get; set; }
       [DisplayName("Nombre")]
       public string nombre { get; set; }
       [DisplayName("Apellidos")]
       public string apellidos { get; set; }
       [DisplayName("Fecha de nacimiento")]
       [DataType(DataType.Date)]
       public Nullable<System.DateTime> fechaNacimiento { get; set; }
       [DisplayName("Nacionalidad")]
       public int idNacionalidad { get; set; }
    }
}
