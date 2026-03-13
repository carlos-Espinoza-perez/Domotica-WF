# Documento de Requisitos - Sistema Domótica Completo

## Introducción

Este documento define los requisitos para completar el sistema de domótica en C# Windows Forms, implementando las vistas de Clima, Seguridad y Multimedia. El sistema debe aplicar consistentemente los 4 principios de POO (Encapsulación, Abstracción, Herencia, Polimorfismo) siguiendo la arquitectura existente basada en DispositivoBase como clase abstracta y el patrón Singleton para controladores.

## Glosario

- **Sistema_Domotica**: Aplicación completa de domótica en C# Windows Forms
- **DispositivoBase**: Clase abstracta base que define la estructura común para todos los dispositivos
- **Controlador**: Clase que implementa patrón Singleton y gestiona la lógica de negocio de cada módulo
- **Vista_Clima**: Formulario para gestionar dispositivos de climatización
- **Vista_Seguridad**: Formulario para gestionar dispositivos de seguridad
- **Vista_Multimedia**: Formulario para gestionar dispositivos multimedia
- **Dispositivo_Clima**: Dispositivo que controla temperatura, humedad o calidad del aire
- **Dispositivo_Seguridad**: Dispositivo que proporciona funciones de seguridad (cámaras, sensores, alarmas)
- **Dispositivo_Multimedia**: Dispositivo que reproduce contenido de audio o video
- **CRUD**: Operaciones de Crear, Leer, Actualizar y Eliminar

## Requisitos

### Requisito 1: Modelos de Dispositivos de Clima

**User Story:** Como desarrollador, quiero crear modelos de dispositivos de clima que hereden de DispositivoBase, para aplicar los principios de herencia y polimorfismo en el módulo de climatización.

#### Acceptance Criteria

1. THE Sistema_Domotica SHALL crear una clase Termostato que herede de DispositivoBase
2. THE Termostato SHALL encapsular propiedades privadas para temperatura objetivo, temperatura actual, modo de operación y velocidad del ventilador
3. THE Termostato SHALL implementar el método abstracto ActualizarEstado() con lógica específica de climatización
4. THE Sistema_Domotica SHALL crear una clase SensorCalidadAire que herede de DispositivoBase
5. THE SensorCalidadAire SHALL encapsular propiedades privadas para nivel de CO2, nivel de partículas PM2.5 y estado de calidad
6. THE SensorCalidadAire SHALL implementar el método abstracto ActualizarEstado() con lógica específica de monitoreo de aire
7. THE Sistema_Domotica SHALL almacenar todos los modelos de clima en la carpeta Models

### Requisito 2: Controlador de Clima

**User Story:** Como desarrollador, quiero crear un controlador de clima con patrón Singleton, para gestionar la lógica de negocio de dispositivos de climatización de manera consistente con la arquitectura existente.

#### Acceptance Criteria

1. THE Sistema_Domotica SHALL crear una clase ClimaController que implemente el patrón Singleton
2. THE ClimaController SHALL encapsular listas privadas de termostatos y sensores de calidad de aire
3. THE ClimaController SHALL proporcionar métodos públicos para operaciones CRUD de termostatos
4. THE ClimaController SHALL proporcionar métodos públicos para operaciones CRUD de sensores de calidad de aire
5. WHEN ClimaController se inicializa, THE ClimaController SHALL cargar dispositivos de clima por defecto
6. THE ClimaController SHALL proporcionar métodos para cambiar temperatura objetivo, modo de operación y velocidad de ventilador
7. THE Sistema_Domotica SHALL almacenar el controlador en la carpeta Controllers

### Requisito 3: Vista de Clima con CRUD

**User Story:** Como usuario, quiero una interfaz para gestionar dispositivos de clima, para controlar la temperatura y calidad del aire de mi hogar.

#### Acceptance Criteria

1. THE Vista_Clima SHALL mostrar todos los termostatos con su estado actual
2. THE Vista_Clima SHALL mostrar todos los sensores de calidad de aire con sus lecturas
3. THE Vista_Clima SHALL proporcionar controles para agregar nuevos dispositivos de clima
4. THE Vista_Clima SHALL proporcionar controles para editar dispositivos de clima existentes
5. THE Vista_Clima SHALL proporcionar controles para eliminar dispositivos de clima
6. WHEN un usuario modifica un dispositivo de clima, THE Vista_Clima SHALL invocar métodos del ClimaController
7. THE Vista_Clima SHALL actualizar la interfaz automáticamente después de cada operación CRUD

### Requisito 4: Modelos de Dispositivos de Seguridad

**User Story:** Como desarrollador, quiero crear modelos de dispositivos de seguridad que hereden de DispositivoBase, para aplicar los principios de herencia y polimorfismo en el módulo de seguridad.

#### Acceptance Criteria

1. THE Sistema_Domotica SHALL crear una clase Camara que herede de DispositivoBase
2. THE Camara SHALL encapsular propiedades privadas para resolución, estado de grabación, detección de movimiento y ubicación
3. THE Camara SHALL implementar el método abstracto ActualizarEstado() con lógica específica de vigilancia
4. THE Sistema_Domotica SHALL crear una clase SensorMovimiento que herede de DispositivoBase
5. THE SensorMovimiento SHALL encapsular propiedades privadas para sensibilidad, última detección y zona de cobertura
6. THE SensorMovimiento SHALL implementar el método abstracto ActualizarEstado() con lógica específica de detección
7. THE Sistema_Domotica SHALL crear una clase Alarma que herede de DispositivoBase
8. THE Alarma SHALL encapsular propiedades privadas para estado de armado, tipo de alarma y nivel de volumen
9. THE Alarma SHALL implementar el método abstracto ActualizarEstado() con lógica específica de alertas
10. THE Sistema_Domotica SHALL crear una clase ControlAcceso que herede de DispositivoBase
11. THE ControlAcceso SHALL encapsular propiedades privadas para estado de bloqueo, método de autenticación y registro de accesos
12. THE ControlAcceso SHALL implementar el método abstracto ActualizarEstado() con lógica específica de control de acceso
13. THE Sistema_Domotica SHALL almacenar todos los modelos de seguridad en la carpeta Models

### Requisito 5: Controlador de Seguridad

**User Story:** Como desarrollador, quiero crear un controlador de seguridad con patrón Singleton, para gestionar la lógica de negocio de dispositivos de seguridad de manera consistente con la arquitectura existente.

#### Acceptance Criteria

1. THE Sistema_Domotica SHALL crear una clase SeguridadController que implemente el patrón Singleton
2. THE SeguridadController SHALL encapsular listas privadas de cámaras, sensores de movimiento, alarmas y controles de acceso
3. THE SeguridadController SHALL proporcionar métodos públicos para operaciones CRUD de cada tipo de dispositivo de seguridad
4. WHEN SeguridadController se inicializa, THE SeguridadController SHALL cargar dispositivos de seguridad por defecto
5. THE SeguridadController SHALL proporcionar métodos para armar/desarmar alarmas
6. THE SeguridadController SHALL proporcionar métodos para bloquear/desbloquear controles de acceso
7. THE SeguridadController SHALL proporcionar métodos para iniciar/detener grabación de cámaras
8. THE Sistema_Domotica SHALL almacenar el controlador en la carpeta Controllers

### Requisito 6: Vista de Seguridad con CRUD

**User Story:** Como usuario, quiero una interfaz para gestionar dispositivos de seguridad, para proteger mi hogar y controlar el acceso.

#### Acceptance Criteria

1. THE Vista_Seguridad SHALL mostrar todas las cámaras con su estado de grabación
2. THE Vista_Seguridad SHALL mostrar todos los sensores de movimiento con su estado de detección
3. THE Vista_Seguridad SHALL mostrar todas las alarmas con su estado de armado
4. THE Vista_Seguridad SHALL mostrar todos los controles de acceso con su estado de bloqueo
5. THE Vista_Seguridad SHALL proporcionar controles para agregar nuevos dispositivos de seguridad
6. THE Vista_Seguridad SHALL proporcionar controles para editar dispositivos de seguridad existentes
7. THE Vista_Seguridad SHALL proporcionar controles para eliminar dispositivos de seguridad
8. WHEN un usuario modifica un dispositivo de seguridad, THE Vista_Seguridad SHALL invocar métodos del SeguridadController
9. THE Vista_Seguridad SHALL actualizar la interfaz automáticamente después de cada operación CRUD

### Requisito 7: Modelos de Dispositivos Multimedia

**User Story:** Como desarrollador, quiero crear modelos de dispositivos multimedia que hereden de DispositivoBase, para aplicar los principios de herencia y polimorfismo en el módulo multimedia.

#### Acceptance Criteria

1. THE Sistema_Domotica SHALL crear una clase SistemaMusica que herede de DispositivoBase
2. THE SistemaMusica SHALL encapsular propiedades privadas para volumen, canción actual, lista de reproducción y modo de reproducción
3. THE SistemaMusica SHALL implementar el método abstracto ActualizarEstado() con lógica específica de reproducción de audio
4. THE Sistema_Domotica SHALL crear una clase Television que herede de DispositivoBase
5. THE Television SHALL encapsular propiedades privadas para canal actual, volumen, fuente de entrada y modo de imagen
6. THE Television SHALL implementar el método abstracto ActualizarEstado() con lógica específica de reproducción de video
7. THE Sistema_Domotica SHALL almacenar todos los modelos multimedia en la carpeta Models

### Requisito 8: Controlador Multimedia

**User Story:** Como desarrollador, quiero crear un controlador multimedia con patrón Singleton, para gestionar la lógica de negocio de dispositivos multimedia de manera consistente con la arquitectura existente.

#### Acceptance Criteria

1. THE Sistema_Domotica SHALL crear una clase MultimediaController que implemente el patrón Singleton
2. THE MultimediaController SHALL encapsular listas privadas de sistemas de música y televisiones
3. THE MultimediaController SHALL proporcionar métodos públicos para operaciones CRUD de sistemas de música
4. THE MultimediaController SHALL proporcionar métodos públicos para operaciones CRUD de televisiones
5. WHEN MultimediaController se inicializa, THE MultimediaController SHALL cargar dispositivos multimedia por defecto
6. THE MultimediaController SHALL proporcionar métodos para cambiar volumen, canción, canal y fuente de entrada
7. THE MultimediaController SHALL proporcionar métodos para reproducir, pausar y detener contenido multimedia
8. THE Sistema_Domotica SHALL almacenar el controlador en la carpeta Controllers

### Requisito 9: Vista Multimedia con CRUD

**User Story:** Como usuario, quiero una interfaz para gestionar dispositivos multimedia, para controlar el entretenimiento en mi hogar.

#### Acceptance Criteria

1. THE Vista_Multimedia SHALL mostrar todos los sistemas de música con su estado de reproducción
2. THE Vista_Multimedia SHALL mostrar todas las televisiones con su canal y fuente actual
3. THE Vista_Multimedia SHALL proporcionar controles para agregar nuevos dispositivos multimedia
4. THE Vista_Multimedia SHALL proporcionar controles para editar dispositivos multimedia existentes
5. THE Vista_Multimedia SHALL proporcionar controles para eliminar dispositivos multimedia
6. WHEN un usuario modifica un dispositivo multimedia, THE Vista_Multimedia SHALL invocar métodos del MultimediaController
7. THE Vista_Multimedia SHALL actualizar la interfaz automáticamente después de cada operación CRUD
8. THE Vista_Multimedia SHALL proporcionar controles de reproducción (play, pause, stop) para cada dispositivo

### Requisito 10: Aplicación Consistente de Principios POO

**User Story:** Como estudiante de POO, quiero que el sistema demuestre claramente los 4 principios de POO, para cumplir con los requisitos académicos del proyecto.

#### Acceptance Criteria

1. THE Sistema_Domotica SHALL aplicar Encapsulación mediante campos privados y propiedades públicas en todos los modelos
2. THE Sistema_Domotica SHALL aplicar Abstracción mediante la clase abstracta DispositivoBase y el método abstracto ActualizarEstado()
3. THE Sistema_Domotica SHALL aplicar Herencia mediante clases que extiendan DispositivoBase
4. THE Sistema_Domotica SHALL aplicar Polimorfismo mediante implementaciones específicas del método ActualizarEstado() en cada clase derivada
5. THE Sistema_Domotica SHALL mantener consistencia arquitectónica con el código existente de Iluminación e Inicio
6. THE Sistema_Domotica SHALL implementar el patrón Singleton en todos los controladores
7. THE Sistema_Domotica SHALL separar claramente la lógica de presentación (Views) de la lógica de negocio (Controllers) y los datos (Models)
