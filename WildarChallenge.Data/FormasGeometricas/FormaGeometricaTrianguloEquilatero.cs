using System;

namespace WildarChallenge.Data.FormasGeometricas
{
    /// <summary>
    /// Forma geometrica que representa un cuadrado equilatero
    /// donde todos sus lados son iguales.
    /// </summary>
    class FormaGeometricaTrianguloEquilatero : IFormaGeometrica
    {
        private readonly decimal _anchoLado;

        public FormaGeometricaTrianguloEquilatero(decimal anchoLado)
        {
            this._anchoLado = anchoLado;
        }

        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.TRIANGULO_EQUILATERO;

        public decimal CalcularArea()
        {
            return ((decimal) Math.Sqrt(3) / 4) * this._anchoLado * this._anchoLado;
        }

        public decimal CalcularPerimetro()
        {
            return this._anchoLado * 3;
        }
    }
}
