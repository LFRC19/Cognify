# Cognify
Proyecto Final Patrondes de Diseño


# Cognify

**Transformando la rehabilitación criminal mediante la implantación de recuerdos artificiales.**

---

## Índice

- [Descripción del Proyecto](#descripción-del-proyecto)
- [Características Principales](#características-principales)
- [Tecnologías Utilizadas](#tecnologías-utilizadas)
- [Requisitos Previos](#requisitos-previos)
- [Instalación y Configuración](#instalación-y-configuración)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Uso del Proyecto](#uso-del-proyecto)
- [Flujo de Navegación](#flujo-de-navegación)
- [Contribución](#contribución)
- [Licencia](#licencia)
- [Contacto](#contacto)

---

## Descripción del Proyecto

**Cognify** es una aplicación web prototipo que propone un enfoque innovador para la rehabilitación criminal. El sistema está diseñado para tratar a los delincuentes como pacientes, ofreciendo una alternativa al encarcelamiento tradicional mediante la implantación de recuerdos artificiales. Estos recuerdos buscan generar empatía, remordimiento y comprensión de las consecuencias de sus acciones, facilitando una reintegración efectiva a la sociedad.

Este proyecto representa una implementación básica del sistema **Cognify**, utilizando el patrón de diseño **Modelo-Vista-Controlador (MVC)** con **ASP.NET MVC** en **C#**. Incluye interfaces de usuario diseñadas con **HTML** y **Tailwind CSS**, y simula interacciones clave del sistema.

---

## Características Principales

- **Formulario de Datos del Delincuente**: Permite ingresar información personal y seleccionar el tipo de crimen.
- **Integración con API de RandomUser**: Carga datos aleatorios para simular información de un individuo.
- **Personalización de Recuerdos**: Opciones para ajustar los recuerdos a implantar según el tipo de crimen.
- **Simulación del Proceso de Rehabilitación**: Muestra el progreso y resultados de la implantación de recuerdos.
- **Información para Familiares**: Proporciona informes sobre los cambios en el sujeto.
- **Aplicaciones Adicionales**: Expone otros usos potenciales de **Cognify**, como tratamientos de pérdida de memoria y PTSD.
- **Formulario de Contacto**: Permite a los usuarios enviar consultas o solicitar más información.

---

## Tecnologías Utilizadas

- **ASP.NET MVC** con **C#**
- **HTML5** y **Razor** para las vistas
- **Tailwind CSS** para el diseño y estilo
- **JavaScript** y **Axios** para interacciones en el cliente
- **API de RandomUser** para generar datos aleatorios
- **Newtonsoft.Json** para el manejo de JSON en C#
- **Visual Studio** o **Visual Studio Code** como entorno de desarrollo

---

## Requisitos Previos

- **.NET Framework** (versión 4.7.2 o superior) o **.NET Core** (según la versión de ASP.NET MVC utilizada)
- **Visual Studio 2019/2022** o **Visual Studio Code** con extensiones para C# y ASP.NET
- **SQL Server** (si se decide implementar una base de datos, aunque no es necesario para este prototipo)

---

## Instalación y Configuración

Sigue estos pasos para configurar y ejecutar el proyecto en tu máquina local.

### 1. Clonar el Repositorio

```bash
git clone https://github.com/tu-usuario/cognify.git
```

### 2. Abrir el Proyecto en Visual Studio

- Navega hasta la carpeta del proyecto.
- Abre el archivo `Cognify.sln` en **Visual Studio**.

### 3. Restaurar Paquetes NuGet

- En **Visual Studio**, ve a `Herramientas` > `Administrador de paquetes NuGet` > `Consola del Administrador de paquetes`.
- Ejecuta el siguiente comando para restaurar los paquetes necesarios:

  ```powershell
  Update-Package -reinstall
  ```

### 4. Compilar el Proyecto

- Presiona `Ctrl + Shift + B` para compilar el proyecto y asegurarte de que no haya errores.

### 5. Ejecutar la Aplicación

- Presiona `F5` o haz clic en el botón `Iniciar` para ejecutar la aplicación en modo de depuración.
- El navegador predeterminado se abrirá y cargará la aplicación en `http://localhost:xxxx/` (el puerto puede variar).

---

## Estructura del Proyecto

```
Cognify/
├── Controllers/
│   ├── HomeController.cs
│   ├── CriminalController.cs
│   ├── MemoryController.cs
│   └── SimulationController.cs
├── Models/
│   ├── CriminalViewModel.cs
│   ├── MemoryCustomizationViewModel.cs
│   └── SimulationResultViewModel.cs
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   ├── About.cshtml
│   │   ├── AdditionalApplications.cshtml
│   │   └── Contact.cshtml
│   ├── Criminal/
│   │   └── Form.cshtml
│   ├── Memory/
│   │   └── Customization.cshtml
│   ├── Simulation/
│   │   └── Result.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       └── _ViewStart.cshtml
├── Scripts/
├── Content/
├── App_Start/
│   └── RouteConfig.cs
├── Web.config
└── README.md
```

---

## Uso del Proyecto

### 1. Página de Inicio

- Accede a `http://localhost:xxxx/` para ver la página de inicio.
- Desde aquí, puedes navegar a diferentes secciones usando el menú o los botones disponibles.

### 2. Comenzar Rehabilitación

- Haz clic en **"Comenzar Rehabilitación"** para iniciar el proceso.
- Serás dirigido al formulario de datos del delincuente.

### 3. Formulario de Datos del Delincuente

- Puedes ingresar manualmente los datos o cargar datos aleatorios haciendo clic en **"Cargar Datos Aleatorios"**.
- Completa los campos requeridos y selecciona el tipo de crimen.
- Haz clic en **"Continuar"** para avanzar.

### 4. Personalización de Recuerdos

- Personaliza los recuerdos a implantar según el tipo de crimen seleccionado.
- Ajusta los parámetros disponibles y haz clic en **"Iniciar Simulación"**.

### 5. Resultados de la Simulación

- Después de la simulación, se mostrarán los resultados y detalles de la rehabilitación.
- Puedes finalizar el proceso o regresar al inicio.

### 6. Otras Secciones

- **Acerca de**: Información detallada sobre **Cognify**.
- **Cómo Funciona**: Explicación del proceso y aspectos técnicos.
- **Aplicaciones**: Otros usos potenciales de la tecnología.
- **Contacto**: Formulario para enviar consultas o solicitar información adicional.

---

## Flujo de Navegación

1. **Inicio (`/`)**
   - Presenta el sistema y opciones para navegar.
2. **Formulario de Datos (`/Criminal/Form`)**
   - Ingreso de datos personales y selección del tipo de crimen.
3. **Personalización (`/Memory/Customization`)**
   - Personalización de los recuerdos a implantar.
4. **Resultados (`/Simulation/Result`)**
   - Muestra los resultados de la simulación.
5. **Otras Páginas**
   - **Acerca de (`/Home/About`)**
   - **Cómo Funciona (`/Home/ProcessInfo`)**
   - **Aplicaciones (`/Home/AdditionalApplications`)**
   - **Contacto (`/Home/Contact`)**

---

## Contribución

Este proyecto es un prototipo y está abierto a contribuciones. Si deseas mejorar el código, agregar funcionalidades o corregir errores, sigue estos pasos:

1. Haz un fork del repositorio.
2. Crea una rama para tu función (`git checkout -b feature/nueva-funcion`).
3. Realiza tus cambios y haz commits descriptivos.
4. Envía tus cambios (`git push origin feature/nueva-funcion`).
5. Abre un Pull Request detallando tus modificaciones.

---

## Licencia

Este proyecto se distribuye bajo la licencia MIT. Puedes ver el archivo [LICENSE](LICENSE) para más detalles.

---

## Contacto

Si tienes preguntas, sugerencias o necesitas más información, no dudes en ponerte en contacto:

- **Correo Electrónico**: l21210421@tectijuana.edu.mx


---

¡Gracias por tu interés en **Cognify**! Esperamos que este proyecto sea de utilidad y sirva como base para futuras innovaciones en el campo de la rehabilitación criminal y la salud mental.
