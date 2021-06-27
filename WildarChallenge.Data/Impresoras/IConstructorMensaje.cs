using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WildarChallenge.Data.FormasGeometricas;

namespace WildarChallenge.Data.Impresoras
{
    public interface IConstructorMensaje
    {
        string Perimetro();
        string Area();
        string ListaDeFormasVacia();
        string Total();
        string Formas();
        string ReporteDeFormas();
        string NombreForma(TipoFormaGeometrica tipoFormaGeometrica, bool plural);
    }
}
