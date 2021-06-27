using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildarChallenge.Data.FormasGeometricas
{
    public interface IFormaGeometrica
    {
        decimal CalcularArea();
        decimal CalcularPerimetro();
        TipoFormaGeometrica Tipo { get; }
    }
}
