using System;
using System.Collections.Generic;

namespace Domotica.Models
{
    /// <summary>
    /// Representa un sistema de música del hogar inteligente.
    /// Aplica HERENCIA: extiende DispositivoBase.
    /// Aplica POLIMORFISMO: redefine ActualizarEstado().
    /// </summary>
    public class SistemaMusica : DispositivoBase
    {
        // ENCAPSULACIÓN: campos privados con propiedades públicas
        private int _volumen;
        private string _cancionActual;
        private List<string> _listaReproduccion;
        private ModoReproduccion _modoReproduccion;

        public int Volumen
        {
            get { return _volumen; }
            set
            {
                if (value < 0) _volumen = 0;
                else if (value > 100) _volumen = 100;
                else _volumen = value;
            }
        }

        public string CancionActual
        {
            get { return _cancionActual; }
            set { _cancionActual = value; }
        }

        public List<string> ListaReproduccion
        {
            get { return _listaReproduccion; }
            set { _listaReproduccion = value; }
        }

        public ModoReproduccion ModoReproduccion
        {
            get { return _modoReproduccion; }
            set { _modoReproduccion = value; }
        }

        public SistemaMusica(int id, string nombre, bool encendido = false,
                            int volumen = 50, string cancionActual = "Sin reproducción",
                            List<string> listaReproduccion = null,
                            ModoReproduccion modoReproduccion = ModoReproduccion.Normal)
            : base(id, nombre, encendido)
        {
            _volumen = volumen;
            _cancionActual = cancionActual;
            _listaReproduccion = listaReproduccion ?? new List<string>();
            _modoReproduccion = modoReproduccion;
        }

        /// <summary>
        /// POLIMORFISMO: implementación específica de SistemaMusica.
        /// Actualiza el estado de reproducción de audio.
        /// </summary>
        public override void ActualizarEstado()
        {
            // Lógica de actualización de estado de un sistema de música.
            // En un sistema real aquí se controlaría la reproducción de audio.
            if (!EstaEncendido)
            {
                _cancionActual = "Sin reproducción";
                return;
            }

            // Si el sistema está encendido y hay canciones en la lista de reproducción
            if (_listaReproduccion != null && _listaReproduccion.Count > 0)
            {
                // Lógica según el modo de reproducción
                switch (_modoReproduccion)
                {
                    case ModoReproduccion.Normal:
                        // En modo normal, reproducir secuencialmente
                        // En un sistema real, aquí se avanzaría a la siguiente canción
                        break;
                    case ModoReproduccion.Aleatorio:
                        // En modo aleatorio, seleccionar canción aleatoria
                        // En un sistema real, aquí se seleccionaría una canción al azar
                        break;
                    case ModoReproduccion.RepetirUna:
                        // En modo repetir una, mantener la canción actual
                        break;
                    case ModoReproduccion.RepetirTodas:
                        // En modo repetir todas, volver al inicio al terminar la lista
                        break;
                }
            }
            else
            {
                _cancionActual = "Lista vacía";
            }
        }

        public override string ToString()
        {
            string estado = EstaEncendido ? "ENCENDIDO" : "APAGADO";
            string modo = _modoReproduccion.ToString();
            int totalCanciones = _listaReproduccion?.Count ?? 0;
            
            return $"{Nombre} [{estado}] - Vol: {_volumen}% - {_cancionActual} - Modo: {modo} - Canciones: {totalCanciones}";
        }
    }

    public enum ModoReproduccion
    {
        Normal,
        Aleatorio,
        RepetirUna,
        RepetirTodas
    }
}
