using MaquinaDeCafe;
using NUnit.Framework;

namespace NUnitCoffee
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void DeberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new(10);

            bool resultado = cafetera.HasCafe(5);

            Assert.IsTrue(resultado);
        }

        [Test]
        public void DeberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new(10);

            bool resultado = cafetera.HasCafe(11);

            Assert.IsFalse(resultado);
        }

        [Test]
        public void DeberiaRestarAlCafe()
        {
            Cafetera cafetera = new(10);

            cafetera.GiveCafe(7);

            Assert.AreEqual(3, cafetera.GetCantidadDeCafe());
        }
    }
}