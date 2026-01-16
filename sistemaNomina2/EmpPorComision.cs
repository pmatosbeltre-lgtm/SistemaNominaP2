using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaNomina2
{
    public class EmpPorComision : Empleado
    {
        public decimal ventasBrutas { get; set; }
        public decimal tarifaComision { get; set; }
        public override decimal CalcularSalario()
        {
            return ventasBrutas * tarifaComision;
        }
        public override string ToString() 
        {
            return $"Empleado por comision: {base.ToString()}\n" +
                   $"Ventas brutas: {ventasBrutas:C}\n" +
                   $"Tarifa de comision: {tarifaComision:P}\n" +
                   $"Salario Semanal: {CalcularSalario():C}";
        }

    }
}
