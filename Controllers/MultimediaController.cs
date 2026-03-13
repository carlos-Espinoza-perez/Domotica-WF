using System.Collections.Generic;
using System.Linq;
using Domotica.Models;

namespace Domotica.Controllers
{
    /// <summary>
    /// Controlador Multimedia — gestiona el CRUD de sistemas de música y televisiones.
    /// ENCAPSULACIÓN: las listas internas solo son accesibles mediante métodos públicos.
    /// </summary>
    public class MultimediaController
    {
        private static MultimediaController _instancia;
        private List<SistemaMusica> _sistemasMusica;
        private List<Television> _televisiones;
        private int _contadorId;

        // Singleton: instancia compartida entre formularios
        public static MultimediaController Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new MultimediaController();
                return _instancia;
            }
        }

        private MultimediaController()
        {
            _contadorId = 1;
            _sistemasMusica = new List<SistemaMusica>();
            _televisiones = new List<Television>();
            CargarDispositivosPorDefecto();
        }

        /// <summary>
        /// Carga los dispositivos multimedia predeterminados del hogar.
        /// </summary>
        private void CargarDispositivosPorDefecto()
        {
            // Cargar sistemas de música por defecto
            _sistemasMusica.Add(new SistemaMusica(_contadorId++, "Sistema Sala", encendido: true,
                volumen: 60, cancionActual: "Bohemian Rhapsody - Queen",
                listaReproduccion: new List<string> { "Bohemian Rhapsody - Queen", "Stairway to Heaven - Led Zeppelin", "Hotel California - Eagles" },
                modoReproduccion: ModoReproduccion.Normal));

            _sistemasMusica.Add(new SistemaMusica(_contadorId++, "Sistema Dormitorio", encendido: false,
                volumen: 30, cancionActual: "Sin reproducción",
                listaReproduccion: new List<string> { "Imagine - John Lennon", "Yesterday - The Beatles" },
                modoReproduccion: ModoReproduccion.RepetirTodas));

            // Cargar televisiones por defecto
            _televisiones.Add(new Television(_contadorId++, "TV Sala", encendido: true,
                canalActual: 5, volumen: 50,
                fuenteEntrada: FuenteEntrada.TV, modoImagen: ModoImagen.Estandar));

            _televisiones.Add(new Television(_contadorId++, "TV Dormitorio", encendido: false,
                canalActual: 1, volumen: 40,
                fuenteEntrada: FuenteEntrada.Streaming, modoImagen: ModoImagen.Cine));
        }

        // ==========================================
        // CRUD - Sistemas de Música
        // ==========================================

        public List<SistemaMusica> ObtenerSistemasMusica()
        {
            return new List<SistemaMusica>(_sistemasMusica);
        }

        public void AgregarSistemaMusica(SistemaMusica sistema)
        {
            sistema.Id = _contadorId++;
            _sistemasMusica.Add(sistema);
        }

        public void EditarSistemaMusica(SistemaMusica sistemaActualizado)
        {
            SistemaMusica existente = _sistemasMusica.FirstOrDefault(s => s.Id == sistemaActualizado.Id);
            if (existente != null)
            {
                existente.Nombre = sistemaActualizado.Nombre;
                existente.EstaEncendido = sistemaActualizado.EstaEncendido;
                existente.Volumen = sistemaActualizado.Volumen;
                existente.CancionActual = sistemaActualizado.CancionActual;
                existente.ListaReproduccion = sistemaActualizado.ListaReproduccion;
                existente.ModoReproduccion = sistemaActualizado.ModoReproduccion;
                existente.ActualizarEstado();
            }
        }

        public void EliminarSistemaMusica(int id)
        {
            SistemaMusica sistema = _sistemasMusica.FirstOrDefault(s => s.Id == id);
            if (sistema != null)
                _sistemasMusica.Remove(sistema);
        }

        // ==========================================
        // CRUD - Televisiones
        // ==========================================

        public List<Television> ObtenerTelevisiones()
        {
            return new List<Television>(_televisiones);
        }

        public void AgregarTelevision(Television television)
        {
            television.Id = _contadorId++;
            _televisiones.Add(television);
        }

        public void EditarTelevision(Television televisionActualizada)
        {
            Television existente = _televisiones.FirstOrDefault(t => t.Id == televisionActualizada.Id);
            if (existente != null)
            {
                existente.Nombre = televisionActualizada.Nombre;
                existente.EstaEncendido = televisionActualizada.EstaEncendido;
                existente.CanalActual = televisionActualizada.CanalActual;
                existente.Volumen = televisionActualizada.Volumen;
                existente.FuenteEntrada = televisionActualizada.FuenteEntrada;
                existente.ModoImagen = televisionActualizada.ModoImagen;
                existente.ActualizarEstado();
            }
        }

        public void EliminarTelevision(int id)
        {
            Television television = _televisiones.FirstOrDefault(t => t.Id == id);
            if (television != null)
                _televisiones.Remove(television);
        }

        // ==========================================
        // Métodos de Control Específicos
        // ==========================================

        /// <summary>
        /// Cambia el volumen de un sistema de música o televisión específico.
        /// </summary>
        /// <param name="id">ID del dispositivo</param>
        /// <param name="volumen">Nuevo volumen (0-100)</param>
        public void CambiarVolumen(int id, int volumen)
        {
            // Buscar en sistemas de música
            SistemaMusica sistema = _sistemasMusica.FirstOrDefault(s => s.Id == id);
            if (sistema != null)
            {
                sistema.Volumen = volumen;
                sistema.ActualizarEstado();
                return;
            }

            // Buscar en televisiones
            Television television = _televisiones.FirstOrDefault(t => t.Id == id);
            if (television != null)
            {
                television.Volumen = volumen;
                television.ActualizarEstado();
            }
        }

        /// <summary>
        /// Cambia la canción actual de un sistema de música específico.
        /// </summary>
        /// <param name="id">ID del sistema de música</param>
        /// <param name="cancion">Nombre de la canción</param>
        public void CambiarCancion(int id, string cancion)
        {
            SistemaMusica sistema = _sistemasMusica.FirstOrDefault(s => s.Id == id);
            if (sistema != null)
            {
                sistema.CancionActual = cancion;
                sistema.ActualizarEstado();
            }
        }

        /// <summary>
        /// Cambia el canal de una televisión específica.
        /// </summary>
        /// <param name="id">ID de la televisión</param>
        /// <param name="canal">Número de canal (1-999)</param>
        public void CambiarCanal(int id, int canal)
        {
            Television television = _televisiones.FirstOrDefault(t => t.Id == id);
            if (television != null)
            {
                television.CanalActual = canal;
                television.ActualizarEstado();
            }
        }

        /// <summary>
        /// Cambia la fuente de entrada de una televisión específica.
        /// </summary>
        /// <param name="id">ID de la televisión</param>
        /// <param name="fuente">Fuente de entrada: "TV", "HDMI1", "HDMI2", "HDMI3", "USB", "Streaming"</param>
        public void CambiarFuenteEntrada(int id, string fuente)
        {
            Television television = _televisiones.FirstOrDefault(t => t.Id == id);
            if (television != null)
            {
                FuenteEntrada fuenteEnum;
                if (System.Enum.TryParse(fuente, out fuenteEnum))
                {
                    television.FuenteEntrada = fuenteEnum;
                    television.ActualizarEstado();
                }
            }
        }

        /// <summary>
        /// Reproduce contenido en un sistema de música específico.
        /// </summary>
        /// <param name="id">ID del sistema de música</param>
        public void Reproducir(int id)
        {
            SistemaMusica sistema = _sistemasMusica.FirstOrDefault(s => s.Id == id);
            if (sistema != null)
            {
                sistema.EstaEncendido = true;
                sistema.ActualizarEstado();
            }
        }

        /// <summary>
        /// Pausa la reproducción en un sistema de música específico.
        /// </summary>
        /// <param name="id">ID del sistema de música</param>
        public void Pausar(int id)
        {
            SistemaMusica sistema = _sistemasMusica.FirstOrDefault(s => s.Id == id);
            if (sistema != null)
            {
                // En un sistema real, aquí se pausaría la reproducción sin apagar el dispositivo
                // Por simplicidad, mantenemos el dispositivo encendido pero actualizamos el estado
                sistema.ActualizarEstado();
            }
        }

        /// <summary>
        /// Detiene la reproducción en un sistema de música específico.
        /// </summary>
        /// <param name="id">ID del sistema de música</param>
        public void Detener(int id)
        {
            SistemaMusica sistema = _sistemasMusica.FirstOrDefault(s => s.Id == id);
            if (sistema != null)
            {
                sistema.EstaEncendido = false;
                sistema.CancionActual = "Sin reproducción";
                sistema.ActualizarEstado();
            }
        }

        public void ConmutarEstadoMusica(int id)
        {
            SistemaMusica sistema = _sistemasMusica.FirstOrDefault(s => s.Id == id);
            if (sistema != null)
            {
                sistema.EstaEncendido = !sistema.EstaEncendido;
                sistema.ActualizarEstado();
            }
        }

        public void ConmutarEstadoTelevision(int id)
        {
            Television tv = _televisiones.FirstOrDefault(t => t.Id == id);
            if (tv != null)
            {
                tv.EstaEncendido = !tv.EstaEncendido;
                tv.ActualizarEstado();
            }
        }
    }
}
