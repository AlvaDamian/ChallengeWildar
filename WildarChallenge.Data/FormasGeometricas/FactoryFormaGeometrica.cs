namespace WildarChallenge.Data.FormasGeometricas
{
    /// <summary>
    /// Construye las formas geometricas.
    /// </summary>
    public class FactoryFormaGeometrica
    {
        /// <summary>
        /// Construye una <see cref="IFormaGeometrica"/> que representa un cuadrado.
        /// </summary>
        /// <param name="anchoLado">Ancho de cada lado del cuadrado.</param>
        /// <returns>La forma geometrica creada.</returns>
        public IFormaGeometrica Cuadrado(decimal anchoLado)
        {
            //Se crea un rectangulo con todos sus lados iguales
            return new FormaGeometricaRectangulo(anchoLado, anchoLado);
        }

        /// <summary>
        /// Crea una <see cref="IFormaGeometrica"/> que representa un triángulo.
        /// </summary>
        /// <param name="anchoLado">Ancho de cada lado del triángulo.</param>
        /// <returns>La forma geometrica creada.</returns>
        public IFormaGeometrica TrianguloEquilatero(decimal anchoLado)
        {
            return new FormaGeometricaTrianguloEquilatero(anchoLado);
        }

        /// <summary>
        /// Crea una <see cref="IFormaGeometrica"/> que representa un circulo.
        /// </summary>
        /// <param name="radio">Radio del circulo</param>
        /// <returns>La forma geometrica creada.</returns>
        public IFormaGeometrica Circulo(decimal radio)
        {
            return new FormaGeometricaCirculo(radio);
        }

        /// <summary>
        /// Crea una <see cref="IFormaGeometrica"/> que representa un trapecio.
        /// </summary>
        /// <param name="baseMenor">Ancho de la base menor.</param>
        /// <param name="baseMayor">Ancho de la base mayor.</param>
        /// <param name="altura">Altura.</param>
        /// <param name="anchoLado1">Ancho del lado 1.</param>
        /// <param name="anchoLado2">Ancho del lado 2.</param>
        /// <returns>La forma geometrica creada.</returns>
        public IFormaGeometrica Trapecio(decimal baseMenor, decimal baseMayor, decimal altura, decimal anchoLado1, decimal anchoLado2)
        {
            return new FormaGeometricaTrapecio(baseMenor, baseMayor, altura, anchoLado1, anchoLado2);
        }

        /// <summary>
        /// Crea una <see cref="IFormaGeometrica"/> que representa un rectangulo.
        /// </summary>
        /// <param name="anchoBase">Ancho de la base.</param>
        /// <param name="altura">Altura.</param>
        /// <returns>La forma geometrica creada.</returns>
        public IFormaGeometrica Rectangulo(decimal anchoBase, decimal altura)
        {
            return new FormaGeometricaRectangulo(anchoBase, altura);
        }
    }
}
