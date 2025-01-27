using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOopPolimorfsmo
{
    public class EmpleadoPorContrato : Empleado
    {
        public decimal salarioMensual { get; set; }
        public bool Meta { get; set; }
        public EmpleadoPorContrato(string nombre, string apellido, string seguroSocial, decimal salarioMensual, bool meta) : base(nombre, apellido, seguroSocial)
        {
            this.salarioMensual = salarioMensual >= 0 ? salarioMensual : 0;
            this.Meta = meta; 
        }
        public override decimal CalcularSalario()
        { 
            return Meta ? salarioMensual : salarioMensual/2;
        }
        public override string ToString() 
        {
            return $"{base.ToString()},Salario mensual:{salarioMensual}, Alcanzola meta: {Meta}";
        }
    }
}
