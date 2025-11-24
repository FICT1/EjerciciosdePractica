Ejercicios de Algoritmos de Búsqueda en C#

Este repositorio contiene una solución desarrollada en C# utilizando Windows Forms (.NET Framework 4.7.2). El proyecto consiste en una aplicación que permite navegar entre seis ejercicios, cada uno enfocado en demostrar el funcionamiento de distintos algoritmos de búsqueda y manipulación de datos, aplicados de forma manual para una mejor comprensión.

El objetivo principal es comprender cómo funcionan internamente los algoritmos de búsqueda sin depender exclusivamente de métodos automáticos.

Descripción del Proyecto

La aplicación implementa algoritmos de búsqueda básicos como búsqueda lineal, búsqueda binaria y búsqueda exhaustiva, permitiendo al usuario interactuar con los datos y observar el comportamiento de cada algoritmo en tiempo real.

Cada ejercicio se ejecuta en un formulario independiente, con botones de navegación para avanzar o retroceder entre ellos.


* Ejercicio 1: Búsqueda lineal en un arreglo

El sistema genera automáticamente un arreglo de 20 números enteros aleatorios, los cuales se muestran en pantalla.
El usuario ingresa un número y el programa utiliza una búsqueda lineal, recorriendo elemento por elemento hasta encontrarlo o determinar que no existe, mostrando su posición en caso de hallarse.

* Ejercicio 2: Búsqueda binaria en una lista ordenada

Se genera una lista de 30 números aleatorios que luego es ordenada.
Se implementa una búsqueda binaria manual, donde se divide la lista en mitades sucesivas comparando el valor central con el número buscado. El proceso muestra de forma visual los rangos evaluados hasta encontrar el valor o confirmar su inexistencia.

* Ejercicio 3: Búsqueda de texto dentro de una cadena

Este módulo permite ingresar un párrafo y una palabra.
El sistema realiza una búsqueda carácter por carácter sin usar métodos como Contains o IndexOf, contando cuántas veces aparece la palabra dentro del texto, ignorando diferencias entre mayúsculas y minúsculas.

* Ejercicio 4: Búsqueda de objetos en una colección

Se trabaja con una clase Estudiante que contiene las propiedades Id y Nombre, los cuales se muestran en un DataGridView.

Búsqueda por ID: Se realiza mediante búsqueda lineal recorriendo toda la lista.

Búsqueda por Nombre: Se aplica búsqueda binaria, en donde primero se ordena la colección alfabéticamente por nombre y luego se localiza el estudiante solicitado.

* Ejercicio 5: Búsqueda del valor máximo y mínimo

El programa genera una lista de números y la recorre manualmente para determinar:

El valor máximo.

El valor mínimo.

La cantidad de iteraciones realizadas.

No se utilizan métodos automáticos como Max() o Min(), permitiendo observar el proceso completo de comparación.

 * Ejercicio 6: Búsqueda en matriz 2D

Se genera una matriz de 10x10 con números aleatorios que se muestran en pantalla.
El usuario ingresa un número y el programa realiza una búsqueda exhaustiva recorriendo filas y columnas para encontrar su posición dentro de la matriz, indicando la fila y columna correspondiente o mostrando un mensaje si no existe.

Instrucciones de Ejecución

- Clonar este repositorio o descargar el código fuente.

- Abrir el archivo de solución en Visual Studio.

- Compilar la solución.

- Ejecutar el proyecto.

Desde el formulario principal se podrá navegar entre los distintos ejercicios mediante los botones de avance y retroceso.

📌 Objetivo del Proyecto

Comprender el funcionamiento básico de los algoritmos de búsqueda aplicados a diferentes estructuras de datos, fortaleciendo la lógica de programación y la comprensión de procesos internos en el desarrollo de software.
