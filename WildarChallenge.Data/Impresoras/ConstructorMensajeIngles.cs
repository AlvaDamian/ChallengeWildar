using WildarChallenge.Data.FormasGeometricas;

namespace WildarChallenge.Data.Impresoras
{
    class ConstructorMensajeIngles : IConstructorMensaje
    {
        public string Area() => "Area";
        public string Formas() => "Shapes";
        public string ListaDeFormasVacia() => "Empty list of shapes!";
        public string NombreForma(TipoFormaGeometrica tipoFormaGeometrica, bool plural)
        {
            switch (tipoFormaGeometrica)
            {
                case TipoFormaGeometrica.CUADRADO:
                    return plural ? "squares" : "square";

                case TipoFormaGeometrica.TRIANGULO_EQUILATERO:
                    return plural ? "triangles" : "triangle";

                case TipoFormaGeometrica.CIRCULO:
                    return plural ? "circles" : "circle";

                case TipoFormaGeometrica.TRAPECIO:
                    return plural ? "trapezoids" : "trapeze";

                case TipoFormaGeometrica.RECTANGULO:
                    return plural ? "rectangles" : "rectangle";
            }

            return string.Empty;
        }

        public string Perimetro() => "Perimeter";
        public string ReporteDeFormas() => "Shapes report";
        public string Total() => "Total";
    }
}
