# 🎓 Diagrama POO - Principios de Programación Orientada a Objetos

## 📐 Jerarquía de Clases (Herencia)

```
                    ┌─────────────────────────────┐
                    │   DispositivoBase           │
                    │   (Clase Abstracta)         │
                    ├─────────────────────────────┤
                    │ # int Id                    │
                    │ # string Nombre             │
                    │ # bool EstaEncendido        │
                    ├─────────────────────────────┤
                    │ + Encender()                │
                    │ + Apagar()                  │
                    │ + abstract ActualizarEstado()│
                    │ + abstract ToString()       │
                    └──────────────┬──────────────┘
                                   │
                    ┌──────────────┴──────────────┐
                    │      HERENCIA (Extends)     │
                    └──────────────┬──────────────┘
                                   │
        ┌──────────────┬───────────┴────────┬──────────────┐
        │              │                    │              │
        ▼              ▼                    ▼              ▼
┌───────────────┐ ┌───────────────┐ ┌───────────────┐ ┌───────────────┐
│   🌡️ CLIMA   │ │  🔒 SEGURIDAD │ │  📺 MULTIMEDIA│ │  💡 LUZ       │
└───────────────┘ └───────────────┘ └───────────────┘ └───────────────┘
```

## 🔍 Detalle de Herencia por Módulo

### 🌡️ Módulo Clima

```
┌─────────────────────────────────────┐
│        DispositivoBase              │
│         (Abstracta)                 │
└────────────┬────────────────────────┘
             │
    ┌────────┴────────┐
    │                 │
    ▼                 ▼
┌─────────────┐  ┌──────────────────────┐
│ Termostato  │  │ SensorCalidadAire    │
├─────────────┤  ├──────────────────────┤
│ - temperatura│ │ - nivelCO2           │
│ - modo       │  │ - nivelCOV           │
│ - humedad    │  │ - calidadAire        │
├─────────────┤  ├──────────────────────┤
│ + ActualizarEstado() │ │ + ActualizarEstado()│
│ + ToString() │  │ + ToString()         │
└─────────────┘  └──────────────────────┘
```

### 🔒 Módulo Seguridad

```
┌─────────────────────────────────────┐
│        DispositivoBase              │
│         (Abstracta)                 │
└────────────┬────────────────────────┘
             │
    ┌────────┴────────┬────────┬────────┐
    │                 │        │        │
    ▼                 ▼        ▼        ▼
┌─────────────┐  ┌──────────┐ ┌──────┐ ┌──────────────┐
│   Camara    │  │  Sensor  │ │Alarma│ │ControlAcceso │
│             │  │Movimiento│ │      │ │              │
├─────────────┤  ├──────────┤ ├──────┤ ├──────────────┤
│- resolucion │  │- sensib. │ │- tipo│ │- bloqueado   │
│- grabando   │  │- ultima  │ │- vol.│ │- metodo      │
│- deteccion  │  │  detec.  │ │- arm.│ │- registro    │
│- ubicacion  │  │- zona    │ │      │ │              │
├─────────────┤  ├──────────┤ ├──────┤ ├──────────────┤
│+ Actualizar │  │+ Actual. │ │+ Act.│ │+ Actualizar  │
│  Estado()   │  │  Estado()│ │Estado│ │  Estado()    │
│+ ToString() │  │+ToString │ │+Str()│ │+ ToString()  │
└─────────────┘  └──────────┘ └──────┘ └──────────────┘
```

### 📺 Módulo Multimedia

```
┌─────────────────────────────────────┐
│        DispositivoBase              │
│         (Abstracta)                 │
└────────────┬────────────────────────┘
             │
    ┌────────┴────────┐
    │                 │
    ▼                 ▼
┌──────────────┐  ┌──────────────┐
│SistemaMusica │  │  Television  │
├──────────────┤  ├──────────────┤
│- volumen     │  │- canal       │
│- cancion     │  │- volumen     │
│- artista     │  │- entrada     │
│- reproduciendo│ │- resolucion  │
├──────────────┤  ├──────────────┤
│+ ActualizarEstado()│ │+ ActualizarEstado()│
│+ ToString()  │  │+ ToString()  │
└──────────────┘  └──────────────┘
```

### 💡 Módulo Iluminación

```
┌─────────────────────────────────────┐
│        DispositivoBase              │
│         (Abstracta)                 │
└────────────┬────────────────────────┘
             │
    ┌────────┴────────┐
    │                 │
    ▼                 ▼
┌─────────────┐  ┌──────────────────┐
│     Luz     │  │ SensorAmbiental  │
├─────────────┤  ├──────────────────┤
│- intensidad │  │- temperatura     │
│- color      │  │- humedad         │
│- ubicacion  │  │- luminosidad     │
├─────────────┤  ├──────────────────┤
│+ ActualizarEstado()│ │+ ActualizarEstado()│
│+ ToString() │  │+ ToString()      │
└─────────────┘  └──────────────────┘
```

---

## 🎯 Los 4 Pilares de POO Implementados

### 1️⃣ ENCAPSULACIÓN 🔒

**Definición**: Ocultar los detalles internos y exponer solo lo necesario.

```csharp
public class Camara : DispositivoBase
{
    // ✅ Campos PRIVADOS (encapsulados)
    private string _resolucion;
    private bool _estaGrabando;
    private bool _deteccionMovimiento;
    private string _ubicacion;

    // ✅ Propiedades PÚBLICAS (acceso controlado)
    public string Resolucion
    {
        get { return _resolucion; }
        set { _resolucion = value; }
    }

    public bool EstaGrabando
    {
        get { return _estaGrabando; }
        set { _estaGrabando = value; }
    }
}
```

**Beneficios**:
- ✅ Protege los datos internos
- ✅ Control sobre cómo se accede y modifica la información
- ✅ Facilita el mantenimiento

---

### 2️⃣ ABSTRACCIÓN 🎭

**Definición**: Mostrar solo la funcionalidad esencial, ocultando la complejidad.

```csharp
// ✅ Clase ABSTRACTA - Define el contrato
public abstract class DispositivoBase
{
    protected int Id { get; set; }
    protected string Nombre { get; set; }
    protected bool EstaEncendido { get; set; }

    // ✅ Método ABSTRACTO - Debe ser implementado por las clases hijas
    public abstract void ActualizarEstado();
    
    // ✅ Método CONCRETO - Compartido por todas las clases hijas
    public void Encender()
    {
        EstaEncendido = true;
    }

    public void Apagar()
    {
        EstaEncendido = false;
    }
}
```

**Beneficios**:
- ✅ Define un contrato común para todos los dispositivos
- ✅ Simplifica el uso de objetos complejos
- ✅ Permite trabajar con dispositivos de forma genérica

---

### 3️⃣ HERENCIA 👨‍👦

**Definición**: Crear nuevas clases basadas en clases existentes, heredando sus características.

```csharp
// ✅ Clase BASE
public abstract class DispositivoBase
{
    protected int Id { get; set; }
    protected string Nombre { get; set; }
    protected bool EstaEncendido { get; set; }
}

// ✅ Clase DERIVADA - Hereda de DispositivoBase
public class Camara : DispositivoBase
{
    // Hereda: Id, Nombre, EstaEncendido
    
    // Agrega propiedades específicas
    private string _resolucion;
    private bool _estaGrabando;
    
    // Constructor que usa la base
    public Camara(int id, string nombre, bool encendido, ...)
        : base(id, nombre, encendido)  // ✅ Llama al constructor base
    {
        _resolucion = resolucion;
        _estaGrabando = estaGrabando;
    }
}
```

**Jerarquía**:
```
DispositivoBase (Padre)
    ├── Termostato (Hijo)
    ├── SensorCalidadAire (Hijo)
    ├── Camara (Hijo)
    ├── SensorMovimiento (Hijo)
    ├── Alarma (Hijo)
    ├── ControlAcceso (Hijo)
    ├── SistemaMusica (Hijo)
    ├── Television (Hijo)
    ├── Luz (Hijo)
    └── SensorAmbiental (Hijo)
```

**Beneficios**:
- ✅ Reutilización de código
- ✅ Evita duplicación
- ✅ Facilita el mantenimiento

---

### 4️⃣ POLIMORFISMO 🦎

**Definición**: Capacidad de objetos de diferentes clases de responder al mismo método de manera diferente.

```csharp
// ✅ Método abstracto en la clase base
public abstract class DispositivoBase
{
    public abstract void ActualizarEstado();
}

// ✅ Implementación específica en Camara
public class Camara : DispositivoBase
{
    public override void ActualizarEstado()
    {
        if (!EstaEncendido)
        {
            _estaGrabando = false;
            _deteccionMovimiento = false;
        }
        // Lógica específica de cámara
    }
}

// ✅ Implementación específica en Alarma
public class Alarma : DispositivoBase
{
    public override void ActualizarEstado()
    {
        if (!EstaEncendido)
        {
            _estaArmada = false;
        }
        // Lógica específica de alarma
    }
}

// ✅ USO POLIMÓRFICO
List<DispositivoBase> dispositivos = new List<DispositivoBase>();
dispositivos.Add(new Camara(...));
dispositivos.Add(new Alarma(...));

// Cada dispositivo ejecuta SU PROPIA versión de ActualizarEstado()
foreach (DispositivoBase dispositivo in dispositivos)
{
    dispositivo.ActualizarEstado(); // ✅ Polimorfismo en acción
}
```

**Beneficios**:
- ✅ Flexibilidad en el código
- ✅ Permite tratar objetos diferentes de manera uniforme
- ✅ Facilita la extensibilidad

---

## 🏗️ Patrón Singleton en Controladores

```csharp
public class SeguridadController
{
    // ✅ Instancia única privada
    private static SeguridadController _instancia;
    
    // ✅ Listas privadas (encapsulación)
    private List<Camara> _camaras;
    private List<SensorMovimiento> _sensoresMovimiento;
    private List<Alarma> _alarmas;
    private List<ControlAcceso> _controlesAcceso;
    
    // ✅ Propiedad pública para acceder a la instancia única
    public static SeguridadController Instancia
    {
        get
        {
            if (_instancia == null)
                _instancia = new SeguridadController();
            return _instancia;
        }
    }
    
    // ✅ Constructor PRIVADO (evita múltiples instancias)
    private SeguridadController()
    {
        _camaras = new List<Camara>();
        _sensoresMovimiento = new List<SensorMovimiento>();
        _alarmas = new List<Alarma>();
        _controlesAcceso = new List<ControlAcceso>();
        CargarDispositivosPorDefecto();
    }
}
```

**Uso del Singleton**:
```csharp
// ✅ Siempre obtienes la MISMA instancia
var controller1 = SeguridadController.Instancia;
var controller2 = SeguridadController.Instancia;
// controller1 == controller2 (misma referencia)
```

**Beneficios**:
- ✅ Una sola instancia compartida en toda la aplicación
- ✅ Datos centralizados
- ✅ Evita inconsistencias

---

## 📊 Resumen de Implementación POO

| Principio | Implementación | Ubicación |
|-----------|---------------|-----------|
| **Encapsulación** | Campos privados + Propiedades públicas | Todos los modelos |
| **Abstracción** | Clase abstracta `DispositivoBase` | `Models/DispositivoBase.cs` |
| **Herencia** | 10 clases heredan de `DispositivoBase` | Todos los modelos |
| **Polimorfismo** | Método `ActualizarEstado()` sobrescrito | Todos los modelos |
| **Singleton** | Instancia única de controladores | Todos los controladores |

---

## 🎯 Ventajas del Diseño POO

✅ **Mantenibilidad**: Cambios en `DispositivoBase` afectan a todos los dispositivos  
✅ **Escalabilidad**: Fácil agregar nuevos tipos de dispositivos  
✅ **Reutilización**: Código compartido en la clase base  
✅ **Organización**: Estructura clara y lógica  
✅ **Testabilidad**: Fácil de probar cada componente  
✅ **Consistencia**: Todos los dispositivos siguen el mismo patrón
