using System;

namespace WildarChallenge.Data.FormasGeometricas
{
    internal class FormaGeometricaCirculo : IFormaGeometrica
    {
        private readonly decimal _radio;

        public FormaGeometricaCirculo(decimal radio)
        {
            this._radio = radio;
        }

        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.CIRCULO;

        public decimal CalcularArea()
        {
            return (decimal) Math.PI * (this._radio / 2) * (this._radio/ 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal) Math.PI * this._radio;
        }
    }
}
