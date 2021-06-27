namespace WildarChallenge.Data.FormasGeometricas
{
    class FormaGeometricaTrapecio : IFormaGeometrica
    {
        private readonly decimal _baseMenor;
        private readonly decimal _baseMayor;
        private readonly decimal _altura;
        private readonly decimal _lado1;
        private readonly decimal _lado2;

        public FormaGeometricaTrapecio(decimal baseMenor, decimal baseMayor, decimal altura, decimal lado1, decimal lado2)
        {
            this._baseMenor = baseMenor;
            this._baseMayor = baseMayor;
            this._altura = altura;
            this._lado1 = lado1;
            this._lado2 = lado2;
        }

        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.TRAPECIO;

        public decimal CalcularArea()
        {
            return ((this._baseMayor + this._baseMenor) * this._altura) / 2;
        }

        public decimal CalcularPerimetro()
        {
            return this._baseMayor + this._baseMenor + this._lado1 + this._lado2;
        }
    }
}
