using NUnit.Framework;
using MaquinaDeCafe;

namespace NUnitCoffee
{
    public class AzucareroTests
    {
        Azucarero azucarero;

        [SetUp]
        public void Setup()
        {
            azucarero = new Azucarero(10);
        }

        [Test]
        public void DeberiaDevolverVerdaderoSiHaySuficienteAzucar()
        {
            bool resultado = azucarero.HasAzucar(5);
            Assert.IsTrue(resultado);

            resultado = azucarero.HasAzucar(10);
            Assert.IsTrue(resultado);
        }

        [Test]
        public void DeberiaDevolverFalsoPorqueNoHaySuficienteAzucar()
        {
            bool resultado = azucarero.HasAzucar(15);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void DeberiaRestarAzucar()
        {
            azucarero.GiveAzucar(5);
            Assert.AreEqual(5,azucarero.GetCantidadAzucar());

            azucarero.GiveAzucar(2);
            Assert.AreEqual(3, azucarero.GetCantidadAzucar());
        }

    }
}
