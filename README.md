# PasswordGenerator-Csharp (Windows Forms)

Este proyecto implementa una clase **Password** en C#, integrada dentro de una aplicación **Windows Forms**.  
El objetivo es practicar programación orientada a objetos y mostrar visualmente la generación y validación de contraseñas.

## Tecnologías utilizadas
- Lenguaje: **C#**
- Entorno: **Visual Studio**
- Interfaz gráfica: **Windows Forms**

##  Funcionalidades
- Clase `Password` con atributos:
  - `longitud`: tamaño de la contraseña (por defecto 8).
  - `valor`: contraseña generada.
- Métodos:
  - `generarPassword()`: crea una contraseña aleatoria con la longitud definida.
  - `esFuerte()`: devuelve `true` si la contraseña es fuerte (más de 2 mayúsculas, más de 1 minúscula y más de 5 números).
  - `LongitudMinima()`: nos permite verificar que la contraseña que crea el usuario cumple con la longitud minima de una contraseña.
- Interfaz Windows Forms para:
  - Generar contraseñas automáticamente.
  - Mostrar si la contraseña ingresada es fuerte o débil en pantalla.

##  Extra
-El programa ademas le pide al usuario que repita la contraseña validando agregando asi un metodo mas de validacion y confirmacion.
