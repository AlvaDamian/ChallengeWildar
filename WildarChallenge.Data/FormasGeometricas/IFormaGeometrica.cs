using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildarChallenge.Data.FormasGeometricas
{
    /// <summary>
    /// Forma geometrica.
    /// </summary>
    public interface IFormaGeometrica
    {
        /// <summary>
        /// Calcula el área de esta forma geometrica.
        /// </summary>
        /// <returns>El área calculada.</returns>
        decimal CalcularArea();

        /// <summary>
        /// Calcula el perímetro de esta forma geometrica.
        /// </summary>
        /// <returns>El perímetro calculado.</returns>
        decimal CalcularPerimetro();

        /// <summary>
        /// Tipo de forma geometrica.
        /// </summary>
        TipoFormaGeometrica Tipo { get; }
    }
}
