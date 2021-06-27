## Challenge propuesto por Wildar

Se debe refactorizar la clase __FormaGeometrica__ para que soporte más lenguajes que los actuales y se puedan agregar otras formas facilmente.

### Crear una nueva forma geometrica
Para crear una nueva forma geometrica, se debe crear una clase que implemente la interfaz __IFormaGeometrica__. Si a esta forma geometrica se la quiere incluir en __FactoryFormaGeometrica__, se deberá agregar un método especial en esa misma fabrica.

### Crear un idioma para la impresión de formas geometricas.
Para crear un nuevo idioma para la impresión de formas geometricas, se debe crear una clase que implemente la interfaz __IConstructorMensaje__ para el idioma deseado.

En caso de que se quiere agregar este constructor de mensajes a la fabrica __FactoryConstructorMensaje__, se deberá crear el idioma correspondiente en el __enum__ __FactoryConstructorMensaje.Idioma__ y agregar el código faltante en __FactoryConstructorMensaje.Crear__ para el nuevo idioma
