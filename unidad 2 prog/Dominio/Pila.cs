using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_2_prog.Dominio
{
    internal class Pila : IColecction
    {
        public Pila()
        {

        }

        public bool EstaVacia(object[] arrString)
        {
            if (arrString == null)
            {
                return true;
            }
            return false;
        }

        public void AcomodarArray(object[] arrString)
        {

            if (arrString[0] == null)
            {
                for (int i = 0; i < arrString.Length-1; i++)
                {
                    object aux = arrString[i+1];
                    arrString[i] = aux;
                }
                arrString[arrString.Length-1] = null;
            }
        }

        public object Extraer(object[] arrString)
        {
            object obj = null;

            for (int i = 0; i < arrString.Length; i++)
            {

                if (arrString[i] != null)
                {
                    obj = arrString[i];
                    arrString[i] = null;
                    AcomodarArray(arrString);
                    break;
                }
            }

            return obj;
        }

        public object Primero(object[] arrString)
        {
            for (int i = 0; i < arrString.Length; i++)
            {
                if (arrString[i] != null)
                {
                    return arrString[i];
                }
            }
            return null;
        }

        public bool Aniadir(object[] arrString, object agregar)
        {
            if (arrString[arrString.Length - 1] == null)
            {
                arrString[arrString.Length - 1] = agregar;
                return true;
            }
            return false;
        }





    }
}
