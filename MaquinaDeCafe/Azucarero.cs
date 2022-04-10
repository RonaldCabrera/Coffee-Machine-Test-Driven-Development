using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafe
{
    public class Azucarero
    {

        private int cantidadDeAzucar;

        public Azucarero(int v)
        {
            SetCantidadAzucar(v);
        }

        public void SetCantidadAzucar(int cantidad)
        {
            cantidadDeAzucar = cantidad;
        }

        public int GetCantidadAzucar()
        {
            return cantidadDeAzucar;
        }

        public bool HasAzucar(int cantidad)
        {
            return (cantidadDeAzucar >= cantidad);
        }

        public bool GiveAzucar(int cantidad)
        {
            if (HasAzucar(cantidad))
            {
                cantidadDeAzucar -= cantidad;
                return true;
            }
            return false;
        }

    }
}
