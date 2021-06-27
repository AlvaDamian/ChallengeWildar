using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WildarChallenge.Data.FormasGeometricas;

namespace WildarChallenge.Data.Impresoras
{
    /// <summary>
    /// Constructor de mensajes para la impresión de formas
    /// geometricas.
    /// </summary>
    public interface IConstructorMensaje
    {
        /// <summary>
        /// Construye el mensaje que corresponde a la
        /// palabra "Perímetro".
        /// </summary>
        /// <returns>El mensaje construido.</returns>
        string Perimetro();

        /// <summary>
        /// Construye el mensaje que corresponde a la
        /// palabra "Área".
        /// </summary>
        /// <returns>El mensaje construido.</returns>
        string Area();

        /// <summary>
        /// Construye el mensaje que corresponde a la
        /// frase "¡Lista vacía de formas!".
        /// </summary>
        /// <returns>El mensaje construido.</returns>
        string ListaDeFormasVacia();

        /// <summary>
        /// Construye el mensaje que corresponde a la
        /// palabra "Total".
        /// </summary>
        /// <returns>El mensaje construido.</returns>
        string Total();

        /// <summary>
        /// Construye el mensaje que corresponde a la
        /// palabra "Formas".
        /// </summary>
        /// <returns>El mensaje construido.</returns>
        string Formas();

        /// <summary>
        /// Construye el mensaje que corresponde a la
        /// frase "Reporte de formas".
        /// </summary>
        /// <returns>El mensaje construido.</returns>
        string ReporteDeFormas();

        /// <summary>
        /// <para>
        /// Construye el mensaje que corresponde al
        /// nombre del tipo de la forma geometrica provista.
        /// </para>
        /// <para>
        /// Si la forma geometrica no es reconocida, se construye
        /// un mensaje vacío.
        /// </para>
        /// </summary>
        /// <param name="tipoFormaGeometrica">Tipo de forma.</param>
        /// <param name="plural">true si se debe construir el mensaje
        /// con el nombre de la forma geometrica en plurar, false de lo
        /// contrario.</param>
        /// <returns>El mensaje construido.</returns>
        string NombreForma(TipoFormaGeometrica tipoFormaGeometrica, bool plural);
    }
}
