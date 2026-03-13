using FontAwesome.Sharp;

namespace Domotica.Models
{
    /// <summary>
    /// Representa un elemento del panel de Controles Rápidos en la pantalla de Inicio.
    /// ENCAPSULACIÓN: expone solo lo necesario para la vista.
    /// </summary>
    public class ControlRapidoItem
    {
        private string _nombre;
        private IconChar _icono;
        private bool _estaEncendido;
        private int? _luzId; // Si está asociado a una Luz, almacena su Id

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public IconChar Icono
        {
            get { return _icono; }
            set { _icono = value; }
        }

        public bool EstaEncendido
        {
            get { return _estaEncendido; }
            set { _estaEncendido = value; }
        }

        public int? LuzId
        {
            get { return _luzId; }
            set { _luzId = value; }
        }

        public ControlRapidoItem(string nombre, IconChar icono, bool encendido = false, int? luzId = null)
        {
            _nombre = nombre;
            _icono = icono;
            _estaEncendido = encendido;
            _luzId = luzId;
        }
    }
}
