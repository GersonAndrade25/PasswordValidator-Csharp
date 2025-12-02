# PasswordGenerator-Csharp

Este proyecto modela una clase **Password** en C#, diseñada para generar y validar contraseñas según criterios de seguridad.

## Características
- Atributos:
  - `longitud`: tamaño de la contraseña (por defecto 8).
  - `valor`: contraseña generada.
- Métodos:
  - `generarPassword()`: genera una contraseña aleatoria con la longitud definida.
  - `esFuerte()`: devuelve `true` si la contraseña es fuerte (más de 2 mayúsculas, más de 1 minúscula y más de 5 números).
