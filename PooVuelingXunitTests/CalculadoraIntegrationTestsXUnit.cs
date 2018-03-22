using PooVueling;
using System;
using Xunit;

namespace PooVueling.XUnitTests
{
    public class CalculadoraIntegrationTests
    {
        ICalculadora iCalculadora = new Calculadora();
        Random rnd = new Random();

        [Fact]
        public void DivisionTest()
        {
            Assert.Equal(2,iCalculadora.Division(4,2));
        }

        [Fact]
        public void DivisionBy0Test()
        {
            var ex = Assert.Throws<DivideByZeroException>(() => iCalculadora.Division(rnd.Next(1, 10), 0));
            Assert.IsType<DivideByZeroException>(ex);
        }

        [Fact]
        public void MultiplicacionTest()
        {
            Assert.Equal(6,iCalculadora.Multiplicacion(2, 3));
        }

        [Fact]
        public void RestaTest()
        {
            Assert.Equal(0,iCalculadora.Resta(1, 1));
        }

        [Fact]
        public void SumaTest()
        {
            Assert.Equal(4,iCalculadora.Suma(2, 2));
        }
    }
}