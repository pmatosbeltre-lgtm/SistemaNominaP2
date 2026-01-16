using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaNomina2
{
    public class EmpAsalariado : Empleado
    {
        public decimal salarioSemanal { get; set; }

        public override decimal CalcularSalario()
        {
            return salarioSemanal;
        }
        public override string ToString()
        {
            return $"Empleado asalariado: {base.ToString()}\n" +
                   $"Salario semanal: {salarioSemanal:C}\n" +
                   $"Salario Semanal: {CalcularSalario():C}";
        }
    }
}
