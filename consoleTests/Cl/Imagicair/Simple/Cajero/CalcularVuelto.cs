using NUnit.Framework;

namespace Cl.Imagicair.Simple.cajero 
{
    [TestFixture]
    public class CalcularVuelto
    {
        [Test]
        public void VueltoCerrado()
        {
            // Arrange
            var cajero = new Cajero();

            // Act
            var resultado = cajero.CalcularVuelto(30000, 40000);

            // Assert
            Assert.That(resultado, Is.Not.Null);
            Assert.That(resultado.De20000, Is.EqualTo(0));
            Assert.That(resultado.De10000, Is.EqualTo(1));
            Assert.That(resultado.De5000, Is.EqualTo(0));
            Assert.That(resultado.De2000, Is.EqualTo(0));
            Assert.That(resultado.De1000, Is.EqualTo(0));
            Assert.That(resultado.De500, Is.EqualTo(0));
            Assert.That(resultado.De100, Is.EqualTo(0));
            Assert.That(resultado.De50, Is.EqualTo(0));
            Assert.That(resultado.De10, Is.EqualTo(0));
            Assert.That(resultado.De5, Is.EqualTo(0));
            Assert.That(resultado.De1, Is.EqualTo(0));
        }

        [Test]
        public void VueltoConChauchas()
        {
            // Arrange
            var cajero = new Cajero();

            // Act
            var resultado = cajero.CalcularVuelto(29950, 40000);

            // Assert
            Assert.That(resultado, Is.Not.Null);
            Assert.That(resultado.De20000, Is.EqualTo(0));
            Assert.That(resultado.De10000, Is.EqualTo(1));
            Assert.That(resultado.De5000, Is.EqualTo(0));
            Assert.That(resultado.De2000, Is.EqualTo(0));
            Assert.That(resultado.De1000, Is.EqualTo(0));
            Assert.That(resultado.De500, Is.EqualTo(0));
            Assert.That(resultado.De100, Is.EqualTo(0));
            Assert.That(resultado.De50, Is.EqualTo(1));
            Assert.That(resultado.De10, Is.EqualTo(0));
            Assert.That(resultado.De5, Is.EqualTo(0));
            Assert.That(resultado.De1, Is.EqualTo(0));
        }
    }
}