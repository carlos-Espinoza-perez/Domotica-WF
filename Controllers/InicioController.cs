using System.Collections.Generic;
using System.Linq;
using Domotica.Models;
using FontAwesome.Sharp;

namespace Domotica.Controllers
{
    /// <summary>
    /// Controlador de la pantalla de Inicio — expone datos de sensores y controles rápidos.
    /// ENCAPSULACIÓN: listas privadas con acceso controlado.
    /// </summary>
    public class InicioController
    {
        private static InicioController _instancia;
        private List<SensorAmbiental> _sensores;
        private List<ControlRapidoItem> _controlesRapidos;

        public static InicioController Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new InicioController();
                return _instancia;
            }
        }

        private InicioController()
        {
            CargarSensores();
            CargarControlesRapidos();
        }

        private void CargarSensores()
        {
            _sensores = new List<SensorAmbiental>
            {
                new SensorAmbiental(1, "Temperatura", "temperatura", 22.5, "°C", "Confortable"),
                new SensorAmbiental(2, "Humedad",     "humedad",     62,   "%",  "Normal"),
                new SensorAmbiental(3, "Energía",     "energia",     840,  "W",  "Normal"),
                new SensorAmbiental(4, "Seguridad",   "seguridad",   1,    "",   "Armado")
            };
        }

        private void CargarControlesRapidos()
        {
            // Vincula algunos controles a IDs de luz del IluminacionController
            _controlesRapidos = new List<ControlRapidoItem>
            {
                new ControlRapidoItem("Sala de Estar",   IconChar.Lightbulb,  encendido: true,  luzId: 1),
                new ControlRapidoItem("Cocina",          IconChar.Lightbulb,  encendido: false, luzId: 2),
                new ControlRapidoItem("Exterior",        IconChar.Moon,       encendido: true,  luzId: 4),
                new ControlRapidoItem("Puerta Principal",IconChar.Lock,       encendido: true,  luzId: null),
                new ControlRapidoItem("Música",          IconChar.Music,      encendido: true,  luzId: null),
                new ControlRapidoItem("Televisión",      IconChar.Tv,         encendido: false, luzId: null),
            };
        }

        public List<SensorAmbiental> ObtenerSensores()
        {
            return new List<SensorAmbiental>(_sensores);
        }

        public SensorAmbiental ObtenerSensor(string tipo)
        {
            return _sensores.Find(s => s.Tipo == tipo);
        }

        public List<ControlRapidoItem> ObtenerControlesRapidos()
        {
            // Sincronizar estado encendido con los controladores correspondientes
            foreach (var control in _controlesRapidos)
            {
                if (control.LuzId.HasValue)
                {
                    var luces = IluminacionController.Instancia.ObtenerLuces();
                    var luz = luces.Find(l => l.Id == control.LuzId.Value);
                    if (luz != null)
                        control.EstaEncendido = luz.EstaEncendido;
                }
                else if (control.Nombre == "Puerta Principal")
                {
                    var accesos = SeguridadController.Instancia.ObtenerControlesAcceso();
                    var puerta = accesos.Find(a => a.Nombre == "Puerta Principal");
                    if (puerta != null)
                        control.EstaEncendido = !puerta.EstaBloqueado; // Encendido = Desbloqueado
                }
                else if (control.Nombre == "Música")
                {
                    var musica = MultimediaController.Instancia.ObtenerSistemasMusica();
                    if (musica.Count > 0)
                        control.EstaEncendido = musica[0].EstaEncendido;
                }
                else if (control.Nombre == "Televisión")
                {
                    var tvs = MultimediaController.Instancia.ObtenerTelevisiones();
                    if (tvs.Count > 0)
                        control.EstaEncendido = tvs[0].EstaEncendido;
                }
            }
            return new List<ControlRapidoItem>(_controlesRapidos);
        }

        public void ConmutarControlRapido(string nombre)
        {
            var control = _controlesRapidos.Find(c => c.Nombre == nombre);
            if (control == null) return;

            if (control.LuzId.HasValue)
            {
                IluminacionController.Instancia.ConmutarLuz(control.LuzId.Value);
            }
            else if (nombre == "Puerta Principal")
            {
                var puerta = SeguridadController.Instancia.ObtenerControlesAcceso().Find(a => a.Nombre == "Puerta Principal");
                if (puerta != null)
                {
                    SeguridadController.Instancia.ConmutarAcceso(puerta.Id);
                }
            }
            else if (nombre == "Música")
            {
                var musica = MultimediaController.Instancia.ObtenerSistemasMusica();
                if (musica.Count > 0)
                {
                    MultimediaController.Instancia.ConmutarEstadoMusica(musica[0].Id);
                }
            }
            else if (nombre == "Televisión")
            {
                var tvs = MultimediaController.Instancia.ObtenerTelevisiones();
                if (tvs.Count > 0)
                {
                    MultimediaController.Instancia.ConmutarEstadoTelevision(tvs[0].Id);
                }
            }
        }

        public SensorAmbiental ObtenerResumenSensor(string tipo)
        {
            var sensor = _sensores.Find(s => s.Tipo.ToLower() == tipo.ToLower());
            if (sensor == null) return null;

            switch (tipo.ToLower())
            {
                case "temperatura":
                    var termostatos = ClimaController.Instancia.ObtenerTermostatos();
                    if (termostatos.Count > 0)
                        sensor.Valor = termostatos.Average(t => t.TemperaturaActual);
                    break;
                case "seguridad":
                    var alarmas = SeguridadController.Instancia.ObtenerAlarmas();
                    bool armada = alarmas.Any(a => a.EstaArmada);
                    sensor.Valor = armada ? 1 : 0;
                    sensor.Estado = armada ? "Armado" : "Desarmado";
                    break;
            }
            return sensor;
        }
    }
}
