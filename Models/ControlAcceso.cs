using System;
using System.Collections.Generic;

namespace Domotica.Models
{
    /// <summary>
    /// Representa un control de acceso del hogar inteligente.
    /// Aplica HERENCIA: extiende DispositivoBase.
    /// Aplica POLIMORFISMO: redefine ActualizarEstado().
    /// </summary>
    public class ControlAcceso : DispositivoBase
    {
        // ENCAPSULACIÓN: campos privados con propiedades públicas
        private bool _estaBloqueado;
        private MetodoAutenticacion _metodoAutenticacion;
        private List<string> _registroAccesos;

        public bool EstaBloqueado
        {
            get { return _estaBloqueado; }
            set { _estaBloqueado = value; }
        }

        public MetodoAutenticacion MetodoAutenticacion
        {
            get { return _metodoAutenticacion; }
            set { _metodoAutenticacion = value; }
        }

        public List<string> RegistroAccesos
        {
            get { return _registroAccesos; }
            set { _registroAccesos = value; }
        }

        public ControlAcceso(int id, string nombre, bool encendido = true,
                             bool estaBloqueado = true, 
                             MetodoAutenticacion metodoAutenticacion = MetodoAutenticacion.Tarjeta)
            : base(id, nombre, encendido)
        {
            _estaBloqueado = estaBloqueado;
            _metodoAutenticacion = metodoAutenticacion;
            _registroAccesos = new List<string>();
        }

        /// <summary>
        /// POLIMORFISMO: implementación específica de ControlAcceso.
        /// Actualiza el estado de control de acceso del dispositivo.
        /// </summary>
        public override void ActualizarEstado()
        {
            // Lógica de actualización de estado de un control de acceso.
            // En un sistema real aquí se procesarían intentos de acceso y se validarían credenciales.
            if (!EstaEncendido)
            {
                _estaBloqueado = true;
                return;
            }

            // Si el control de acceso está encendido, está listo para procesar autenticaciones
            if (EstaEncendido)
            {
                // En un sistema real, aquí se verificarían las credenciales según el método
                // de autenticación configurado (tarjeta, PIN, huella, facial)
                // y se registrarían los intentos de acceso en el registro
                // Por ahora, mantenemos el estado actual de bloqueo
            }
        }

        public override string ToString()
        {
            string estado = EstaEncendido ? "ENCENDIDO" : "APAGADO";
            string bloqueo = _estaBloqueado ? "BLOQUEADO" : "DESBLOQUEADO";
            int totalAccesos = _registroAccesos.Count;
            
            return $"{Nombre} [{estado}] - {bloqueo} - Método: {_metodoAutenticacion} - Accesos: {totalAccesos}";
        }
    }

    public enum MetodoAutenticacion
    {
        Tarjeta,
        PIN,
        Huella,
        Facial,
        Combinado
    }
}
