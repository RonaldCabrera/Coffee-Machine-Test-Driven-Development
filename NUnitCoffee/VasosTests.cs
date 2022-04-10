using MaquinaDeCafe;
using NUnit.Framework;

namespace NUnitCoffee
{
    public class VasosTests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void DeberiaVolverVerdaderoSiExistenVasos()
        {
            Vaso vasosPequenos = new(2,10);

            bool resultado = vasosPequenos.HasVasos(1);
            Assert.IsTrue(resultado);
        }

        [Test]
        public void DeberiaVolverFalsoSiNoExistenVasos()
        {
            Vaso vasosPequenos = new(1, 10);

            bool resultado = vasosPequenos.HasVasos(2);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void DeberiaRestarCantidadDeVasos()
        {
            Vaso vasosPequenos = new(5, 10);
            vasosPequenos.GiveVasos(1);

            Assert.AreEqual(4,vasosPequenos.GetCantidadVasos());
        }

    }
}
