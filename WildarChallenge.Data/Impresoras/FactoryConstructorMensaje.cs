namespace WildarChallenge.Data.Impresoras
{
    /// <summary>
    /// Fabrica de constructores de mensajes.
    /// </summary>
    public class FactoryConstructorMensaje
    {
        /// <summary>
        /// Idiomas soportados por los constructores de mensajes..
        /// </summary>
        public enum Idioma
        {
            INGLES, CASTELLANO, ITALIANO, PORTUGUES
        }

        /// <summary>
        /// Constructor de mensaje a utilizar en caso de que
        /// el original retorne un string vacío.
        /// </summary>
        private readonly IConstructorMensaje _fallback;

        /// <summary>
        /// Inicializa la fabrica con el <see cref="Idioma.CASTELLANO"/>
        /// por defecto.
        /// </summary>
        public FactoryConstructorMensaje()
        {
            this._fallback = new ConstructorMensajeCastellano();
        }

        /// <summary>
        /// Crea el constructor de mensajes para el
        /// idioma solicitado.
        /// </summary>
        /// <param name="idioma">Idioma del constructor de mensajes a crear.</param>
        /// <returns>Constructor de mensajes creado.</returns>
        public IConstructorMensaje Crear(Idioma idioma)
        {
            IConstructorMensaje constructorMensaje;

            switch (idioma)
            {
                case Idioma.CASTELLANO:
                    constructorMensaje = new ConstructorMensajeCastellano();
                    break;

                case Idioma.INGLES:
                    constructorMensaje = new ConstructorMensajeIngles();
                    break;

                case Idioma.ITALIANO:
                    constructorMensaje = new ConstructorMensajeItaliano();
                    break;

                case Idioma.PORTUGUES:
                    constructorMensaje = new ConstructorMensajePortugues();
                    break;

                default:
                    //Si no se reconoce el lenguaje, se usa el establecido por defecto.
                    constructorMensaje = this._fallback;
                    break;
            }


            return new ConstructorMensajeDecorator(constructorMensaje, this._fallback);
        }
    }
}
