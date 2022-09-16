Este código responde al ejercicio práctico del tema 6, 
apartado input.touch() par desarrollo en dispositivos móviles,
en mi caso para IPhone, esto se puede configurar en Unity,
para el control de los taps y acciones sobre objetos.

El código está escrito en C# para Unity con Visual Studio Community.

Para el testeo he utilizado la app para IOS de Unity y la conexión por cable usb a PC.

Desde el play en Unity, se puede ver el resultado en la pantalla movil.

Los objetos esfera y cubo, modifican su apariencia y comportamiento,
en base a los taps.

En el caso de un solo tap, la clase Tapcotroller lo informa y en consecuencia,
la clase ActivateObject, dependiendo del objeto, número de taps y Ray Cast,
cambia el aspecto del material a rojo, o en el caso de un doble tap,
desaparece/aparece un objeto.

Espero que os sirva como ayuda. saludos.