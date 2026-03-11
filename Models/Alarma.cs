using System;

namespace Domotica.Models
{
    /// <summary>
    /// Representa una alarma de seguridad del hogar inteligente.
    /// Aplica HERENCIA: extiende DispositivoBase.
    /// Aplica POLIMORFISMO: redefine ActualizarEstado().
    /// </summary>
    public class Alarma : DispositivoBase
    {
        // ENCAPSULACIÓN: campos privados con propiedades públicas
        private bool _estaArmada;
        private TipoAlarma _tipoAlarma;
        private int _nivelVolumen;

        public bool EstaArmada
        {
            get { return _estaArmada; }
            set { _estaArmada = value; }
        }

        public TipoAlarma TipoAlarma
        {
            get { return _tipoAlarma; }
            set { _tipoAlarma = value; }
        }

        public int NivelVolumen
        {
            get { return _nivelVolumen; }
            set
            {
                if (value < 0) _nivelVolumen = 0;
                else if (value > 100) _nivelVolumen = 100;
                else _nivelVolumen = value;
            }
        }

        public Alarma(int id, string nombre, bool encendido = true,
                      bool estaArmada = false, TipoAlarma tipoAlarma = TipoAlarma.Intrusion,
                      int nivelVolumen = 80)
            : base(id, nombre, encendido)
        {
            _estaArmada = estaArmada;
            _tipoAlarma = tipoAlarma;
            _nivelVolumen = nivelVolumen;
        }

        /// <summary>
        /// POLIMORFISMO: implementación específica de Alarma.
        /// Actualiza el estado de alerta de la alarma.
        /// </summary>
        public override void ActualizarEstado()
        {
            // Lógica de actualización de estado de una alarma de seguridad.
            // En un sistema real aquí se procesarían señales de sensores y se activaría la alerta.
            if (!EstaEncendido)
            {
                _estaArmada = false;
                return;
            }

            // Si la alarma está encendida y armada, está lista para detectar eventos
            if (_estaArmada)
            {
                // En un sistema real, aquí se verificarían los sensores conectados
                // y se activaría la alerta según el tipo de alarma configurado
                // Por ahora, mantenemos el estado actual de armado
            }
        }

        public override string ToString()
        {
            string estado = EstaEncendido ? "ENCENDIDA" : "APAGADA";
            string armado = _estaArmada ? "ARMADA" : "DESARMADA";
            
            return $"{Nombre} [{estado}] - {armado} - Tipo: {_tipoAlarma} - Volumen: {_nivelVolumen}%";
        }
    }

    public enum TipoAlarma
    {
        Intrusion,
        Incendio,
        Medica,
        Panico,
        Inundacion
    }
}
