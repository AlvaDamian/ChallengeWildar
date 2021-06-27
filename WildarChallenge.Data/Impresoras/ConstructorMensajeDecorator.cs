using WildarChallenge.Data.FormasGeometricas;

namespace WildarChallenge.Data.Impresoras
{
    class ConstructorMensajeDecorator : IConstructorMensaje
    {
        private readonly IConstructorMensaje _constructorMensaje;
        private readonly IConstructorMensaje _fallback;

        public ConstructorMensajeDecorator(IConstructorMensaje constructorMensaje, IConstructorMensaje fallback)
        {
            this._constructorMensaje = constructorMensaje;
            this._fallback = fallback;
        }

        public string Area()
        {
            string ret = this._constructorMensaje.Area();
            return string.IsNullOrEmpty(ret) ? this._fallback.Area() : ret.Trim();
        }

        public string Formas()
        {
            string ret = this._constructorMensaje.Formas();
            return string.IsNullOrEmpty(ret) ? this._fallback.Formas() : ret.Trim();
        }

        public string ListaDeFormasVacia()
        {
            string ret = this._constructorMensaje.ListaDeFormasVacia();
            return string.IsNullOrEmpty(ret) ? this._fallback.ListaDeFormasVacia() : ret.Trim();
        }

        public string NombreForma(TipoFormaGeometrica tipoFormaGeometrica, bool plural)
        {
            string ret = this._constructorMensaje.NombreForma(tipoFormaGeometrica, plural);
            return string.IsNullOrEmpty(ret) ? this._fallback.NombreForma(tipoFormaGeometrica, plural) : ret.Trim();
        }

        public string Perimetro()
        {
            string ret = this._constructorMensaje.Perimetro();
            return string.IsNullOrEmpty(ret) ? this._fallback.Perimetro() : ret.Trim();
        }

        public string ReporteDeFormas()
        {
            string ret = this._constructorMensaje.ReporteDeFormas();
            return string.IsNullOrEmpty(ret) ? this._fallback.ReporteDeFormas() : ret.Trim();
        }

        public string Total()
        {
            string ret = this._constructorMensaje.Total();
            return string.IsNullOrEmpty(ret) ? this._fallback.Total() : ret.Trim();
        }
    }
}
