namespace WildarChallenge.Data.FormasGeometricas
{
    public class FactoryFormaGeometrica
    {
        public IFormaGeometrica Cuadrado(decimal anchoLado)
        {
            return new FormaGeometricaRectangulo(anchoLado, anchoLado);
        }

        public IFormaGeometrica TrianguloEquilatero(decimal anchoLado)
        {
            return new FormaGeometricaTrianguloEquilatero(anchoLado);
        }

        public IFormaGeometrica Circulo(decimal radio)
        {
            return new FormaGeometricaCirculo(radio);
        }

        public IFormaGeometrica Trapecio(decimal baseMenor, decimal baseMayor, decimal altura, decimal anchoLado1, decimal anchoLado2)
        {
            return new FormaGeometricaTrapecio(baseMenor, baseMayor, altura, anchoLado1, anchoLado2);
        }

        public IFormaGeometrica Rectangulo(decimal anchoBase, decimal altura)
        {
            return new FormaGeometricaRectangulo(anchoBase, altura);
        }
    }
}
