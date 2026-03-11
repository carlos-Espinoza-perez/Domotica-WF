using System;

namespace Domotica.Models
{
    /// <summary>
    /// Representa una luz del hogar inteligente.
    /// Aplica HERENCIA: extiende DispositivoBase.
    /// Aplica POLIMORFISMO: redefine ActualizarEstado().
    /// </summary>
    public class Luz : DispositivoBase
    {
        // ENCAPSULACIÓN
        private int _intensidad;
        private TemperaturaColor _temperaturaColor;

        public int Intensidad
        {
            get { return _intensidad; }
            set
            {
                if (value < 0) _intensidad = 0;
                else if (value > 100) _intensidad = 100;
                else _intensidad = value;
            }
        }

        public TemperaturaColor TemperaturaColor
        {
            get { return _temperaturaColor; }
            set { _temperaturaColor = value; }
        }

        public Luz(int id, string nombre, bool encendida = true, int intensidad = 75,
                   TemperaturaColor temperatura = TemperaturaColor.Calido)
            : base(id, nombre, encendida)
        {
            _intensidad = intensidad;
            _temperaturaColor = temperatura;
        }

        /// <summary>
        /// POLIMORFISMO: implementación específica de Luz.
        /// </summary>
        public override void ActualizarEstado()
        {
            // Lógica de actualización de estado de una luz.
            // En un sistema real aquí se enviaría la señal al dispositivo.
            if (!EstaEncendido)
            {
                _intensidad = 0;
            }
        }

        public override string ToString()
        {
            return $"{Nombre} - {_intensidad}% [{_temperaturaColor}]";
        }
    }

    public enum TemperaturaColor
    {
        Calido,
        Frio,
        Color
    }
}
