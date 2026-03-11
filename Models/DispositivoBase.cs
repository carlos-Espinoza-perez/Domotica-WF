namespace Domotica.Models
{
    /// <summary>
    /// Clase base abstracta para todos los dispositivos del hogar inteligente.
    /// Aplica ABSTRACCIÓN: define estructura común sin implementación completa.
    /// </summary>
    public abstract class DispositivoBase
    {
        // ENCAPSULACIÓN: campos privados con propiedades públicas
        private int _id;
        private string _nombre;
        private bool _estaEncendido;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public bool EstaEncendido
        {
            get { return _estaEncendido; }
            set { _estaEncendido = value; }
        }

        protected DispositivoBase(int id, string nombre, bool estaEncendido = false)
        {
            _id = id;
            _nombre = nombre;
            _estaEncendido = estaEncendido;
        }

        /// <summary>
        /// ABSTRACCIÓN + POLIMORFISMO: cada subclase define cómo actualiza su propio estado.
        /// </summary>
        public abstract void ActualizarEstado();

        public override string ToString()
        {
            return $"{_nombre} [{(_estaEncendido ? "ENCENDIDO" : "APAGADO")}]";
        }
    }
}
