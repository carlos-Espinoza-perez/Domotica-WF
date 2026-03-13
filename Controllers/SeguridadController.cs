using System.Collections.Generic;
using System.Linq;
using Domotica.Models;

namespace Domotica.Controllers
{
    /// <summary>
    /// Controlador de Seguridad — gestiona el CRUD de dispositivos de seguridad.
    /// ENCAPSULACIÓN: las listas internas solo son accesibles mediante métodos públicos.
    /// </summary>
    public class SeguridadController
    {
        private static SeguridadController _instancia;
        private List<Camara> _camaras;
        private List<SensorMovimiento> _sensoresMovimiento;
        private List<Alarma> _alarmas;
        private List<ControlAcceso> _controlesAcceso;
        private int _contadorId;

        // Singleton: instancia compartida entre formularios
        public static SeguridadController Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new SeguridadController();
                return _instancia;
            }
        }

        private SeguridadController()
        {
            _contadorId = 1;
            _camaras = new List<Camara>();
            _sensoresMovimiento = new List<SensorMovimiento>();
            _alarmas = new List<Alarma>();
            _controlesAcceso = new List<ControlAcceso>();
            CargarDispositivosPorDefecto();
        }

        /// <summary>
        /// Carga los dispositivos de seguridad predeterminados del hogar.
        /// </summary>
        private void CargarDispositivosPorDefecto()
        {
            // Cargar cámaras por defecto
            _camaras.Add(new Camara(_contadorId++, "Cámara Entrada", encendido: true,
                resolucion: "1080p", estaGrabando: true, deteccionMovimiento: true, ubicacion: "Entrada Principal"));

            _camaras.Add(new Camara(_contadorId++, "Cámara Patio", encendido: true,
                resolucion: "720p", estaGrabando: false, deteccionMovimiento: true, ubicacion: "Patio Trasero"));

            _camaras.Add(new Camara(_contadorId++, "Cámara Garaje", encendido: false,
                resolucion: "1080p", estaGrabando: false, deteccionMovimiento: false, ubicacion: "Garaje"));

            // Cargar sensores de movimiento por defecto
            _sensoresMovimiento.Add(new SensorMovimiento(_contadorId++, "Sensor Sala", encendido: true,
                sensibilidad: 7, zonaCobertura: "Sala de Estar"));

            _sensoresMovimiento.Add(new SensorMovimiento(_contadorId++, "Sensor Pasillo", encendido: true,
                sensibilidad: 5, zonaCobertura: "Pasillo Principal"));

            // Cargar alarmas por defecto
            _alarmas.Add(new Alarma(_contadorId++, "Alarma Principal", encendido: true,
                estaArmada: false, tipoAlarma: TipoAlarma.Intrusion, nivelVolumen: 80));

            _alarmas.Add(new Alarma(_contadorId++, "Alarma Incendio", encendido: true,
                estaArmada: true, tipoAlarma: TipoAlarma.Incendio, nivelVolumen: 100));

            // Cargar controles de acceso por defecto
            _controlesAcceso.Add(new ControlAcceso(_contadorId++, "Puerta Principal", encendido: true,
                estaBloqueado: true, metodoAutenticacion: MetodoAutenticacion.Tarjeta));

            _controlesAcceso.Add(new ControlAcceso(_contadorId++, "Puerta Garaje", encendido: true,
                estaBloqueado: true, metodoAutenticacion: MetodoAutenticacion.PIN));
        }

        // ==========================================
        // CRUD - Cámaras
        // ==========================================

        public List<Camara> ObtenerCamaras()
        {
            return new List<Camara>(_camaras);
        }

        public void AgregarCamara(Camara camara)
        {
            camara.Id = _contadorId++;
            _camaras.Add(camara);
        }

        public void EditarCamara(Camara camaraActualizada)
        {
            Camara existente = _camaras.FirstOrDefault(c => c.Id == camaraActualizada.Id);
            if (existente != null)
            {
                existente.Nombre = camaraActualizada.Nombre;
                existente.EstaEncendido = camaraActualizada.EstaEncendido;
                existente.Resolucion = camaraActualizada.Resolucion;
                existente.EstaGrabando = camaraActualizada.EstaGrabando;
                existente.DeteccionMovimiento = camaraActualizada.DeteccionMovimiento;
                existente.Ubicacion = camaraActualizada.Ubicacion;
                existente.ActualizarEstado();
            }
        }

        public void EliminarCamara(int id)
        {
            Camara camara = _camaras.FirstOrDefault(c => c.Id == id);
            if (camara != null)
                _camaras.Remove(camara);
        }

        // ==========================================
        // CRUD - Sensores de Movimiento
        // ==========================================

        public List<SensorMovimiento> ObtenerSensoresMovimiento()
        {
            return new List<SensorMovimiento>(_sensoresMovimiento);
        }

        public void AgregarSensorMovimiento(SensorMovimiento sensor)
        {
            sensor.Id = _contadorId++;
            _sensoresMovimiento.Add(sensor);
        }

        public void EditarSensorMovimiento(SensorMovimiento sensorActualizado)
        {
            SensorMovimiento existente = _sensoresMovimiento.FirstOrDefault(s => s.Id == sensorActualizado.Id);
            if (existente != null)
            {
                existente.Nombre = sensorActualizado.Nombre;
                existente.EstaEncendido = sensorActualizado.EstaEncendido;
                existente.Sensibilidad = sensorActualizado.Sensibilidad;
                existente.UltimaDeteccion = sensorActualizado.UltimaDeteccion;
                existente.ZonaCobertura = sensorActualizado.ZonaCobertura;
                existente.ActualizarEstado();
            }
        }

        public void EliminarSensorMovimiento(int id)
        {
            SensorMovimiento sensor = _sensoresMovimiento.FirstOrDefault(s => s.Id == id);
            if (sensor != null)
                _sensoresMovimiento.Remove(sensor);
        }

        // ==========================================
        // CRUD - Alarmas
        // ==========================================

        public List<Alarma> ObtenerAlarmas()
        {
            return new List<Alarma>(_alarmas);
        }

        public void AgregarAlarma(Alarma alarma)
        {
            alarma.Id = _contadorId++;
            _alarmas.Add(alarma);
        }

        public void EditarAlarma(Alarma alarmaActualizada)
        {
            Alarma existente = _alarmas.FirstOrDefault(a => a.Id == alarmaActualizada.Id);
            if (existente != null)
            {
                existente.Nombre = alarmaActualizada.Nombre;
                existente.EstaEncendido = alarmaActualizada.EstaEncendido;
                existente.EstaArmada = alarmaActualizada.EstaArmada;
                existente.TipoAlarma = alarmaActualizada.TipoAlarma;
                existente.NivelVolumen = alarmaActualizada.NivelVolumen;
                existente.ActualizarEstado();
            }
        }

        public void EliminarAlarma(int id)
        {
            Alarma alarma = _alarmas.FirstOrDefault(a => a.Id == id);
            if (alarma != null)
                _alarmas.Remove(alarma);
        }

        // ==========================================
        // CRUD - Controles de Acceso
        // ==========================================

        public List<ControlAcceso> ObtenerControlesAcceso()
        {
            return new List<ControlAcceso>(_controlesAcceso);
        }

        public void AgregarControlAcceso(ControlAcceso controlAcceso)
        {
            controlAcceso.Id = _contadorId++;
            _controlesAcceso.Add(controlAcceso);
        }

        public void EditarControlAcceso(ControlAcceso controlActualizado)
        {
            ControlAcceso existente = _controlesAcceso.FirstOrDefault(c => c.Id == controlActualizado.Id);
            if (existente != null)
            {
                existente.Nombre = controlActualizado.Nombre;
                existente.EstaEncendido = controlActualizado.EstaEncendido;
                existente.EstaBloqueado = controlActualizado.EstaBloqueado;
                existente.MetodoAutenticacion = controlActualizado.MetodoAutenticacion;
                existente.RegistroAccesos = controlActualizado.RegistroAccesos;
                existente.ActualizarEstado();
            }
        }

        public void EliminarControlAcceso(int id)
        {
            ControlAcceso control = _controlesAcceso.FirstOrDefault(c => c.Id == id);
            if (control != null)
                _controlesAcceso.Remove(control);
        }

        // ==========================================
        // Métodos de Control Específicos
        // ==========================================

        /// <summary>
        /// Arma una alarma específica por su ID.
        /// </summary>
        public void ArmarAlarma(int id)
        {
            Alarma alarma = _alarmas.FirstOrDefault(a => a.Id == id);
            if (alarma != null)
            {
                alarma.EstaArmada = true;
                alarma.ActualizarEstado();
            }
        }

        /// <summary>
        /// Desarma una alarma específica por su ID.
        /// </summary>
        public void DesarmarAlarma(int id)
        {
            Alarma alarma = _alarmas.FirstOrDefault(a => a.Id == id);
            if (alarma != null)
            {
                alarma.EstaArmada = false;
                alarma.ActualizarEstado();
            }
        }

        /// <summary>
        /// Bloquea un control de acceso específico por su ID.
        /// </summary>
        public void BloquearAcceso(int id)
        {
            ControlAcceso control = _controlesAcceso.FirstOrDefault(c => c.Id == id);
            if (control != null)
            {
                control.EstaBloqueado = true;
                control.ActualizarEstado();
            }
        }

        /// <summary>
        /// Desbloquea un control de acceso específico por su ID.
        /// </summary>
        public void DesbloquearAcceso(int id)
        {
            ControlAcceso control = _controlesAcceso.FirstOrDefault(c => c.Id == id);
            if (control != null)
            {
                control.EstaBloqueado = false;
                control.ActualizarEstado();
            }
        }

        /// <summary>
        /// Inicia la grabación de una cámara específica por su ID.
        /// </summary>
        public void IniciarGrabacion(int id)
        {
            Camara camara = _camaras.FirstOrDefault(c => c.Id == id);
            if (camara != null)
            {
                camara.EstaGrabando = true;
                camara.ActualizarEstado();
            }
        }

        /// <summary>
        /// Detiene la grabación de una cámara específica por su ID.
        /// </summary>
        public void DetenerGrabacion(int id)
        {
            Camara camara = _camaras.FirstOrDefault(c => c.Id == id);
            if (camara != null)
            {
                camara.EstaGrabando = false;
                camara.ActualizarEstado();
            }
        }

        /// <summary>
        /// Conmuta el estado de bloqueo de un acceso.
        /// </summary>
        public void ConmutarAcceso(int id)
        {
            ControlAcceso control = _controlesAcceso.FirstOrDefault(c => c.Id == id);
            if (control != null)
            {
                control.EstaBloqueado = !control.EstaBloqueado;
                control.ActualizarEstado();
            }
        }
    }
}
