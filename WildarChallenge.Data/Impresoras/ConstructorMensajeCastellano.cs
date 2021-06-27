using WildarChallenge.Data.FormasGeometricas;

namespace WildarChallenge.Data.Impresoras
{
    class ConstructorMensajeCastellano : IConstructorMensaje
    {
        public string Area() => "Área";
        public string Formas() => "Formas";
        public string ListaDeFormasVacia() => "¡Lista vacía de formas!";
        public string Perimetro() => "Perímetro";
        public string Total() => "Total";
        public string ReporteDeFormas() => "Reporte de formas";

        public string NombreForma(TipoFormaGeometrica tipoFormaGeometrica, bool plural)
        {
            switch (tipoFormaGeometrica)
            {
                case TipoFormaGeometrica.CUADRADO:
                    return plural ? "cuadrados" : "cuadrado";

                case TipoFormaGeometrica.TRIANGULO_EQUILATERO:
                    return plural ? "triángulos" : "triángulo";

                case TipoFormaGeometrica.CIRCULO:
                    return plural ? "círculos" : "círculo";

                case TipoFormaGeometrica.TRAPECIO:
                    return plural ? "trapecios" : "trapecio";

                case TipoFormaGeometrica.RECTANGULO:
                    return plural ? "rectángulos" : "rectángulo";
            }

            return string.Empty;
        }
    }
}
