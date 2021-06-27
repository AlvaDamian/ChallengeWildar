namespace WildarChallenge.Data.FormasGeometricas
{
    class FormaGeometricaRectangulo : IFormaGeometrica
    {
        private readonly decimal _base;
        private readonly decimal _altura;

        public FormaGeometricaRectangulo(decimal anchoBase, decimal altura)
        {
            this._base = anchoBase;
            this._altura = altura;
        }


        public TipoFormaGeometrica Tipo => this._base == this._altura ? TipoFormaGeometrica.CUADRADO : TipoFormaGeometrica.RECTANGULO;

        public decimal CalcularArea()
        {
            return this._base * this._altura;
        }

        public decimal CalcularPerimetro()
        {
            return this._base * 2 + this._altura * 2;
        }
    }
}
