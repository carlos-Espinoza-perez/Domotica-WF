# 📊 Diagrama de Estructura del Proyecto - Sistema Domótica

## 🗂️ Estructura de Archivos

```
Domotica/
│
├── 📁 Models/                          # Capa de Modelos (Entidades)
│   ├── DispositivoBase.cs             # ⭐ Clase abstracta base
│   │
│   ├── 🌡️ Módulo Clima
│   │   ├── Termostato.cs              # Hereda de DispositivoBase
│   │   └── SensorCalidadAire.cs       # Hereda de DispositivoBase
│   │
│   ├── 🔒 Módulo Seguridad
│   │   ├── Camara.cs                  # Hereda de DispositivoBase
│   │   ├── SensorMovimiento.cs        # Hereda de DispositivoBase
│   │   ├── Alarma.cs                  # Hereda de DispositivoBase
│   │   └── ControlAcceso.cs           # Hereda de DispositivoBase
│   │
│   ├── 📺 Módulo Multimedia
│   │   ├── SistemaMusica.cs           # Hereda de DispositivoBase
│   │   └── Television.cs              # Hereda de DispositivoBase
│   │
│   └── 💡 Módulo Iluminación
│       ├── Luz.cs                     # Hereda de DispositivoBase
│       └── SensorAmbiental.cs         # Hereda de DispositivoBase
│
├── 📁 Controllers/                     # Capa de Lógica de Negocio
│   ├── ClimaController.cs             # 🔹 Singleton - Gestiona clima
│   ├── SeguridadController.cs         # 🔹 Singleton - Gestiona seguridad
│   ├── MultimediaController.cs        # 🔹 Singleton - Gestiona multimedia
│   ├── IluminacionController.cs       # 🔹 Singleton - Gestiona iluminación
│   ├── SistemaIluminacionController.cs
│   └── InicioController.cs
│
├── 📁 Views/                           # Capa de Presentación (UI)
│   │
│   ├── 🏠 Vistas Principales
│   │   ├── _Layout.cs                 # Layout principal
│   │   ├── _Layout.Designer.cs
│   │   ├── _Layout.resx
│   │   │
│   │   ├── Inicio.cs                  # Vista de inicio
│   │   ├── Inicio.Designer.cs
│   │   ├── Inicio.resx
│   │   │
│   │   ├── Clima.cs                   # Vista de clima
│   │   ├── Clima.Designer.cs
│   │   ├── Clima.resx
│   │   │
│   │   ├── Seguridad.cs               # ✨ Vista de seguridad (REFACTORIZADA)
│   │   ├── Seguridad.Designer.cs      # ✨ Con colores modernos
│   │   ├── Seguridad.resx
│   │   │
│   │   ├── Multimedia.cs              # Vista de multimedia
│   │   ├── Multimedia.Designer.cs
│   │   ├── Multimedia.resx
│   │   │
│   │   ├── FormIluminacion.cs         # Vista de iluminación
│   │   ├── FormIluminacion.Designer.cs
│   │   └── FormIluminacion.resx
│   │
│   ├── 🔧 Formularios Modales
│   │   ├── FormAgregarLuz.cs
│   │   ├── FormAgregarLuz.Designer.cs
│   │   │
│   │   ├── FormAgregarMultimedia.cs
│   │   ├── FormAgregarMultimedia.Designer.cs
│   │   │
│   │   ├── FormAgregarSensor.cs       # ✨ NUEVO - Modal para agregar sensores
│   │   ├── FormAgregarSensor.Designer.cs
│   │   └── FormAgregarSensor.resx
│   │
│   └── 📁 Component/                   # Componentes personalizados
│       ├── PanelRedondeado.cs         # Panel con bordes redondeados
│       ├── SliderModerno.cs           # Control deslizante moderno
│       └── ConfigurarGraficaModerna.cs # Gráfica de tendencias
│
├── 📁 Properties/                      # Configuración del proyecto
│   ├── AssemblyInfo.cs
│   ├── Resources.Designer.cs
│   ├── Resources.resx
│   ├── Settings.Designer.cs
│   └── Settings.settings
│
├── 📄 Program.cs                       # Punto de entrada de la aplicación
├── 📄 App.config                       # Configuración de la app
├── 📄 Domotica.csproj                  # Archivo del proyecto
├── 📄 Domotica.sln                     # Solución de Visual Studio
├── 📄 packages.config                  # Paquetes NuGet
└── 📄 .gitignore                       # Archivos ignorados por Git
```

## 📦 Dependencias Externas

```
NuGet Packages:
└── FontAwesome.Sharp (v6.6.0)
    └── Iconos vectoriales para la interfaz
```

## 🔄 Flujo de Datos

```
┌─────────────┐
│   Views     │  ← Capa de Presentación (UI)
│  (Forms)    │
└──────┬──────┘
       │
       │ Llama métodos
       ↓
┌─────────────┐
│ Controllers │  ← Capa de Lógica de Negocio
│ (Singleton) │     - CRUD operations
└──────┬──────┘     - Business logic
       │
       │ Manipula
       ↓
┌─────────────┐
│   Models    │  ← Capa de Datos (Entidades)
│  (Classes)  │     - Propiedades
└─────────────┘     - Métodos de actualización
```

## 🎨 Módulos del Sistema

### 1️⃣ Módulo Clima 🌡️
- **Modelos**: Termostato, SensorCalidadAire
- **Controlador**: ClimaController
- **Vista**: Clima.cs

### 2️⃣ Módulo Seguridad 🔒 (REFACTORIZADO)
- **Modelos**: Camara, SensorMovimiento, Alarma, ControlAcceso
- **Controlador**: SeguridadController
- **Vista**: Seguridad.cs ✨
- **Modal**: FormAgregarSensor.cs ✨

### 3️⃣ Módulo Multimedia 📺
- **Modelos**: SistemaMusica, Television
- **Controlador**: MultimediaController
- **Vista**: Multimedia.cs

### 4️⃣ Módulo Iluminación 💡
- **Modelos**: Luz, SensorAmbiental
- **Controlador**: IluminacionController
- **Vista**: FormIluminacion.cs

---

## ✨ Cambios Recientes

### Vista Seguridad (Refactorizada)
- ✅ Colores modernos (grises suaves, azul #3498db)
- ✅ Tipografía Segoe UI
- ✅ Toggle funcional para Sistema de Seguridad
- ✅ Botón "Agregar Sensor" en header
- ✅ Modal FormAgregarSensor para CRUD
- ✅ Mantiene estructura de 3 paneles original

### Archivos Nuevos
- `Views/FormAgregarSensor.cs`
- `Views/FormAgregarSensor.Designer.cs`
- `Views/FormAgregarSensor.resx`

### Archivos Modificados
- `Views/Seguridad.Designer.cs` - Colores y estilos actualizados
- `Domotica.csproj` - Referencias agregadas
