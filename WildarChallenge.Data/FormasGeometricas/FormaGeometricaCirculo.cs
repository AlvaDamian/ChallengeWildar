using System;

namespace WildarChallenge.Data.FormasGeometricas
{
    /// <summary>
    /// Forma geometrica que representa a un circulo.
    /// </summary>
    class FormaGeometricaCirculo : IFormaGeometrica
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
