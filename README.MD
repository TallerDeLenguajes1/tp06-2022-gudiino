# tp6 2022
Desarrollo trabajo practico de taller de lenguaje 1

**OBJETIVOS**
Configuracion entorno para C#

Menejo de números en c#

Manejo de Caracteres en C#

**RESPUESTA EJERCICIO 4**
1. ¿String es una tipo por valor o un tipo por referencia?
- string es un tipo de referencia, se definen los operadores de igualdad == y != para comparar los valores de los objetos string, no las referencias.

2. ¿Qué secuencias de escape tiene el tipo string?
- Los literales de cadena pueden contener cualquier literal de carácter. Se incluyen secuencias de escape. En el ejemplo siguiente se usa una secuencia de escape \\\ para la barra diagonal inversa, \u0066 para la letra f y \n para la nueva línea.

3. ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
- Los literales de cadena textual empiezan por @ y también se incluyen entre comillas dobles. Por ejemplo:
    - @"good morning"  // a string literal
- La ventaja de las cadenas textuales es que las secuencias de escape no se procesan, lo que facilita la escritura. Por ejemplo, el texto siguiente coincide con un nombre de archivo de Windows completo:
    - @"c:\Docs\Source\a.txt"  // en vez de "c:\\\Docs\\Source\\a.txt"
- Para incluir una comilla doble en una cadena @-quoted, doblela:
    - @"""Ahoy!"" cried the captain." // "Ahoy!" cried the captain.

**Autor**
##_Jorge Juan Gudiño_


