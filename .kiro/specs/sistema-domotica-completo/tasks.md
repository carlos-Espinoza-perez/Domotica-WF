# Plan de Implementación: Sistema Domótica Completo

## Descripción General

Este plan implementa los módulos de Clima, Seguridad y Multimedia para el sistema de domótica en C# Windows Forms. Se aplicarán consistentemente los 4 principios de POO (Encapsulación, Abstracción, Herencia, Polimorfismo) siguiendo la arquitectura existente basada en DispositivoBase y el patrón Singleton para controladores.

**Alcance ajustado:**
- **Clima**: Solo modelos y controlador
- **Seguridad**: Solo modelos y controlador
- **Multimedia**: Implementación completa (modelos, controlador y vistas con CRUD)

## Tareas

- [x] 1. Implementar modelos de dispositivos de Clima
  - [x] 1.1 Crear clase Termostato que herede de DispositivoBase
    - Implementar campos privados para temperatura objetivo, temperatura actual, modo de operación y velocidad del ventilador
    - Implementar propiedades públicas con encapsulación
    - Implementar constructor que llame al constructor base
    - Implementar método abstracto ActualizarEstado() con lógica de climatización
    - Implementar método ToString() para representación textual
    - _Requisitos: 1.1, 1.2, 1.3, 10.1, 10.2, 10.3, 10.4_
  
  - [x] 1.2 Crear clase SensorCalidadAire que herede de DispositivoBase
    - Implementar campos privados para nivel de CO2, nivel de partículas PM2.5 y estado de calidad
    - Implementar propiedades públicas con encapsulación
    - Implementar constructor que llame al constructor base
    - Implementar método abstracto ActualizarEstado() con lógica de monitoreo de aire
    - Implementar método ToString() para representación textual
    - _Requisitos: 1.4, 1.5, 1.6, 10.1, 10.2, 10.3, 10.4_

- [x] 2. Implementar controlador de Clima con patrón Singleton
  - [x] 2.1 Crear clase ClimaController con patrón Singleton
    - Implementar propiedad estática Instancia con patrón Singleton
    - Implementar constructor privado
    - Implementar listas privadas para termostatos y sensores de calidad de aire
    - Implementar contador de IDs privado
    - _Requisitos: 2.1, 2.2, 10.1, 10.6_
  
  - [x] 2.2 Implementar métodos CRUD para termostatos en ClimaController
    - Implementar método ObtenerTermostatos() que retorne copia de la lista
    - Implementar método AgregarTermostato(Termostato) con asignación automática de ID
    - Implementar método EditarTermostato(Termostato) que actualice propiedades
    - Implementar método EliminarTermostato(int id)
    - _Requisitos: 2.3, 10.7_
  
  - [x] 2.3 Implementar métodos CRUD para sensores de calidad de aire en ClimaController
    - Implementar método ObtenerSensoresCalidadAire() que retorne copia de la lista
    - Implementar método AgregarSensorCalidadAire(SensorCalidadAire) con asignación automática de ID
    - Implementar método EditarSensorCalidadAire(SensorCalidadAire) que actualice propiedades
    - Implementar método EliminarSensorCalidadAire(int id)
    - _Requisitos: 2.4, 10.7_
  
  - [x] 2.4 Implementar métodos de control específicos y carga inicial en ClimaController
    - Implementar método privado CargarDispositivosPorDefecto() con 2-3 dispositivos de cada tipo
    - Implementar método CambiarTemperaturaObjetivo(int id, double temperatura)
    - Implementar método CambiarModoOperacion(int id, string modo)
    - Implementar método CambiarVelocidadVentilador(int id, int velocidad)
    - Llamar a CargarDispositivosPorDefecto() en el constructor
    - _Requisitos: 2.5, 2.6, 10.7_

- [x] 3. Implementar modelos de dispositivos de Seguridad
  - [x] 3.1 Crear clase Camara que herede de DispositivoBase
    - Implementar campos privados para resolución, estado de grabación, detección de movimiento y ubicación
    - Implementar propiedades públicas con encapsulación
    - Implementar constructor que llame al constructor base
    - Implementar método abstracto ActualizarEstado() con lógica de vigilancia
    - Implementar método ToString() para representación textual
    - _Requisitos: 4.1, 4.2, 4.3, 10.1, 10.2, 10.3, 10.4_
  
  - [x] 3.2 Crear clase SensorMovimiento que herede de DispositivoBase
    - Implementar campos privados para sensibilidad, última detección y zona de cobertura
    - Implementar propiedades públicas con encapsulación
    - Implementar constructor que llame al constructor base
    - Implementar método abstracto ActualizarEstado() con lógica de detección
    - Implementar método ToString() para representación textual
    - _Requisitos: 4.4, 4.5, 4.6, 10.1, 10.2, 10.3, 10.4_
  
  - [x] 3.3 Crear clase Alarma que herede de DispositivoBase
    - Implementar campos privados para estado de armado, tipo de alarma y nivel de volumen
    - Implementar propiedades públicas con encapsulación
    - Implementar constructor que llame al constructor base
    - Implementar método abstracto ActualizarEstado() con lógica de alertas
    - Implementar método ToString() para representación textual
    - _Requisitos: 4.7, 4.8, 4.9, 10.1, 10.2, 10.3, 10.4_
  
  - [x] 3.4 Crear clase ControlAcceso que herede de DispositivoBase
    - Implementar campos privados para estado de bloqueo, método de autenticación y registro de accesos
    - Implementar propiedades públicas con encapsulación
    - Implementar constructor que llame al constructor base
    - Implementar método abstracto ActualizarEstado() con lógica de control de acceso
    - Implementar método ToString() para representación textual
    - _Requisitos: 4.10, 4.11, 4.12, 10.1, 10.2, 10.3, 10.4_

- [ ] 4. Implementar controlador de Seguridad con patrón Singleton
  - [x] 4.1 Crear clase SeguridadController con patrón Singleton
    - Implementar propiedad estática Instancia con patrón Singleton
    - Implementar constructor privado
    - Implementar listas privadas para cámaras, sensores de movimiento, alarmas y controles de acceso
    - Implementar contador de IDs privado
    - _Requisitos: 5.1, 5.2, 10.1, 10.6_
  
  - [x] 4.2 Implementar métodos CRUD para cámaras en SeguridadController
    - Implementar método ObtenerCamaras() que retorne copia de la lista
    - Implementar método AgregarCamara(Camara) con asignación automática de ID
    - Implementar método EditarCamara(Camara) que actualice propiedades
    - Implementar método EliminarCamara(int id)
    - _Requisitos: 5.3, 10.7_
  
  - [x] 4.3 Implementar métodos CRUD para sensores de movimiento en SeguridadController
    - Implementar método ObtenerSensoresMovimiento() que retorne copia de la lista
    - Implementar método AgregarSensorMovimiento(SensorMovimiento) con asignación automática de ID
    - Implementar método EditarSensorMovimiento(SensorMovimiento) que actualice propiedades
    - Implementar método EliminarSensorMovimiento(int id)
    - _Requisitos: 5.3, 10.7_
  
  - [x] 4.4 Implementar métodos CRUD para alarmas en SeguridadController
    - Implementar método ObtenerAlarmas() que retorne copia de la lista
    - Implementar método AgregarAlarma(Alarma) con asignación automática de ID
    - Implementar método EditarAlarma(Alarma) que actualice propiedades
    - Implementar método EliminarAlarma(int id)
    - _Requisitos: 5.3, 10.7_
  
  - [x] 4.5 Implementar métodos CRUD para controles de acceso en SeguridadController
    - Implementar método ObtenerControlesAcceso() que retorne copia de la lista
    - Implementar método AgregarControlAcceso(ControlAcceso) con asignación automática de ID
    - Implementar método EditarControlAcceso(ControlAcceso) que actualice propiedades
    - Implementar método EliminarControlAcceso(int id)
    - _Requisitos: 5.3, 10.7_
  
  - [x] 4.6 Implementar métodos de control específicos y carga inicial en SeguridadController
    - Implementar método privado CargarDispositivosPorDefecto() con 1-2 dispositivos de cada tipo
    - Implementar método ArmarAlarma(int id) y DesarmarAlarma(int id)
    - Implementar método BloquearAcceso(int id) y DesbloquearAcceso(int id)
    - Implementar método IniciarGrabacion(int id) y DetenerGrabacion(int id)
    - Llamar a CargarDispositivosPorDefecto() en el constructor
    - _Requisitos: 5.4, 5.5, 5.6, 5.7, 10.7_

- [ ] 5. Checkpoint - Verificar modelos y controladores de Clima y Seguridad
  - Asegurar que todos los modelos compilan sin errores
  - Asegurar que los controladores implementan correctamente el patrón Singleton
  - Verificar que se aplican los 4 principios de POO
  - Preguntar al usuario si hay dudas o ajustes necesarios

- [x] 6. Implementar modelos de dispositivos Multimedia
  - [x] 6.1 Crear clase SistemaMusica que herede de DispositivoBase
    - Implementar campos privados para volumen, canción actual, lista de reproducción y modo de reproducción
    - Implementar propiedades públicas con encapsulación
    - Implementar constructor que llame al constructor base
    - Implementar método abstracto ActualizarEstado() con lógica de reproducción de audio
    - Implementar método ToString() para representación textual
    - _Requisitos: 7.1, 7.2, 7.3, 10.1, 10.2, 10.3, 10.4_
  
  - [x] 6.2 Crear clase Television que herede de DispositivoBase
    - Implementar campos privados para canal actual, volumen, fuente de entrada y modo de imagen
    - Implementar propiedades públicas con encapsulación
    - Implementar constructor que llame al constructor base
    - Implementar método abstracto ActualizarEstado() con lógica de reproducción de video
    - Implementar método ToString() para representación textual
    - _Requisitos: 7.4, 7.5, 7.6, 10.1, 10.2, 10.3, 10.4_

- [x] 7. Implementar controlador Multimedia con patrón Singleton
  - [x] 7.1 Crear clase MultimediaController con patrón Singleton
    - Implementar propiedad estática Instancia con patrón Singleton
    - Implementar constructor privado
    - Implementar listas privadas para sistemas de música y televisiones
    - Implementar contador de IDs privado
    - _Requisitos: 8.1, 8.2, 10.1, 10.6_
  
  - [x] 7.2 Implementar métodos CRUD para sistemas de música en MultimediaController
    - Implementar método ObtenerSistemasMusica() que retorne copia de la lista
    - Implementar método AgregarSistemaMusica(SistemaMusica) con asignación automática de ID
    - Implementar método EditarSistemaMusica(SistemaMusica) que actualice propiedades
    - Implementar método EliminarSistemaMusica(int id)
    - _Requisitos: 8.3, 10.7_
  
  - [x] 7.3 Implementar métodos CRUD para televisiones en MultimediaController
    - Implementar método ObtenerTelevisiones() que retorne copia de la lista
    - Implementar método AgregarTelevision(Television) con asignación automática de ID
    - Implementar método EditarTelevision(Television) que actualice propiedades
    - Implementar método EliminarTelevision(int id)
    - _Requisitos: 8.4, 10.7_
  
  - [x] 7.4 Implementar métodos de control específicos y carga inicial en MultimediaController
    - Implementar método privado CargarDispositivosPorDefecto() con 2 dispositivos de cada tipo
    - Implementar método CambiarVolumen(int id, int volumen)
    - Implementar método CambiarCancion(int id, string cancion)
    - Implementar método CambiarCanal(int id, int canal)
    - Implementar método CambiarFuenteEntrada(int id, string fuente)
    - Implementar método Reproducir(int id), Pausar(int id) y Detener(int id)
    - Llamar a CargarDispositivosPorDefecto() en el constructor
    - _Requisitos: 8.5, 8.6, 8.7, 10.7_

- [x] 8. Implementar vista Multimedia con interfaz de usuario
  - [x] 8.1 Diseñar interfaz de Multimedia.cs en el diseñador de Windows Forms
    - Agregar Panel principal para contener la lista de dispositivos
    - Agregar FlowLayoutPanel o DataGridView para mostrar dispositivos multimedia
    - Agregar botones para Agregar, Editar y Eliminar dispositivos
    - Agregar controles de reproducción (Play, Pause, Stop) con iconos de FontAwesome.Sharp
    - Agregar controles para cambiar volumen, canal y fuente
    - Configurar layout y estilos consistentes con FormIluminacion existente
    - _Requisitos: 9.1, 9.2, 9.8_
  
  - [x] 8.2 Implementar lógica de carga y visualización en Multimedia.cs
    - Implementar método CargarDispositivos() que obtenga datos de MultimediaController
    - Implementar método MostrarSistemasMusica() que muestre sistemas de música con su estado
    - Implementar método MostrarTelevisiones() que muestre televisiones con canal y fuente
    - Llamar a CargarDispositivos() en el evento Load del formulario
    - _Requisitos: 9.1, 9.2, 10.7_
  
  - [x] 8.3 Implementar funcionalidad CRUD en Multimedia.cs
    - Implementar evento Click del botón Agregar que abra formulario de creación
    - Implementar evento Click del botón Editar que abra formulario de edición
    - Implementar evento Click del botón Eliminar que confirme y elimine dispositivo
    - Implementar método ActualizarVista() que refresque la interfaz después de cada operación
    - Invocar métodos del MultimediaController para cada operación CRUD
    - _Requisitos: 9.3, 9.4, 9.5, 9.6, 9.7, 10.7_
  
  - [x] 8.4 Implementar controles de reproducción en Multimedia.cs
    - Implementar evento Click del botón Play que invoque MultimediaController.Reproducir()
    - Implementar evento Click del botón Pause que invoque MultimediaController.Pausar()
    - Implementar evento Click del botón Stop que invoque MultimediaController.Detener()
    - Implementar controles para cambiar volumen que invoquen MultimediaController.CambiarVolumen()
    - Implementar controles para cambiar canal/canción que invoquen métodos correspondientes
    - Actualizar interfaz después de cada acción de control
    - _Requisitos: 9.8, 9.6, 10.7_

- [ ] 9. Crear formularios auxiliares para CRUD de Multimedia
  - [~] 9.1 Crear FormAgregarSistemaMusica.cs para agregar/editar sistemas de música
    - Diseñar interfaz con campos para nombre, volumen, canción actual, lista de reproducción y modo
    - Implementar validación de campos
    - Implementar botones Guardar y Cancelar
    - Retornar objeto SistemaMusica al formulario principal
    - _Requisitos: 9.3, 9.4_
  
  - [~] 9.2 Crear FormAgregarTelevision.cs para agregar/editar televisiones
    - Diseñar interfaz con campos para nombre, canal, volumen, fuente de entrada y modo de imagen
    - Implementar validación de campos
    - Implementar botones Guardar y Cancelar
    - Retornar objeto Television al formulario principal
    - _Requisitos: 9.3, 9.4_

- [ ] 10. Checkpoint final - Verificar implementación completa de Multimedia
  - Asegurar que la vista Multimedia muestra correctamente todos los dispositivos
  - Verificar que todas las operaciones CRUD funcionan correctamente
  - Verificar que los controles de reproducción funcionan
  - Asegurar que no hay errores de compilación
  - Preguntar al usuario si hay ajustes necesarios

- [x] 11. Integración y verificación final del sistema completo
  - [x] 11.1 Verificar que todos los módulos están correctamente integrados
    - Verificar que ClimaController, SeguridadController y MultimediaController son accesibles
    - Verificar que todos los modelos están en la carpeta Models
    - Verificar que todos los controladores están en la carpeta Controllers
    - Verificar que todas las vistas están en la carpeta Views
    - _Requisitos: 1.7, 2.7, 4.13, 5.8, 7.7, 8.8, 10.5_
  
  - [x] 11.2 Verificar aplicación de principios POO en todo el sistema
    - Verificar Encapsulación: todos los campos son privados con propiedades públicas
    - Verificar Abstracción: todos los dispositivos heredan de DispositivoBase
    - Verificar Herencia: todas las clases de dispositivos extienden DispositivoBase
    - Verificar Polimorfismo: cada clase implementa ActualizarEstado() de forma específica
    - Verificar patrón Singleton en todos los controladores
    - Verificar separación de responsabilidades (Models, Views, Controllers)
    - _Requisitos: 10.1, 10.2, 10.3, 10.4, 10.5, 10.6, 10.7_

## Notas

- Las tareas están organizadas por módulo (Clima, Seguridad, Multimedia) para facilitar el desarrollo incremental
- Cada tarea referencia los requisitos específicos que implementa para trazabilidad
- Los checkpoints permiten validación incremental y oportunidad para ajustes
- El alcance se ajusta a las indicaciones del usuario: Clima y Seguridad solo modelos y controladores, Multimedia implementación completa
- Todas las implementaciones deben seguir el patrón establecido por IluminacionController y Luz
- Se debe mantener consistencia en nombres, estilos y estructura con el código existente
