using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOopPolimorfsmo
{
   public abstract class Empleado
    {
     private string nombre { get; set; }
     private string apellido { get; set; }
     private string seguroSocial { get; set; }

        public Empleado(String nombre, string apellido, String numeroSeguroSocial) 
        {
         this.nombre = nombre;
         this.apellido = apellido;   
         this.seguroSocial = seguroSocial;
        }

        public override string ToString()
        {
            return string.Format(nombre,apellido,seguroSocial);
        }
        public abstract decimal CalcularSalario();
    }
}
