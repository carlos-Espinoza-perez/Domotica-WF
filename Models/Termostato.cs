using System;

namespace Domotica.Models
{
    /// <summary>
    /// Representa un termostato del hogar inteligente.
    /// Aplica HERENCIA: extiende DispositivoBase.
    /// Aplica POLIMORFISMO: redefine ActualizarEstado().
    /// </summary>
    public class Termostato : DispositivoBase
    {
        // ENCAPSULACIÓN: campos privados con propiedades públicas
        private double _temperaturaObjetivo;
        private double _temperaturaActual;
        private ModoOperacion _modoOperacion;
        private VelocidadVentilador _velocidadVentilador;

        public double TemperaturaObjetivo
        {
            get { return _temperaturaObjetivo; }
            set
            {
                if (value < 16) _temperaturaObjetivo = 16;
                else if (value > 30) _temperaturaObjetivo = 30;
                else _temperaturaObjetivo = value;
            }
        }

        public double TemperaturaActual
        {
            get { return _temperaturaActual; }
            set { _temperaturaActual = value; }
        }

        public ModoOperacion ModoOperacion
        {
            get { return _modoOperacion; }
            set { _modoOperacion = value; }
        }

        public VelocidadVentilador VelocidadVentilador
        {
            get { return _velocidadVentilador; }
            set { _velocidadVentilador = value; }
        }

        public Termostato(int id, string nombre, bool encendido = true, 
                         double temperaturaObjetivo = 22, double temperaturaActual = 20,
                         ModoOperacion modo = ModoOperacion.Auto, 
                         VelocidadVentilador velocidad = VelocidadVentilador.Media)
            : base(id, nombre, encendido)
        {
            _temperaturaObjetivo = temperaturaObjetivo;
            _temperaturaActual = temperaturaActual;
            _modoOperacion = modo;
            _velocidadVentilador = velocidad;
        }

        /// <summary>
        /// POLIMORFISMO: implementación específica de Termostato.
        /// Actualiza el estado del termostato según la temperatura objetivo y el modo de operación.
        /// </summary>
        public override void ActualizarEstado()
        {
            // Lógica de actualización de estado de un termostato.
            // En un sistema real aquí se enviaría la señal al dispositivo.
            if (!EstaEncendido)
            {
                _velocidadVentilador = VelocidadVentilador.Apagado;
                return;
            }

            // Simular ajuste de temperatura según el modo
            double diferencia = _temperaturaObjetivo - _temperaturaActual;

            if (_modoOperacion == ModoOperacion.Calefaccion && diferencia > 0)
            {
                // Ajustar velocidad del ventilador según la diferencia de temperatura
                if (Math.Abs(diferencia) > 3)
                    _velocidadVentilador = VelocidadVentilador.Alta;
                else if (Math.Abs(diferencia) > 1)
                    _velocidadVentilador = VelocidadVentilador.Media;
                else
                    _velocidadVentilador = VelocidadVentilador.Baja;
            }
            else if (_modoOperacion == ModoOperacion.Refrigeracion && diferencia < 0)
            {
                // Ajustar velocidad del ventilador según la diferencia de temperatura
                if (Math.Abs(diferencia) > 3)
                    _velocidadVentilador = VelocidadVentilador.Alta;
                else if (Math.Abs(diferencia) > 1)
                    _velocidadVentilador = VelocidadVentilador.Media;
                else
                    _velocidadVentilador = VelocidadVentilador.Baja;
            }
            else if (_modoOperacion == ModoOperacion.Auto)
            {
                // Modo automático: selecciona calefacción o refrigeración según necesidad
                if (Math.Abs(diferencia) > 3)
                    _velocidadVentilador = VelocidadVentilador.Alta;
                else if (Math.Abs(diferencia) > 1)
                    _velocidadVentilador = VelocidadVentilador.Media;
                else if (Math.Abs(diferencia) > 0.5)
                    _velocidadVentilador = VelocidadVentilador.Baja;
                else
                    _velocidadVentilador = VelocidadVentilador.Apagado;
            }
            else
            {
                // Modo ventilador: mantiene velocidad configurada
                // No se modifica la velocidad del ventilador
            }
        }

        public override string ToString()
        {
            return $"{Nombre} - {_temperaturaActual}°C → {_temperaturaObjetivo}°C [{_modoOperacion}] [Ventilador: {_velocidadVentilador}]";
        }
    }

    public enum ModoOperacion
    {
        Calefaccion,
        Refrigeracion,
        Auto,
        Ventilador
    }

    public enum VelocidadVentilador
    {
        Apagado,
        Baja,
        Media,
        Alta
    }
}
