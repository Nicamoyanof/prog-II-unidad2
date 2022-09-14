using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_2_prog.Datos
{
    internal class Parametro
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public Parametro(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}
