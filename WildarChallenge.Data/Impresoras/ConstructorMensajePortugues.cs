using System;

using WildarChallenge.Data.FormasGeometricas;

namespace WildarChallenge.Data.Impresoras
{
    class ConstructorMensajePortugues : IConstructorMensaje
    {
        public string Area() => "Área";
        public string Formas() => "Formas";
        public string ListaDeFormasVacia() => "Lista vazia de formas!";
        public string Perimetro() => "Perímetro";
        public string ReporteDeFormas() => "Relatório de formas";
        public string Total() => "Total";
        public string NombreForma(TipoFormaGeometrica tipoFormaGeometrica, bool plural)
        {
            switch (tipoFormaGeometrica)
            {
                case TipoFormaGeometrica.CUADRADO:
                    return plural ? "quadrados" : "quadrado";

                case TipoFormaGeometrica.TRIANGULO_EQUILATERO:
                    return plural ? "triângulos" : "triângulo";

                case TipoFormaGeometrica.CIRCULO:
                    return plural ? "círculos" : "círculo";

                case TipoFormaGeometrica.TRAPECIO:
                    return plural ? "trapézios" : "trapézio";

                case TipoFormaGeometrica.RECTANGULO:
                    return plural ? "retângulos" : "retângulo";
            }

            return string.Empty;
        }
    }
}
