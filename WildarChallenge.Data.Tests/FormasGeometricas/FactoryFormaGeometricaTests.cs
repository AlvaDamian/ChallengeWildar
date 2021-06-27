using System;
using NUnit.Framework;

using WildarChallenge.Data.FormasGeometricas;

namespace WildarChallenge.Data.Tests.FormasGeometricas
{
    [TestFixture]
    public class FactoryFormaGeometricaTests
    {

        [TestCase]
        public void InicializaCorrectamente()
        {
            new FactoryFormaGeometrica();
        }

        #region tipo de forma geometrica
        [TestCase]
        public void MetodoCirculoCreaUnaFormaDeTipoCirculo()
        {
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica ciculo = factory.Circulo(3m);

            Assert.AreEqual(TipoFormaGeometrica.CIRCULO, ciculo.Tipo);
        }

        [TestCase]
        public void MetodoCuadradoCreaUnaFormaDeTipoCuadrado()
        {
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica cuadrado = factory.Cuadrado(4m);

            Assert.AreEqual(TipoFormaGeometrica.CUADRADO, cuadrado.Tipo);
        }

        [TestCase]
        public void MetodoTrianguloEquilateroCreaUnaFormaDeTipoTrianguloEquilatero()
        {
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica triangulo = factory.TrianguloEquilatero(65m);

            Assert.AreEqual(TipoFormaGeometrica.TRIANGULO_EQUILATERO, triangulo.Tipo);
        }

        [TestCase]
        public void MetodoTrapecioCreaUnaFormaDeTipoTrapecio()
        {
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica trapecio = factory.Trapecio(2m, 6m, 1m, 7m, 4m);

            Assert.AreEqual(TipoFormaGeometrica.TRAPECIO, trapecio.Tipo);
        }

        [TestCase]
        public void MetodoRectanguloCreaUnaFormaDeTipoRectangulo()
        {
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica rectangulo = factory.Rectangulo(6m, 4m);

            Assert.AreEqual(TipoFormaGeometrica.RECTANGULO, rectangulo.Tipo);
        }
        #endregion

        #region calculo de area.
        [TestCase]
        public void FormaGeometricaCirculoCalculaCorrectamenteElArea()
        {
            decimal radio = 6m;
            decimal areaEsperada = (decimal) Math.PI * (radio / 2) * (radio / 2);
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica circulo = factory.Circulo(radio);

            Assert.AreEqual(areaEsperada, circulo.CalcularArea());
        }

        [TestCase]
        public void FormaGeometricaCuadradoCalculaCorrectamenteElArea()
        {
            decimal ancho = 74m;
            decimal areaEsperada = ancho * ancho;
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica cuadrado = factory.Cuadrado(ancho);

            Assert.AreEqual(areaEsperada, cuadrado.CalcularArea());
        }

        [TestCase]
        public void FormaGeometricaRectanguloCalculaCorrectamenteElArea()
        {
            decimal anchoBase = 4m;
            decimal altura = 6m;
            decimal areaEsperada = anchoBase * altura;
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica rectangulo = factory.Rectangulo(anchoBase, altura);

            Assert.AreEqual(areaEsperada, rectangulo.CalcularArea());
        }

        [TestCase]
        public void FormaGeometricaTrianguloEquilateroCalculaCorrectamenteElArea()
        {
            decimal anchoLado = 7m;
            decimal areaEsperada = ((decimal)Math.Sqrt(3) / 4) * anchoLado * anchoLado;
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica triangulo = factory.TrianguloEquilatero(anchoLado);

            Assert.AreEqual(areaEsperada, triangulo.CalcularArea());
        }

        [TestCase]
        public void FormaGeometricaTrapecioCalculaCorrectamenteElArea()
        {
            decimal baseMenor = 5m;
            decimal baseMayor = 8m;
            decimal altura = 3m;
            decimal lado1 = 6m;
            decimal lado2 = 5m;
            decimal areaEsperada = (baseMayor + baseMenor) * altura / 2;
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica trapecio = factory.Trapecio(baseMenor, baseMayor, altura, lado1, lado2);

            Assert.AreEqual(areaEsperada, trapecio.CalcularArea());
        }
        #endregion

        #region calculo del perimetro.
        [TestCase]
        public void FormaGeometricaCirculoCalculaCorrectamenteElPerimetro()
        {
            decimal radio = 5m;
            decimal perimetroEsperado = (decimal)Math.PI * radio;
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica ciculo = factory.Circulo(radio);

            Assert.AreEqual(perimetroEsperado, ciculo.CalcularPerimetro());
        }

        [TestCase]
        public void FormaGeometricaCuadradoCalculaCorrectamenteElPerimetro()
        {
            decimal anchoLado = 6m;
            decimal perimetroEsperado = anchoLado * 4;
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica cuadrado = factory.Cuadrado(anchoLado);

            Assert.AreEqual(perimetroEsperado, cuadrado.CalcularPerimetro());
        }

        [TestCase]
        public void FormaGeometricaRectanguloCalculaCorrectamenteElPerimetro()
        {
            decimal anchoBase = 6m;
            decimal altura = 1m;
            decimal perimetroEsperado = anchoBase * 2 + altura * 2;
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica rectangulo = factory.Rectangulo(anchoBase, altura);

            Assert.AreEqual(perimetroEsperado, rectangulo.CalcularPerimetro());
        }

        [TestCase]
        public void FormaGeometricaTrianguloEquilateroCalculaCorrectamenteElPerimetro()
        {
            decimal anchoLado = 8m;
            decimal perimetroEsperado = anchoLado * 3;
            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica triangulo = factory.TrianguloEquilatero(anchoLado);

            Assert.AreEqual(perimetroEsperado, triangulo.CalcularPerimetro());
        }

        [TestCase]
        public void FormaGeometricaTrapecioCalculaCorrectamenteElPerimetro()
        {
            decimal baseMayor = 6m;
            decimal baseMenor = 1m;
            decimal altura = 2m;
            decimal lado1 = 5m;
            decimal lado2 = 5m;
            decimal perimetroEsperado = baseMayor + baseMenor + lado1 + lado2;

            FactoryFormaGeometrica factory = new FactoryFormaGeometrica();
            IFormaGeometrica trapecio = factory.Trapecio(baseMenor, baseMayor, altura, lado1, lado2);

            Assert.AreEqual(perimetroEsperado, trapecio.CalcularPerimetro());
        }
        #endregion
    }
}
