namespace Domotica.Models
{
    /// <summary>
    /// Representa un sensor ambiental (temperatura, humedad, energía, etc).
    /// Aplica HERENCIA: extiende DispositivoBase.
    /// Aplica POLIMORFISMO: redefine ActualizarEstado().
    /// </summary>
    public class SensorAmbiental : DispositivoBase
    {
        // ENCAPSULACIÓN
        private string _tipo;
        private double _valor;
        private string _unidad;
        private string _estadoTexto;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public string Unidad
        {
            get { return _unidad; }
            set { _unidad = value; }
        }

        public string EstadoTexto
        {
            get { return _estadoTexto; }
            set { _estadoTexto = value; }
        }

        public string Estado
        {
            get { return _estadoTexto; }
            set { _estadoTexto = value; }
        }

        public SensorAmbiental(int id, string nombre, string tipo, double valor, string unidad, string estadoTexto = "Normal")
            : base(id, nombre, true)
        {
            _tipo = tipo;
            _valor = valor;
            _unidad = unidad;
            _estadoTexto = estadoTexto;
        }

        /// <summary>
        /// POLIMORFISMO: implementación específica de SensorAmbiental.
        /// </summary>
        public override void ActualizarEstado()
        {
            if (_valor <= 0)
                _estadoTexto = "Inactivo";
            else
                _estadoTexto = "Activo";
        }

        public override string ToString()
        {
            return $"{Nombre}: {_valor}{_unidad} ({_estadoTexto})";
        }
    }
}
