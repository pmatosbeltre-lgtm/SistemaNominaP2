using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaNomina2
{
    public abstract class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nss { get; set; }

        public abstract decimal CalcularSalario();

        public override string ToString()
        {
            return $"{nombre} {apellido}\nNSS: {nss}";
        }
    }
}
