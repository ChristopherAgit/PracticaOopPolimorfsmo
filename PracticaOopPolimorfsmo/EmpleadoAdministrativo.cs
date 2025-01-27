using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOopPolimorfsmo
{
    public class EmpleadoAdministrativo : Empleado
    {
        public bool metas { get; set; }
        public decimal salarioEstandar { get; set; }

        public EmpleadoAdministrativo(string nombre, string apellido, string numeroSeguroSocial, decimal salarioEstadar, bool metas) : base(nombre, apellido, numeroSeguroSocial)
        {
            this.metas = metas;
            this.salarioEstandar = salarioEstadar >= 0 ? salarioEstadar : 0;
        }
        public override decimal CalcularSalario()
        {
            return metas ? salarioEstandar : salarioEstandar / 2;
        }
        public override string ToString() 
        {
            return $"{base.ToString()}, Salario base: {salarioEstandar}, Meta alcanzada: {metas}";
        }
    }
}
