using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafe
{
    public class Vaso
    {

        private int cantidadVasos;

        private int contenido;

        public Vaso(int v1, int v2)
        {
            cantidadVasos = v1;
            contenido = v2;
        }

        public void SetCantidadVasos(int cantidad)
        {
            cantidadVasos = cantidad;
        }

        public int GetCantidadVasos()
        {
            return cantidadVasos;
        }

        public void SetContenido(int cantidad)
        {
            contenido = cantidad;
        }

        public int GetContenido()
        {
            return contenido;
        }

        public bool HasVasos(int cantidad)
        {
            return cantidadVasos >= cantidad;
        }

        public bool GiveVasos(int cantidad)
        {
            if (HasVasos(cantidad))
            {
                cantidadVasos -= cantidad;
                return true;
            }
            return false;
        }
    }
}
