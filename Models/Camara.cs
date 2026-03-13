using System;

namespace Domotica.Models
{
    /// <summary>
    /// Representa una cámara de seguridad del hogar inteligente.
    /// Aplica HERENCIA: extiende DispositivoBase.
    /// Aplica POLIMORFISMO: redefine ActualizarEstado().
    /// </summary>
    public class Camara : DispositivoBase
    {
        // ENCAPSULACIÓN: campos privados con propiedades públicas
        private string _resolucion;
        private bool _estaGrabando;
        private bool _deteccionMovimiento;
        private string _ubicacion;

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

        public bool DeteccionMovimiento
        {
            get { return _deteccionMovimiento; }
            set { _deteccionMovimiento = value; }
        }

        public string Ubicacion
        {
            get { return _ubicacion; }
            set { _ubicacion = value; }
        }

        public Camara(int id, string nombre, bool encendido = true,
                      string resolucion = "1080p", bool estaGrabando = false,
                      bool deteccionMovimiento = true, string ubicacion = "Entrada")
            : base(id, nombre, encendido)
        {
            _resolucion = resolucion;
            _estaGrabando = estaGrabando;
            _deteccionMovimiento = deteccionMovimiento;
            _ubicacion = ubicacion;
        }

        /// <summary>
        /// POLIMORFISMO: implementación específica de Camara.
        /// Actualiza el estado de vigilancia de la cámara.
        /// </summary>
        public override void ActualizarEstado()
        {
            // Lógica de actualización de estado de una cámara de seguridad.
            // En un sistema real aquí se procesaría el video y se detectaría movimiento.
            if (!EstaEncendido)
            {
                _estaGrabando = false;
                _deteccionMovimiento = false;
                return;
            }

            // Si la cámara está encendida y tiene detección de movimiento activa,
            // simular la lógica de vigilancia
            if (_deteccionMovimiento)
            {
                // En un sistema real, aquí se analizaría el video en tiempo real
                // y se activaría la grabación si se detecta movimiento
                // Por ahora, mantenemos el estado actual de grabación
            }
        }

        public override string ToString()
        {
            string estado = EstaEncendido ? "ENCENDIDA" : "APAGADA";
            string grabacion = _estaGrabando ? "Grabando" : "En espera";
            string deteccion = _deteccionMovimiento ? "Activa" : "Inactiva";
            
            return $"{Nombre} [{estado}] - {_ubicacion} - {_resolucion} - {grabacion} - Detección: {deteccion}";
        }
    }
}
