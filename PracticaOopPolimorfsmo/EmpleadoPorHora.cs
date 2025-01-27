using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOopPolimorfsmo
{
    public class EmpleadoPorHora : Empleado
    {
        public decimal horasTrabajada { get; set; }
        public decimal tarifa { get; set; } = 800m;

        public EmpleadoPorHora(string nombre, string apellido, string seguroSocial, decimal horasTrabajada) : base(nombre, apellido, seguroSocial)
        {
           this.horasTrabajada = horasTrabajada >= 0 && horasTrabajada <= 200 ? horasTrabajada : 0;
        
        }
        public override decimal CalcularSalario()
        {
            if (horasTrabajada <= 40)
            {
                return tarifa * horasTrabajada;
            }
            else
            {
                return (40 * tarifa) + ((horasTrabajada - 40) * tarifa * 1.5m);
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Tarifa: {tarifa}, Horas trabajadas: {horasTrabajada})";
        }
    }
}
