using System.Collections.Generic;
using System.Linq;
using Domotica.Models;

namespace Domotica.Controllers
{
    /// <summary>
    /// Controlador de Clima — gestiona el CRUD de termostatos y sensores de calidad de aire.
    /// ENCAPSULACIÓN: las listas internas solo son accesibles mediante métodos públicos.
    /// </summary>
    public class ClimaController
    {
        private static ClimaController _instancia;
        private List<Termostato> _termostatos;
        private List<SensorCalidadAire> _sensoresCalidadAire;
        private int _contadorId;

        // Singleton: instancia compartida entre formularios
        public static ClimaController Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new ClimaController();
                return _instancia;
            }
        }

        private ClimaController()
        {
            _contadorId = 1;
            _termostatos = new List<Termostato>();
            _sensoresCalidadAire = new List<SensorCalidadAire>();
            CargarDispositivosPorDefecto();
        }

        /// <summary>
        /// Carga los dispositivos de clima predeterminados del hogar.
        /// </summary>
        private void CargarDispositivosPorDefecto()
        {
            // Cargar termostatos por defecto
            _termostatos.Add(new Termostato(_contadorId++, "Termostato Sala", encendido: true, 
                temperaturaObjetivo: 22, temperaturaActual: 20, 
                modo: ModoOperacion.Auto, velocidad: VelocidadVentilador.Media));
            
            _termostatos.Add(new Termostato(_contadorId++, "Termostato Dormitorio", encendido: true, 
                temperaturaObjetivo: 20, temperaturaActual: 19, 
                modo: ModoOperacion.Calefaccion, velocidad: VelocidadVentilador.Baja));
            
            _termostatos.Add(new Termostato(_contadorId++, "Termostato Oficina", encendido: false, 
                temperaturaObjetivo: 24, temperaturaActual: 25, 
                modo: ModoOperacion.Refrigeracion, velocidad: VelocidadVentilador.Apagado));

            // Cargar sensores de calidad de aire por defecto
            _sensoresCalidadAire.Add(new SensorCalidadAire(_contadorId++, "Sensor Sala", encendido: true, 
                nivelCO2: 450, nivelPM25: 8, estadoCalidad: EstadoCalidad.Excelente));
            
            _sensoresCalidadAire.Add(new SensorCalidadAire(_contadorId++, "Sensor Cocina", encendido: true, 
                nivelCO2: 800, nivelPM25: 25, estadoCalidad: EstadoCalidad.Buena));
        }

        // ==========================================
        // CRUD - Termostatos
        // ==========================================

        public List<Termostato> ObtenerTermostatos()
        {
            return new List<Termostato>(_termostatos);
        }

        public void AgregarTermostato(Termostato termostato)
        {
            termostato.Id = _contadorId++;
            _termostatos.Add(termostato);
        }

        public void EditarTermostato(Termostato termostatoActualizado)
        {
            Termostato existente = _termostatos.FirstOrDefault(t => t.Id == termostatoActualizado.Id);
            if (existente != null)
            {
                existente.Nombre = termostatoActualizado.Nombre;
                existente.EstaEncendido = termostatoActualizado.EstaEncendido;
                existente.TemperaturaObjetivo = termostatoActualizado.TemperaturaObjetivo;
                existente.TemperaturaActual = termostatoActualizado.TemperaturaActual;
                existente.ModoOperacion = termostatoActualizado.ModoOperacion;
                existente.VelocidadVentilador = termostatoActualizado.VelocidadVentilador;
                existente.ActualizarEstado();
            }
        }

        public void EliminarTermostato(int id)
        {
            Termostato termostato = _termostatos.FirstOrDefault(t => t.Id == id);
            if (termostato != null)
                _termostatos.Remove(termostato);
        }

        // ==========================================
        // CRUD - Sensores de Calidad de Aire
        // ==========================================

        public List<SensorCalidadAire> ObtenerSensoresCalidadAire()
        {
            return new List<SensorCalidadAire>(_sensoresCalidadAire);
        }

        public void AgregarSensorCalidadAire(SensorCalidadAire sensor)
        {
            sensor.Id = _contadorId++;
            _sensoresCalidadAire.Add(sensor);
        }

        public void EditarSensorCalidadAire(SensorCalidadAire sensorActualizado)
        {
            SensorCalidadAire existente = _sensoresCalidadAire.FirstOrDefault(s => s.Id == sensorActualizado.Id);
            if (existente != null)
            {
                existente.Nombre = sensorActualizado.Nombre;
                existente.EstaEncendido = sensorActualizado.EstaEncendido;
                existente.NivelCO2 = sensorActualizado.NivelCO2;
                existente.NivelPM25 = sensorActualizado.NivelPM25;
                existente.EstadoCalidad = sensorActualizado.EstadoCalidad;
                existente.ActualizarEstado();
            }
        }

        public void EliminarSensorCalidadAire(int id)
        {
            SensorCalidadAire sensor = _sensoresCalidadAire.FirstOrDefault(s => s.Id == id);
            if (sensor != null)
                _sensoresCalidadAire.Remove(sensor);
        }

        // ==========================================
        // Métodos de Control Específicos
        // ==========================================

        /// <summary>
        /// Cambia la temperatura objetivo de un termostato específico.
        /// </summary>
        /// <param name="id">ID del termostato</param>
        /// <param name="temperatura">Nueva temperatura objetivo (16-30°C)</param>
        public void CambiarTemperaturaObjetivo(int id, double temperatura)
        {
            Termostato termostato = _termostatos.FirstOrDefault(t => t.Id == id);
            if (termostato != null)
            {
                termostato.TemperaturaObjetivo = temperatura;
                termostato.ActualizarEstado();
            }
        }

        /// <summary>
        /// Cambia el modo de operación de un termostato específico.
        /// </summary>
        /// <param name="id">ID del termostato</param>
        /// <param name="modo">Modo de operación: "Calefaccion", "Refrigeracion", "Auto", "Ventilador"</param>
        public void CambiarModoOperacion(int id, string modo)
        {
            Termostato termostato = _termostatos.FirstOrDefault(t => t.Id == id);
            if (termostato != null)
            {
                ModoOperacion modoEnum;
                if (System.Enum.TryParse(modo, out modoEnum))
                {
                    termostato.ModoOperacion = modoEnum;
                    termostato.ActualizarEstado();
                }
            }
        }

        /// <summary>
        /// Cambia la velocidad del ventilador de un termostato específico.
        /// </summary>
        /// <param name="id">ID del termostato</param>
        /// <param name="velocidad">Velocidad: 0=Apagado, 1=Baja, 2=Media, 3=Alta</param>
        public void CambiarVelocidadVentilador(int id, int velocidad)
        {
            Termostato termostato = _termostatos.FirstOrDefault(t => t.Id == id);
            if (termostato != null)
            {
                VelocidadVentilador velocidadEnum;
                switch (velocidad)
                {
                    case 0:
                        velocidadEnum = VelocidadVentilador.Apagado;
                        break;
                    case 1:
                        velocidadEnum = VelocidadVentilador.Baja;
                        break;
                    case 2:
                        velocidadEnum = VelocidadVentilador.Media;
                        break;
                    case 3:
                        velocidadEnum = VelocidadVentilador.Alta;
                        break;
                    default:
                        return; // Velocidad inválida, no hacer nada
                }
                termostato.VelocidadVentilador = velocidadEnum;
                termostato.ActualizarEstado();
            }
        }
    }
}
