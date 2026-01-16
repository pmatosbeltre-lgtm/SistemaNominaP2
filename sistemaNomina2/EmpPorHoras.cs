using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaNomina2
{
    public class EmpPorHoras :Empleado
    {
        public decimal sueldohora { get; set; }
        public decimal horastrabajadas { get; set; }

        public override decimal CalcularSalario()
        {
            if (horastrabajadas <= 40)
            {
                return sueldohora * horastrabajadas;
            }
            else
            {
                return (sueldohora * 40) + (sueldohora * 1.5m * horastrabajadas - 40);
            }
        }
        public override string ToString()
        {
            return $"Empleado por horas: {base.ToString()}\n" +
                   $"Sueldo por hora: {sueldohora:C}\n" +
                   $"Horas trabajadas: {horastrabajadas:F2}\n" +
                   $"Salario Semanal: {CalcularSalario():C}";
        }
    }
}
