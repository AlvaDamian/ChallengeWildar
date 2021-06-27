using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WildarChallenge.Data.FormasGeometricas;
using WildarChallenge.Data.Impresoras;

namespace WildarChallenge.Data.Tests.FormasGeometricas
{
    [TestFixture]
    public class ImpresoraFormaGeometricaTests
    {
        [TestCase]
        public void InicializaSinProblemas()
        {
            FactoryConstructorMensaje factory = new FactoryConstructorMensaje();
            IConstructorMensaje castellano = factory.Crear(FactoryConstructorMensaje.Idioma.CASTELLANO);
            new ImpresoraFormaGeometrica(castellano);
        }

        #region Impresión de formas.
        [TestCase]
        public void ImprimeMensajeDeCollectionVaciaDeFormas()
        {
            FactoryConstructorMensaje factory = new FactoryConstructorMensaje();
            IConstructorMensaje constructor = factory.Crear(FactoryConstructorMensaje.Idioma.ITALIANO);
            ICollection<IFormaGeometrica> formas = new List<IFormaGeometrica>();
            ImpresoraFormaGeometrica impresora = new ImpresoraFormaGeometrica(constructor);

            string mensajeEsperado = $"<h1>{constructor.ListaDeFormasVacia()}</h1>";
            Assert.AreEqual(mensajeEsperado, impresora.Imprimir(formas));

            constructor = factory.Crear(FactoryConstructorMensaje.Idioma.INGLES);
            impresora.ConstructorMensaje = constructor;
            mensajeEsperado = $"<h1>{constructor.ListaDeFormasVacia()}</h1>";
            Assert.AreEqual(mensajeEsperado, impresora.Imprimir(formas));

            constructor = factory.Crear(FactoryConstructorMensaje.Idioma.PORTUGUES);
            impresora.ConstructorMensaje = constructor;
            mensajeEsperado = $"<h1>{constructor.ListaDeFormasVacia()}</h1>";
            Assert.AreEqual(mensajeEsperado, impresora.Imprimir(formas));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            FactoryFormaGeometrica factoryFormaGeometrica = new FactoryFormaGeometrica();
            FactoryConstructorMensaje factoryConstructorMensaje = new FactoryConstructorMensaje();
            IFormaGeometrica cuadrado = factoryFormaGeometrica.Cuadrado(5);
            IConstructorMensaje constructorMensaje = factoryConstructorMensaje.Crear(FactoryConstructorMensaje.Idioma.INGLES);
            ICollection<IFormaGeometrica> formasGeometricas = new List<IFormaGeometrica>();
            formasGeometricas.Add(cuadrado);
            ImpresoraFormaGeometrica impresora = new ImpresoraFormaGeometrica(constructorMensaje);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder
                .Append($"<h1>{constructorMensaje.ReporteDeFormas()}</h1>")
                .Append($"1 {constructorMensaje.NombreForma(TipoFormaGeometrica.CUADRADO, false)}")
                .Append($" | {constructorMensaje.Area()} 25")
                .Append($" | {constructorMensaje.Perimetro()} 20")
                .Append(" <br/>")
                .Append($"{constructorMensaje.Total()}:<br/>")
                .Append($"1 {constructorMensaje.Formas()}")
                .Append($" {constructorMensaje.Perimetro()} 20")
                .Append($" {constructorMensaje.Area()} 25");

            string mensajeEsperado = stringBuilder.ToString();
            string mensajeGenerado = impresora.Imprimir(formasGeometricas);

            Assert.AreEqual(mensajeEsperado, mensajeGenerado);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            FactoryFormaGeometrica factoryFormaGeometrica = new FactoryFormaGeometrica();
            FactoryConstructorMensaje factoryConstructorMensaje = new FactoryConstructorMensaje();
            IFormaGeometrica cuadrado1 = factoryFormaGeometrica.Cuadrado(5);
            IFormaGeometrica cuadrado2 = factoryFormaGeometrica.Cuadrado(1);
            IFormaGeometrica cuadrado3 = factoryFormaGeometrica.Cuadrado(3);
            IConstructorMensaje constructorMensaje = factoryConstructorMensaje.Crear(FactoryConstructorMensaje.Idioma.ITALIANO);
            ICollection<IFormaGeometrica> formasGeometricas = new List<IFormaGeometrica>();
            formasGeometricas.Add(cuadrado1);
            formasGeometricas.Add(cuadrado2);
            formasGeometricas.Add(cuadrado3);
            ImpresoraFormaGeometrica impresora = new ImpresoraFormaGeometrica(constructorMensaje);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder
                .Append($"<h1>{constructorMensaje.ReporteDeFormas()}</h1>")
                .Append($"3 {constructorMensaje.NombreForma(TipoFormaGeometrica.CUADRADO, true)}")
                .Append($" | {constructorMensaje.Area()} 35")
                .Append($" | {constructorMensaje.Perimetro()} 36")
                .Append(" <br/>")
                .Append($"{constructorMensaje.Total()}:<br/>")
                .Append($"3 {constructorMensaje.Formas()}")
                .Append($" {constructorMensaje.Perimetro()} 36")
                .Append($" {constructorMensaje.Area()} 35");

            string mensajeEsperado = stringBuilder.ToString();
            string mensajeGenerado = impresora.Imprimir(formasGeometricas);

            Assert.AreEqual(mensajeEsperado, mensajeGenerado);
        }


        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            FactoryFormaGeometrica factoryFormaGeometrica = new FactoryFormaGeometrica();
            FactoryConstructorMensaje factoryConstructorMensaje = new FactoryConstructorMensaje();
            IConstructorMensaje constructorMensaje = factoryConstructorMensaje.Crear(FactoryConstructorMensaje.Idioma.INGLES);
            ICollection<IFormaGeometrica> formasGeometricas = new List<IFormaGeometrica>();
            formasGeometricas.Add(factoryFormaGeometrica.Cuadrado(5));
            formasGeometricas.Add(factoryFormaGeometrica.Circulo(3));
            formasGeometricas.Add(factoryFormaGeometrica.TrianguloEquilatero(4));
            formasGeometricas.Add(factoryFormaGeometrica.Cuadrado(2));
            formasGeometricas.Add(factoryFormaGeometrica.TrianguloEquilatero(9));
            formasGeometricas.Add(factoryFormaGeometrica.Circulo(2.75m));
            formasGeometricas.Add(factoryFormaGeometrica.TrianguloEquilatero(4.2m));
            ImpresoraFormaGeometrica impresora = new ImpresoraFormaGeometrica(constructorMensaje);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder
                .Append($"<h1>{constructorMensaje.ReporteDeFormas()}</h1>")
                .Append($"2 {constructorMensaje.NombreForma(TipoFormaGeometrica.CUADRADO, true)}")
                .Append($" | {constructorMensaje.Area()} 29")
                .Append($" | {constructorMensaje.Perimetro()} 28")
                .Append(" <br/>")
                .Append($"2 {constructorMensaje.NombreForma(TipoFormaGeometrica.CIRCULO, true)}")
                .Append($" | {constructorMensaje.Area()} 13,01")
                .Append($" | {constructorMensaje.Perimetro()} 18,06")
                .Append(" <br/>")
                .Append($"3 {constructorMensaje.NombreForma(TipoFormaGeometrica.TRIANGULO_EQUILATERO, true)}")
                .Append($" | {constructorMensaje.Area()} 49,64")
                .Append($" | {constructorMensaje.Perimetro()} 51,6")
                .Append(" <br/>")
                .Append($"{constructorMensaje.Total()}:<br/>")
                .Append($"7 {constructorMensaje.Formas()}")
                .Append($" {constructorMensaje.Perimetro()} 97,66")
                .Append($" {constructorMensaje.Area()} 91,65");

            string mensajeEsperado = stringBuilder.ToString();
            string mensajeGenerado = impresora.Imprimir(formasGeometricas);

            Assert.AreEqual(mensajeEsperado, mensajeGenerado);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            FactoryFormaGeometrica factoryFormaGeometrica = new FactoryFormaGeometrica();
            FactoryConstructorMensaje factoryConstructorMensaje = new FactoryConstructorMensaje();
            IConstructorMensaje constructorMensaje = factoryConstructorMensaje.Crear(FactoryConstructorMensaje.Idioma.CASTELLANO);
            ICollection<IFormaGeometrica> formasGeometricas = new List<IFormaGeometrica>();
            formasGeometricas.Add(factoryFormaGeometrica.Cuadrado(5));
            formasGeometricas.Add(factoryFormaGeometrica.Circulo(3));
            formasGeometricas.Add(factoryFormaGeometrica.TrianguloEquilatero(4));
            formasGeometricas.Add(factoryFormaGeometrica.Cuadrado(2));
            formasGeometricas.Add(factoryFormaGeometrica.TrianguloEquilatero(9));
            formasGeometricas.Add(factoryFormaGeometrica.Circulo(2.75m));
            formasGeometricas.Add(factoryFormaGeometrica.TrianguloEquilatero(4.2m));
            ImpresoraFormaGeometrica impresora = new ImpresoraFormaGeometrica(constructorMensaje);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder
                .Append($"<h1>{constructorMensaje.ReporteDeFormas()}</h1>")
                .Append($"2 {constructorMensaje.NombreForma(TipoFormaGeometrica.CUADRADO, true)}")
                .Append($" | {constructorMensaje.Area()} 29")
                .Append($" | {constructorMensaje.Perimetro()} 28")
                .Append(" <br/>")
                .Append($"2 {constructorMensaje.NombreForma(TipoFormaGeometrica.CIRCULO, true)}")
                .Append($" | {constructorMensaje.Area()} 13,01")
                .Append($" | {constructorMensaje.Perimetro()} 18,06")
                .Append(" <br/>")
                .Append($"3 {constructorMensaje.NombreForma(TipoFormaGeometrica.TRIANGULO_EQUILATERO, true)}")
                .Append($" | {constructorMensaje.Area()} 49,64")
                .Append($" | {constructorMensaje.Perimetro()} 51,6")
                .Append(" <br/>")
                .Append($"{constructorMensaje.Total()}:<br/>")
                .Append($"7 {constructorMensaje.Formas()}")
                .Append($" {constructorMensaje.Perimetro()} 97,66")
                .Append($" {constructorMensaje.Area()} 91,65");

            string mensajeEsperado = stringBuilder.ToString();
            string mensajeGenerado = impresora.Imprimir(formasGeometricas);

            Assert.AreEqual(mensajeEsperado, mensajeGenerado);
        }
        #endregion
    }
}
