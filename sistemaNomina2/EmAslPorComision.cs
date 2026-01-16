using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaNomina2
{
    public class EmAslPorComision : Empleado
    {
        public decimal salarioBase { get; set; }
        public decimal ventasBrutas { get; set; }
        public decimal tarifaComision { get; set; }

         
        public override decimal CalcularSalario()
        {
            return (ventasBrutas * tarifaComision) + salarioBase + (salarioBase * 0.10m);
        }
        public override string ToString() 
        { 
            return $"Empleado asalariado por comision: {base.ToString()}\n" +
                   $"Salario base: {salarioBase:C}\n" +
                   $"Ventas brutas: {ventasBrutas:C}\n" +
                   $"Tarifa de comision: {tarifaComision:P}\n" +
                   $"Salario Semanal: {CalcularSalario():C}";
        }
    }
}
