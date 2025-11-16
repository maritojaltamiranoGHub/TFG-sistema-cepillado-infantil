# TFG-sistema-cepillado-infantil (Prototipo)

Este repositorio contiene el código fuente (Parcial) del prototipo desarrollado para el Trabajo Final de Grado (TFG) titulado: *"Análisis Algorítmico del Cepillado Infantil: Validación de una Metodología de Bajo Costo con un Prototipo Móvil Sensorizado"*.

---

## Descripción del Proyecto

El objetivo de este proyecto es validar una metodología de software capaz de transformar la supervisión subjetiva de la higiene bucal infantil en una evaluación objetiva y medible. El sistema consiste en una aplicación móvil que analiza los datos de movimiento de un cepillo de dientes (capturados a través de sensores genéricos) para proporcionar retroalimentación precisa sobre la calidad de la técnica de cepillado.

El núcleo de la solución es un motor de análisis que utiliza el algoritmo **Dynamic Time Warping (DTW)** para comparar el patrón de cepillado de una sesión real con un patrón de referencia ideal.

## Arquitectura del Software

El prototipo está desarrollado siguiendo los principios de la **Arquitectura Limpia (Clean Architecture)** para garantizar una clara separación de responsabilidades, mantenibilidad y escalabilidad. La solución está organizada en cuatro proyectos principales:

-   **`Sistema.Cepillado.Dominio`**: El núcleo del sistema. Contiene las entidades de negocio (Tutor, Nino, Sesion) y los contratos (interfaces) que definen la lógica de negocio, siendo independiente de cualquier tecnología externa.
-   **`Sistema.Cepillado.Aplicacion`**: Contiene los casos de uso y la lógica que orquesta las entidades del Dominio. Actúa como mediador entre la presentación y el núcleo de negocio.
-   **`Sistema.Cepillado.Infraestructura`**: Implementa los detalles técnicos, como el acceso a la base de datos. Contiene los repositorios que interactúan con SQLite.
-   **`Sistema.Cepillado.Presentacion`**: La capa de interfaz de usuario. Es una aplicación móvil desarrollada con .NET MAUI Blazor.

## Pila Tecnológica

-   **Framework:** .NET MAUI Blazor (C#)
-   **Base de Datos Local:** SQLite
-   **ORM:** Sqlite-net
-   **Algoritmo Principal:** Dynamic Time Warping (DTW) para el análisis de series temporales.

##  Cómo Empezar

Para compilar y ejecutar este prototipo, se necesita el siguiente entorno de desarrollo:

1.  **Visual Studio 2022** (o superior) con la carga de trabajo ".NET Multi-platform App UI development" instalada.
2.  **Configuración del emulador de Android (Se puede usar Windows para validar su funcionamineto)** o un dispositivo físico Android.

**Pasos para la ejecución:**

1.  Clonar este repositorio:
2.  Abrir el archivo "Sistema.Cepillado.sln" con Visual Studio.
3.  Restaurar los paquetes de NuGet (debería hacerse automáticamente al abrir la solución).
4.  Seleccionar el proyecto "Sistema.Cepillado.Presentacion" como proyecto de inicio.
5.  Elegir un emulador de Android de destino y presionar "Ejecutar" (F5).

> **Nota importante:** Este prototipo funciona con una base de datos SQLite local que se crea en el dispositivo la primera vez que se ejecuta la aplicación. La importación de datos de sensores se realiza manualmente a través de la interfaz de la aplicación, utilizando archivos `.csv` (como se describe en el TFG), para aislar y validar el motor de análisis.

##  Autor

-   **MARIO JAVIER ALTAMIRANO - VINF013416**
-   Trabajo Final de Grado para la carrera de licenciatura en Informática
-   UNIVERSIDAD SIGLO 21 - 2025
