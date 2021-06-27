using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WildarChallenge.Data.Impresoras;

namespace WildarChallenge.Data.Tests.Impresoras
{
    [TestFixture]
    public class FactoryConstructorMensajeTests
    {
        #region Inicialización
        [TestCase]
        public void InicializaSinProblemas()
        {
            new FactoryConstructorMensaje();
        }

        [TestCase]
        public void CreaUnaInstanciaDeCastellano()
        {
            FactoryConstructorMensaje factory = new FactoryConstructorMensaje();
            IConstructorMensaje constructor = factory.Crear(FactoryConstructorMensaje.Idioma.CASTELLANO);

            Assert.IsNotNull(constructor);
        }

        [TestCase]
        public void CreaUnaInstanciaDeIngles()
        {
            FactoryConstructorMensaje factory = new FactoryConstructorMensaje();
            IConstructorMensaje constructor = factory.Crear(FactoryConstructorMensaje.Idioma.INGLES);

            Assert.IsNotNull(constructor);
        }

        [TestCase]
        public void CreaUnaInstanciaDeItaliano()
        {
            FactoryConstructorMensaje factory = new FactoryConstructorMensaje();
            IConstructorMensaje constructor = factory.Crear(FactoryConstructorMensaje.Idioma.ITALIANO);

            Assert.IsNotNull(constructor);
        }

        [TestCase]
        public void CreaUnaInstanciaDePortugues()
        {
            FactoryConstructorMensaje factory = new FactoryConstructorMensaje();
            IConstructorMensaje constructor = factory.Crear(FactoryConstructorMensaje.Idioma.PORTUGUES);

            Assert.IsNotNull(constructor);
        }
        #endregion

        #region Traducción
        [TestCase]
        public void ConstructorCastellanoGeneraLosMensajesCorrectos()
        {
            FactoryConstructorMensaje factory = new FactoryConstructorMensaje();
            IConstructorMensaje constructor = factory.Crear(FactoryConstructorMensaje.Idioma.CASTELLANO);

            Assert.AreEqual("Área", constructor.Area());
            Assert.AreEqual("Formas", constructor.Formas());
            Assert.AreEqual("¡Lista vacía de formas!", constructor.ListaDeFormasVacia());
            Assert.AreEqual("Perímetro", constructor.Perimetro());
            Assert.AreEqual("Total", constructor.Total());
            Assert.AreEqual("Reporte de formas", constructor.ReporteDeFormas());

            bool plural = false;
            Assert.AreEqual("cuadrado", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CUADRADO, plural));
            Assert.AreEqual("triángulo", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRIANGULO_EQUILATERO, plural));
            Assert.AreEqual("círculo", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CIRCULO, plural));
            Assert.AreEqual("trapecio", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRAPECIO, plural));
            Assert.AreEqual("rectángulo", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.RECTANGULO, plural));

            plural = true;
            Assert.AreEqual("cuadrados", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CUADRADO, plural));
            Assert.AreEqual("triángulos", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRIANGULO_EQUILATERO, plural));
            Assert.AreEqual("círculos", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CIRCULO, plural));
            Assert.AreEqual("trapecios", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRAPECIO, plural));
            Assert.AreEqual("rectángulos", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.RECTANGULO, plural));
        }

        [TestCase]
        public void ConstructorInglesGeneraLosMensajesCorrectos()
        {
            FactoryConstructorMensaje factory = new FactoryConstructorMensaje();
            IConstructorMensaje constructor = factory.Crear(FactoryConstructorMensaje.Idioma.INGLES);

            Assert.AreEqual("Area", constructor.Area());
            Assert.AreEqual("Shapes", constructor.Formas());
            Assert.AreEqual("Empty list of shapes!", constructor.ListaDeFormasVacia());
            Assert.AreEqual("Perimeter", constructor.Perimetro());
            Assert.AreEqual("Total", constructor.Total());
            Assert.AreEqual("Shapes report", constructor.ReporteDeFormas());

            bool plural = false;
            Assert.AreEqual("square", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CUADRADO, plural));
            Assert.AreEqual("triangle", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRIANGULO_EQUILATERO, plural));
            Assert.AreEqual("circle", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CIRCULO, plural));
            Assert.AreEqual("trapeze", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRAPECIO, plural));
            Assert.AreEqual("rectangle", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.RECTANGULO, plural));

            plural = true;
            Assert.AreEqual("squares", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CUADRADO, plural));
            Assert.AreEqual("triangles", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRIANGULO_EQUILATERO, plural));
            Assert.AreEqual("circles", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CIRCULO, plural));
            Assert.AreEqual("trapezoids", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRAPECIO, plural));
            Assert.AreEqual("rectangles", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.RECTANGULO, plural));
        }

        [TestCase]
        public void ConstructorItalianoGeneraLosMensajesCorrectos()
        {
            FactoryConstructorMensaje factory = new FactoryConstructorMensaje();
            IConstructorMensaje constructor = factory.Crear(FactoryConstructorMensaje.Idioma.ITALIANO);

            Assert.AreEqual("La zona", constructor.Area());
            Assert.AreEqual("Forme", constructor.Formas());
            Assert.AreEqual("Lista vuota di forme!", constructor.ListaDeFormasVacia());
            Assert.AreEqual("Perimetro", constructor.Perimetro());
            Assert.AreEqual("Totale", constructor.Total());
            Assert.AreEqual("Rapporto di forme", constructor.ReporteDeFormas());

            bool plural = false;
            Assert.AreEqual("piazza", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CUADRADO, plural));
            Assert.AreEqual("triangolo", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRIANGULO_EQUILATERO, plural));
            Assert.AreEqual("cerchio", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CIRCULO, plural));
            Assert.AreEqual("trapezio", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRAPECIO, plural));
            Assert.AreEqual("rettangolo", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.RECTANGULO, plural));

            plural = true;
            Assert.AreEqual("piazze", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CUADRADO, plural));
            Assert.AreEqual("triangoli", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRIANGULO_EQUILATERO, plural));
            Assert.AreEqual("cerchi", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CIRCULO, plural));
            Assert.AreEqual("trapezi", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRAPECIO, plural));
            Assert.AreEqual("rettangoli", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.RECTANGULO, plural));
        }

        [TestCase]
        public void ConstructorPortuguesGeneraLosMensajesCorrectos()
        {
            FactoryConstructorMensaje factory = new FactoryConstructorMensaje();
            IConstructorMensaje constructor = factory.Crear(FactoryConstructorMensaje.Idioma.PORTUGUES);

            Assert.AreEqual("Área", constructor.Area());
            Assert.AreEqual("Formas", constructor.Formas());
            Assert.AreEqual("Lista vazia de formas!", constructor.ListaDeFormasVacia());
            Assert.AreEqual("Perímetro", constructor.Perimetro());
            Assert.AreEqual("Total", constructor.Total());
            Assert.AreEqual("Relatório de formas", constructor.ReporteDeFormas());

            bool plural = false;
            Assert.AreEqual("quadrado", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CUADRADO, plural));
            Assert.AreEqual("triângulo", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRIANGULO_EQUILATERO, plural));
            Assert.AreEqual("círculo", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CIRCULO, plural));
            Assert.AreEqual("trapézio", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRAPECIO, plural));
            Assert.AreEqual("retângulo", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.RECTANGULO, plural));

            plural = true;
            Assert.AreEqual("quadrados", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CUADRADO, plural));
            Assert.AreEqual("triângulos", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRIANGULO_EQUILATERO, plural));
            Assert.AreEqual("círculos", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.CIRCULO, plural));
            Assert.AreEqual("trapézios", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.TRAPECIO, plural));
            Assert.AreEqual("retângulos", constructor.NombreForma(Data.FormasGeometricas.TipoFormaGeometrica.RECTANGULO, plural));
        }
        #endregion
    }
}
