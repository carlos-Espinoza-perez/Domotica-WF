using System.Collections.Generic;
using System.Linq;
using Domotica.Models;

namespace Domotica.Controllers
{
    /// <summary>
    /// Controlador de Iluminación — gestiona el CRUD de luces.
    /// ENCAPSULACIÓN: la lista interna solo es accesible mediante métodos públicos.
    /// </summary>
    public class IluminacionController
    {
        private static IluminacionController _instancia;
        private List<Luz> _luces;
        private int _contadorId;

        // Singleton: instancia compartida entre formularios
        public static IluminacionController Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new IluminacionController();
                return _instancia;
            }
        }

        private IluminacionController()
        {
            _contadorId = 1;
            _luces = new List<Luz>();
            CargarLucesPorDefecto();
        }

        /// <summary>
        /// Carga las 5 luces predeterminadas del hogar.
        /// </summary>
        private void CargarLucesPorDefecto()
        {
            _luces.Add(new Luz(_contadorId++, "Sala de Estar",    encendida: true,  intensidad: 75,  temperatura: TemperaturaColor.Calido));
            _luces.Add(new Luz(_contadorId++, "Cocina",           encendida: false, intensidad: 60,  temperatura: TemperaturaColor.Frio));
            _luces.Add(new Luz(_contadorId++, "Dormitorio",       encendida: false, intensidad: 40,  temperatura: TemperaturaColor.Calido));
            _luces.Add(new Luz(_contadorId++, "Exterior",         encendida: true,  intensidad: 80,  temperatura: TemperaturaColor.Calido));
            _luces.Add(new Luz(_contadorId++, "Patio Trasero",    encendida: false, intensidad: 50,  temperatura: TemperaturaColor.Frio));
        }

        // ==========================================
        // CRUD
        // ==========================================

        public List<Luz> ObtenerLuces()
        {
            return new List<Luz>(_luces);
        }

        public void AgregarLuz(Luz luz)
        {
            luz.Id = _contadorId++;
            _luces.Add(luz);
        }

        public void EditarLuz(Luz luzActualizada)
        {
            Luz existente = _luces.FirstOrDefault(l => l.Id == luzActualizada.Id);
            if (existente != null)
            {
                existente.Nombre          = luzActualizada.Nombre;
                existente.EstaEncendido   = luzActualizada.EstaEncendido;
                existente.Intensidad      = luzActualizada.Intensidad;
                existente.TemperaturaColor = luzActualizada.TemperaturaColor;
                existente.ActualizarEstado();
            }
        }

        public void EliminarLuz(int id)
        {
            Luz luz = _luces.FirstOrDefault(l => l.Id == id);
            if (luz != null)
                _luces.Remove(luz);
        }

        public int ContarEncendidas()
        {
            return _luces.Count(l => l.EstaEncendido);
        }

        public int ContarTotal()
        {
            return _luces.Count;
        }

        public void ConmutarLuz(int id)
        {
            Luz luz = _luces.FirstOrDefault(l => l.Id == id);
            if (luz != null)
            {
                luz.EstaEncendido = !luz.EstaEncendido;
                luz.ActualizarEstado();
            }
        }

        public void CambiarIntensidad(int id, int intensidad)
        {
            Luz luz = _luces.FirstOrDefault(l => l.Id == id);
            if (luz != null)
                luz.Intensidad = intensidad;
        }

        public void CambiarTemperatura(int id, TemperaturaColor temperatura)
        {
            Luz luz = _luces.FirstOrDefault(l => l.Id == id);
            if (luz != null)
                luz.TemperaturaColor = temperatura;
        }
    }
}
