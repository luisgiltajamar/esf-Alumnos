using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAlumnos.Models
{
    public  class BuscadorAlumnos
    {

        CursosEntities db=new CursosEntities();

        public List<Alumnos> GetPorApellidos(String apellidos)
        {

            var datos = from o in db.Alumnos
                where o.apellidos == apellidos && o.nombre=="Luis"
                select o;

            return datos.ToList();


        }

        public List<Alumnos> GetPorApellidosLamda(String apellidos)
        {
            

            var datos = db.Alumnos.Where(o => o.apellidos == apellidos || o.nombre=="Luis" 
                && o.Nacionalidades.nombre=="Ingles");

            return datos.ToList();


        }

    }
}











