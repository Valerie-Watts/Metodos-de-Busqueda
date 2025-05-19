
# Proyecto de Métodos de Búsqueda y Tabla Hash en C#

## 📌 Introducción

Este proyecto en C# implementa diferentes métodos de búsqueda en estructuras de datos. Incluye:

- Búsqueda Secuencial en un arreglo no ordenado.
- Búsqueda Binaria en un arreglo ordenado.
- Implementación de una Tabla Hash con resolución de colisiones mediante listas (hash con encadenamiento).

El objetivo es comparar el comportamiento, uso y eficiencia de cada método, dependiendo del tipo de datos y estructura utilizada.

---

## ⚙️ Instalación y Ejecución

1. Clona el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/nombre-del-repositorio.git


2. Abre el proyecto con Visual Studio o cualquier editor compatible con .NET.

3. Asegúrate de tener instalado el SDK de .NET (versión 6 o superior recomendada).

4. Compila y ejecuta el proyecto:

   ```bash
   dotnet build
   dotnet run
   ```

---

## 🧠 Explicación del Código

### Estructura del Proyecto

* `Program.cs`: Contiene el menú principal y la lógica de interacción con el usuario.
* `Hash.cs`: Contiene la clase `Hash` que implementa una tabla hash con inserción, búsqueda y visualización.
* Los métodos de búsqueda (`Binary`, `SecuentialUnordered`) están implementados como funciones auxiliares dentro de la clase `Hash`.

### Métodos implementados

#### 🔍 Búsqueda Secuencial No Ordenada

Recorre todos los elementos del arreglo hasta encontrar el valor deseado o llegar al final.

#### 🔍 Búsqueda Binaria

Divide el arreglo ordenado en mitades sucesivas para buscar de forma más eficiente.

#### 📦 Tabla Hash

Implementa una estructura de datos para almacenar y acceder rápidamente a pares clave-valor. Usa listas para manejar colisiones.

---

## 📊 Análisis de Rendimiento

| Método                 | Eficiencia Promedio | Mejor Caso | Peor Caso           | Estructura Requerida |
| ---------------------- | ------------------- | ---------- | ------------------- | -------------------- |
| Búsqueda Secuencial    | O(n)                | O(1)       | O(n)                | Arreglo no ordenado  |
| Búsqueda Binaria       | O(log n)            | O(1)       | O(log n)            | Arreglo ordenado     |
| Búsqueda en Tabla Hash | O(1) promedio       | O(1)       | O(n) con colisiones | HashTable            |

> ⚠️ Nota: La tabla hash depende de una buena función de hash y una distribución equilibrada de las claves.

---

## ✅ Conclusiones

* **Búsqueda Secuencial** es simple y efectiva cuando los datos no están ordenados, pero no es eficiente para conjuntos grandes.
* **Búsqueda Binaria** es mucho más rápida en arreglos ordenados, pero requiere que los datos estén previamente organizados.
* **Tabla Hash** ofrece el mejor rendimiento promedio para búsquedas, aunque sufre si hay muchas colisiones o una mala función de dispersión.

👉 En general:

* Usa **búsqueda secuencial** si el arreglo es pequeño y no ordenado.
* Usa **búsqueda binaria** si los datos están ordenados y necesitas eficiencia.
* Usa **tabla hash** cuando necesitas acceso rápido y frecuente a elementos por clave.

---

## 🧑‍💻 Autor

Este proyecto fue realizado como práctica para explorar y comparar distintos algoritmos de búsqueda en estructuras de datos.

```
Valerie Watts Feria
