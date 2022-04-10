using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafe
{
    public class MaquinaDeCafe
    {

        private Cafetera cafetera;
        private Vaso vasosPequenos;
        private Vaso vasosMedianos;
        private Vaso vasosGrandes;
        private Azucarero azucar;

        public Vaso GetTipoVaso(string tipo)
        {
            switch (tipo)
            {
                case "pequeño":
                    return vasosPequenos;
                case "mediano":
                    return vasosMedianos;
                case "grande":
                    return vasosGrandes;
                default:
                    return vasosPequenos;
            }
        }

        public dynamic GetVasoDeCafe(Vaso tipoDeVaso, int cantidadDeVasos, int cantidadDeAzucar)
        {
            if (cantidadDeVasos == 99 && cantidadDeAzucar == 99)
            {
                return "Felicitaciones";
            }

            if (!tipoDeVaso.GiveVasos(cantidadDeVasos))
            {
                return "No hay vasos";
            }

            if (!azucar.GiveAzucar(cantidadDeAzucar))
            {
                return "No hay azucar";
            }

            if (!cafetera.GiveCafe(tipoDeVaso.GetContenido())){
                return "No hay cafe";
            }

            return tipoDeVaso;

        }

        public void SetCafetera(Cafetera cafet)
        {
            cafetera = cafet;
        }

        public Cafetera GetCafetera()
        {
            return cafetera;
        }

        public void SetVasosPequenos(Vaso vaso)
        {
            vasosPequenos = vaso;
        }

        public Vaso GetVasosPequenos()
        {
            return vasosPequenos;
        }

        public void SetVasosMedianos(Vaso vaso)
        {
            vasosMedianos = vaso;
        }

        public Vaso GetVasosMedianos()
        {
            return vasosMedianos;
        }

        public void SetVasosGrandes(Vaso vaso)
        {
            vasosGrandes = vaso;
        }

        public Vaso GetVasosGrandes()
        {
            return vasosGrandes;
        }

        public void SetAzucarero(Azucarero azucarDos)
        {
            azucar = azucarDos;
        }

        public Azucarero GetAzucarero()
        {
            return azucar;
        }

    }
}