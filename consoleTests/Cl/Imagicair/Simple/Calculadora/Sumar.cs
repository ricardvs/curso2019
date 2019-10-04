using System;
using System.Diagnostics;
using NUnit.Framework;
using cl.imagicair.simple;

namespace Cl.Imagicair.Simple.calculadora
{
    [TestFixture]
    public class Sumar
    {
        private Calculadora calculadora;

        [SetUp]
        public void Setup()
        {
            calculadora = new Calculadora();
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test(Description = "Esto no importa")]
        public void AceptaNumerosPositivos()
        {
            var resultado = calculadora.Sumar(4, 9);
            Assert.That(resultado, Is.EqualTo(13));
        }

        [Test]
        public void AceptaNumerosNegativos()
        {
            var resultado = calculadora.Sumar(-5, -53);
            Assert.That(resultado, Is.EqualTo(-58));
        }

        [Test]
        [Ignore("Motivos de prueba")]
        public void EsteTestEstaIgnorado()
        {

        }
    }
}