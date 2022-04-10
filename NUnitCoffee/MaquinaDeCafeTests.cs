using NUnit.Framework;
using MaquinaDeCafe;

namespace NUnitCoffee
{
    public class MaquinaDeCafeTests
    {
        Cafetera cafetera;
        Vaso vasosPequenos;
        Vaso vasosMedianos;
        Vaso vasosGrandes;
        Azucarero azucarero;
        MaquinaDeCafe.MaquinaDeCafe maquina;


        [SetUp]
        public void Setup()
        {
            cafetera = new(50);
            vasosPequenos = new(5, 10);
            vasosMedianos = new(5, 20);
            vasosGrandes = new(5, 30);
            azucarero = new(20);

            maquina = new();
            maquina.SetCafetera(cafetera);
            maquina.SetVasosPequenos(vasosPequenos);
            maquina.SetVasosMedianos(vasosMedianos);
            maquina.SetVasosGrandes(vasosGrandes);
            maquina.SetAzucarero(azucarero);
        }

        [Test]
        public void DeberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquina.GetTipoVaso("pequeño");
            Assert.AreEqual(vasosPequenos, vaso);
        }

        [Test]
        public void DeberiaDevolverUnVasoMediano()
        {
            Vaso vaso = maquina.GetTipoVaso("mediano");
            Assert.AreEqual(vasosMedianos, vaso);
        }

        [Test]
        public void DeberiaDevolverUnVasoGrande()
        {
            Vaso vaso = maquina.GetTipoVaso("grande");
            Assert.AreEqual(vasosGrandes, vaso);
        }

        [Test]
        public void DeberiaDevolverNoHayVasos()
        {
            Vaso vaso = maquina.GetTipoVaso("pequeño");
            string resultado = maquina.GetVasoDeCafe(vaso, 10, 2);


            Assert.AreEqual("No hay vasos", resultado);
        }

        [Test]
        public void DeberiaDevolverNoHayCafe()
        {
            cafetera = new(5);
            maquina.SetCafetera(cafetera);

            Vaso vaso = maquina.GetTipoVaso("pequeño");
            string resultado = maquina.GetVasoDeCafe(vaso, 1, 2);


            Assert.AreEqual("No hay cafe", resultado);
        }

        [Test]
        public void DeberiaDevolverNoHayAzucar()
        {
            azucarero = new(2);
            maquina.SetAzucarero(azucarero);

            Vaso vaso = maquina.GetTipoVaso("pequeño");
            string resultado = maquina.GetVasoDeCafe(vaso, 1, 3);


            Assert.AreEqual("No hay azucar", resultado);
        }

        [Test]
        public void DeberiaRestarCafe()
        {
            Vaso vaso = maquina.GetTipoVaso("pequeno");
            maquina.GetVasoDeCafe(vaso, 1, 3);

            int resultado = maquina.GetCafetera().GetCantidadDeCafe();

            Assert.AreEqual(40, resultado);
        }

        [Test]
        public void DeberiaRestarVaso()
        {
            Vaso vaso = maquina.GetTipoVaso("pequeno");
            maquina.GetVasoDeCafe(vaso, 1, 3);

            int resultado = maquina.GetVasosPequenos().GetCantidadVasos();

            Assert.AreEqual(4, resultado);
        }

        [Test]
        public void DeberiaRestarAzucar()
        {
            Vaso vaso = maquina.GetTipoVaso("pequeno");
            maquina.GetVasoDeCafe(vaso, 1, 3);

            int resultado = maquina.GetAzucarero().GetCantidadAzucar();

            Assert.AreEqual(17, resultado);
        }

        [Test]
        public void DeberiaDevolverFelicitaciones()
        {
            Vaso vaso = maquina.GetTipoVaso("pequeno");
            string resultado = maquina.GetVasoDeCafe(vaso, 99, 99);

            Assert.AreEqual("Felicitaciones", resultado);
        }

    }
}
