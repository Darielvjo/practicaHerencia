using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP
{
    public class Empleado : MiembroDeLaComunidad
    {
        public string? Cargo { get; set; }
        public double Salario { get; set; }
    }
}
