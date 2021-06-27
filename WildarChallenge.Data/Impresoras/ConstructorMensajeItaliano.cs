using WildarChallenge.Data.FormasGeometricas;

namespace WildarChallenge.Data.Impresoras
{
    class ConstructorMensajeItaliano : IConstructorMensaje
    {
        public string Area() => "La zona";
        public string Formas() => "Forme";
        public string ListaDeFormasVacia() => "Lista vuota di forme!";
        public string Perimetro() => "Perimetro";
        public string ReporteDeFormas() => "Rapporto di forme";
        public string Total() => "Totale";
        public string NombreForma(TipoFormaGeometrica tipoFormaGeometrica, bool plural)
        {
            switch (tipoFormaGeometrica)
            {
                case TipoFormaGeometrica.CUADRADO:
                    return plural ? "piazze" : "piazza";
                case TipoFormaGeometrica.TRIANGULO_EQUILATERO:
                    return plural ? "triangoli" : "triangolo";
                case TipoFormaGeometrica.CIRCULO:
                    return plural ? "cerchi" : "cerchio";
                case TipoFormaGeometrica.TRAPECIO:
                    return plural ? "trapezi" : "trapezio";
                case TipoFormaGeometrica.RECTANGULO:
                    return plural ? "rettangoli" : "rettangolo";
            }

            return string.Empty;
        }
    }
}
