namespace WildarChallenge.Data.Impresoras
{
    public class FactoryConstructorMensaje
    {
        public enum Idioma
        {
            INGLES, CASTELLANO, ITALIANO, PORTUGUES
        }

        private readonly IConstructorMensaje _fallback;

        public FactoryConstructorMensaje()
        {
            this._fallback = new ConstructorMensajeCastellano();
        }

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
                    constructorMensaje = this._fallback;
                    break;
            }


            return new ConstructorMensajeDecorator(constructorMensaje, this._fallback);
        }
    }
}
