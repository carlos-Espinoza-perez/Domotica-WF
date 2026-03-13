using System;

namespace Domotica.Models
{
    /// <summary>
    /// Representa un sensor de calidad de aire del hogar inteligente.
    /// Aplica HERENCIA: extiende DispositivoBase.
    /// Aplica POLIMORFISMO: redefine ActualizarEstado().
    /// </summary>
    public class SensorCalidadAire : DispositivoBase
    {
        // ENCAPSULACIÓN: campos privados con propiedades públicas
        private int _nivelCO2;
        private double _nivelPM25;
        private EstadoCalidad _estadoCalidad;

        public int NivelCO2
        {
            get { return _nivelCO2; }
            set
            {
                if (value < 0) _nivelCO2 = 0;
                else if (value > 5000) _nivelCO2 = 5000;
                else _nivelCO2 = value;
            }
        }

        public double NivelPM25
        {
            get { return _nivelPM25; }
            set
            {
                if (value < 0) _nivelPM25 = 0;
                else if (value > 500) _nivelPM25 = 500;
                else _nivelPM25 = value;
            }
        }

        public EstadoCalidad EstadoCalidad
        {
            get { return _estadoCalidad; }
            set { _estadoCalidad = value; }
        }

        public SensorCalidadAire(int id, string nombre, bool encendido = true,
                                 int nivelCO2 = 400, double nivelPM25 = 10,
                                 EstadoCalidad estadoCalidad = EstadoCalidad.Buena)
            : base(id, nombre, encendido)
        {
            _nivelCO2 = nivelCO2;
            _nivelPM25 = nivelPM25;
            _estadoCalidad = estadoCalidad;
        }

        /// <summary>
        /// POLIMORFISMO: implementación específica de SensorCalidadAire.
        /// Actualiza el estado de calidad del aire según los niveles de CO2 y PM2.5.
        /// </summary>
        public override void ActualizarEstado()
        {
            // Lógica de actualización de estado de un sensor de calidad de aire.
            // En un sistema real aquí se leería la información del sensor.
            if (!EstaEncendido)
            {
                _estadoCalidad = EstadoCalidad.Desconocida;
                return;
            }

            // Evaluar calidad del aire según niveles de CO2 y PM2.5
            // Niveles de CO2 (ppm):
            // - Excelente: < 600
            // - Buena: 600-1000
            // - Moderada: 1000-1500
            // - Mala: 1500-2500
            // - Peligrosa: > 2500
            
            // Niveles de PM2.5 (μg/m³):
            // - Excelente: < 12
            // - Buena: 12-35
            // - Moderada: 35-55
            // - Mala: 55-150
            // - Peligrosa: > 150

            int puntajeCO2 = 0;
            if (_nivelCO2 < 600) puntajeCO2 = 5;
            else if (_nivelCO2 < 1000) puntajeCO2 = 4;
            else if (_nivelCO2 < 1500) puntajeCO2 = 3;
            else if (_nivelCO2 < 2500) puntajeCO2 = 2;
            else puntajeCO2 = 1;

            int puntajePM25 = 0;
            if (_nivelPM25 < 12) puntajePM25 = 5;
            else if (_nivelPM25 < 35) puntajePM25 = 4;
            else if (_nivelPM25 < 55) puntajePM25 = 3;
            else if (_nivelPM25 < 150) puntajePM25 = 2;
            else puntajePM25 = 1;

            // Calcular estado de calidad basado en el peor indicador
            int puntajeFinal = Math.Min(puntajeCO2, puntajePM25);

            switch (puntajeFinal)
            {
                case 5:
                    _estadoCalidad = EstadoCalidad.Excelente;
                    break;
                case 4:
                    _estadoCalidad = EstadoCalidad.Buena;
                    break;
                case 3:
                    _estadoCalidad = EstadoCalidad.Moderada;
                    break;
                case 2:
                    _estadoCalidad = EstadoCalidad.Mala;
                    break;
                case 1:
                    _estadoCalidad = EstadoCalidad.Peligrosa;
                    break;
                default:
                    _estadoCalidad = EstadoCalidad.Desconocida;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{Nombre} - CO2: {_nivelCO2} ppm, PM2.5: {_nivelPM25} μg/m³ [Calidad: {_estadoCalidad}]";
        }
    }

    public enum EstadoCalidad
    {
        Excelente,
        Buena,
        Moderada,
        Mala,
        Peligrosa,
        Desconocida
    }
}
