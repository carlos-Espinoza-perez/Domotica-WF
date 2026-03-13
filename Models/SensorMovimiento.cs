using System;

namespace Domotica.Models
{
    /// <summary>
    /// Representa un sensor de movimiento del hogar inteligente.
    /// Aplica HERENCIA: extiende DispositivoBase.
    /// Aplica POLIMORFISMO: redefine ActualizarEstado().
    /// </summary>
    public class SensorMovimiento : DispositivoBase
    {
        // ENCAPSULACIÓN: campos privados con propiedades públicas
        private int _sensibilidad;
        private DateTime _ultimaDeteccion;
        private string _zonaCobertura;

        public int Sensibilidad
        {
            get { return _sensibilidad; }
            set { _sensibilidad = value; }
        }

        public DateTime UltimaDeteccion
        {
            get { return _ultimaDeteccion; }
            set { _ultimaDeteccion = value; }
        }

        public string ZonaCobertura
        {
            get { return _zonaCobertura; }
            set { _zonaCobertura = value; }
        }

        public SensorMovimiento(int id, string nombre, bool encendido = true,
                                int sensibilidad = 5, DateTime? ultimaDeteccion = null,
                                string zonaCobertura = "Sala")
            : base(id, nombre, encendido)
        {
            _sensibilidad = sensibilidad;
            _ultimaDeteccion = ultimaDeteccion ?? DateTime.MinValue;
            _zonaCobertura = zonaCobertura;
        }

        /// <summary>
        /// POLIMORFISMO: implementación específica de SensorMovimiento.
        /// Actualiza el estado de detección del sensor.
        /// </summary>
        public override void ActualizarEstado()
        {
            // Lógica de actualización de estado de un sensor de movimiento.
            // En un sistema real aquí se procesarían señales del sensor PIR.
            if (!EstaEncendido)
            {
                return;
            }

            // Si el sensor está encendido, simular la lógica de detección
            // En un sistema real, aquí se analizarían las señales infrarrojas
            // y se actualizaría la última detección cuando se detecte movimiento
            // La sensibilidad determinaría el umbral de activación
        }

        public override string ToString()
        {
            string estado = EstaEncendido ? "ACTIVO" : "INACTIVO";
            string ultimaDeteccionStr = _ultimaDeteccion == DateTime.MinValue 
                ? "Sin detecciones" 
                : _ultimaDeteccion.ToString("dd/MM/yyyy HH:mm:ss");
            
            return $"{Nombre} [{estado}] - {_zonaCobertura} - Sensibilidad: {_sensibilidad}/10 - Última detección: {ultimaDeteccionStr}";
        }
    }
}
