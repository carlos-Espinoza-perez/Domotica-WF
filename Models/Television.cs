using System;

namespace Domotica.Models
{
    /// <summary>
    /// Representa una televisión del hogar inteligente.
    /// Aplica HERENCIA: extiende DispositivoBase.
    /// Aplica POLIMORFISMO: redefine ActualizarEstado().
    /// </summary>
    public class Television : DispositivoBase
    {
        // ENCAPSULACIÓN: campos privados con propiedades públicas
        private int _canalActual;
        private int _volumen;
        private FuenteEntrada _fuenteEntrada;
        private ModoImagen _modoImagen;

        public int CanalActual
        {
            get { return _canalActual; }
            set
            {
                if (value < 1) _canalActual = 1;
                else if (value > 999) _canalActual = 999;
                else _canalActual = value;
            }
        }

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

        public FuenteEntrada FuenteEntrada
        {
            get { return _fuenteEntrada; }
            set { _fuenteEntrada = value; }
        }

        public ModoImagen ModoImagen
        {
            get { return _modoImagen; }
            set { _modoImagen = value; }
        }

        public Television(int id, string nombre, bool encendido = false,
                         int canalActual = 1, int volumen = 50,
                         FuenteEntrada fuenteEntrada = FuenteEntrada.TV,
                         ModoImagen modoImagen = ModoImagen.Estandar)
            : base(id, nombre, encendido)
        {
            _canalActual = canalActual;
            _volumen = volumen;
            _fuenteEntrada = fuenteEntrada;
            _modoImagen = modoImagen;
        }

        /// <summary>
        /// POLIMORFISMO: implementación específica de Television.
        /// Actualiza el estado de reproducción de video.
        /// </summary>
        public override void ActualizarEstado()
        {
            // Lógica de actualización de estado de una televisión.
            // En un sistema real aquí se controlaría la reproducción de video.
            if (!EstaEncendido)
            {
                return;
            }

            // Si la televisión está encendida, ajustar configuración según la fuente
            switch (_fuenteEntrada)
            {
                case FuenteEntrada.TV:
                    // En modo TV, asegurar que el canal esté en rango válido
                    if (_canalActual < 1 || _canalActual > 999)
                    {
                        _canalActual = 1;
                    }
                    break;
                case FuenteEntrada.HDMI1:
                case FuenteEntrada.HDMI2:
                case FuenteEntrada.HDMI3:
                    // En modo HDMI, el canal no aplica
                    break;
                case FuenteEntrada.USB:
                    // En modo USB, reproducir contenido multimedia
                    break;
                case FuenteEntrada.Streaming:
                    // En modo Streaming, conectar a servicios en línea
                    break;
            }

            // Ajustar configuración de imagen según el modo
            switch (_modoImagen)
            {
                case ModoImagen.Estandar:
                    // Configuración balanceada
                    break;
                case ModoImagen.Vivido:
                    // Colores más saturados y brillantes
                    break;
                case ModoImagen.Cine:
                    // Optimizado para películas
                    break;
                case ModoImagen.Deporte:
                    // Optimizado para contenido deportivo
                    break;
                case ModoImagen.Juego:
                    // Baja latencia para videojuegos
                    break;
            }
        }

        public override string ToString()
        {
            string estado = EstaEncendido ? "ENCENDIDO" : "APAGADO";
            string fuente = _fuenteEntrada.ToString();
            string modo = _modoImagen.ToString();
            string canal = _fuenteEntrada == FuenteEntrada.TV ? $"Canal {_canalActual}" : "N/A";

            return $"{Nombre} [{estado}] - {fuente} - {canal} - Vol: {_volumen}% - Modo: {modo}";
        }
    }

    public enum FuenteEntrada
    {
        TV,
        HDMI1,
        HDMI2,
        HDMI3,
        USB,
        Streaming
    }

    public enum ModoImagen
    {
        Estandar,
        Vivido,
        Cine,
        Deporte,
        Juego
    }
}
