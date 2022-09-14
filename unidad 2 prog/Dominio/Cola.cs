using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_2_prog.Dominio
{
    internal class Cola
    {
        public Cola()
        {

        }

        public bool EstaVacia(List<object> arrString)
        {
            if (arrString.Count == 0)
            {
                return true;
            }
            return false;
        }


        public object Extraer(List<object> arrString)
        {
            object obj = arrString[0];

            arrString.RemoveAt(0);

            return obj;
        }

        public object Primero(List<object> arrString)
        {
            for (int i = 0; i < arrString.Count; i++)
            {
                if (arrString[i] != null)
                {
                    return arrString[i];
                }
            }
            return null;
        }

        public bool Aniadir(List<object> arrString, object agregar)
        {
            try
            {
                arrString.Insert(0, agregar);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
