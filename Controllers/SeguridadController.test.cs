using System;
using System.Linq;
using Domotica.Controllers;
using Domotica.Models;

namespace Domotica.Tests
{
    /// <summary>
    /// Pruebas unitarias para verificar los métodos CRUD de SensorMovimiento en SeguridadController
    /// </summary>
    public class SeguridadControllerTests
    {
        public static void TestSensorMovimientoCRUD()
        {
            Console.WriteLine("=== Iniciando pruebas de CRUD para SensorMovimiento ===\n");

            var controller = SeguridadController.Instancia;

            // Test 1: ObtenerSensoresMovimiento - debe retornar copia de la lista
            Console.WriteLine("Test 1: ObtenerSensoresMovimiento()");
            var sensoresInicial = controller.ObtenerSensoresMovimiento();
            Console.WriteLine($"✓ Sensores iniciales: {sensoresInicial.Count}");
            
            // Test 2: AgregarSensorMovimiento - debe asignar ID automáticamente
            Console.WriteLine("\nTest 2: AgregarSensorMovimiento()");
            var nuevoSensor = new SensorMovimiento(0, "Sensor Test", encendido: true,
                sensibilidad: 8, zonaCobertura: "Zona Test");
            controller.AgregarSensorMovimiento(nuevoSensor);
            var sensoresDespuesAgregar = controller.ObtenerSensoresMovimiento();
            var sensorAgregado = sensoresDespuesAgregar.FirstOrDefault(s => s.Nombre == "Sensor Test");
            
            if (sensorAgregado != null && sensorAgregado.Id > 0)
                Console.WriteLine($"✓ Sensor agregado con ID: {sensorAgregado.Id}");
            else
                Console.WriteLine("✗ Error: Sensor no agregado correctamente");

            // Test 3: EditarSensorMovimiento - debe actualizar propiedades
            Console.WriteLine("\nTest 3: EditarSensorMovimiento()");
            if (sensorAgregado != null)
            {
                sensorAgregado.Sensibilidad = 10;
                sensorAgregado.ZonaCobertura = "Zona Modificada";
                sensorAgregado.EstaEncendido = false;
                controller.EditarSensorMovimiento(sensorAgregado);
                
                var sensoresActualizados = controller.ObtenerSensoresMovimiento();
                var sensorEditado = sensoresActualizados.FirstOrDefault(s => s.Id == sensorAgregado.Id);
                
                if (sensorEditado != null && 
                    sensorEditado.Sensibilidad == 10 && 
                    sensorEditado.ZonaCobertura == "Zona Modificada" &&
                    sensorEditado.EstaEncendido == false)
                    Console.WriteLine("✓ Sensor editado correctamente");
                else
                    Console.WriteLine("✗ Error: Sensor no editado correctamente");
            }

            // Test 4: EliminarSensorMovimiento - debe eliminar por ID
            Console.WriteLine("\nTest 4: EliminarSensorMovimiento()");
            if (sensorAgregado != null)
            {
                int idAEliminar = sensorAgregado.Id;
                controller.EliminarSensorMovimiento(idAEliminar);
                
                var sensoresDespuesEliminar = controller.ObtenerSensoresMovimiento();
                var sensorEliminado = sensoresDespuesEliminar.FirstOrDefault(s => s.Id == idAEliminar);
                
                if (sensorEliminado == null)
                    Console.WriteLine("✓ Sensor eliminado correctamente");
                else
                    Console.WriteLine("✗ Error: Sensor no eliminado");
            }

            Console.WriteLine("\n=== Pruebas completadas ===");
        }

        public static void TestAlarmaCRUD()
        {
            Console.WriteLine("=== Iniciando pruebas de CRUD para Alarma ===\n");

            var controller = SeguridadController.Instancia;

            // Test 1: ObtenerAlarmas - debe retornar copia de la lista
            Console.WriteLine("Test 1: ObtenerAlarmas()");
            var alarmasInicial = controller.ObtenerAlarmas();
            Console.WriteLine($"✓ Alarmas iniciales: {alarmasInicial.Count}");
            
            // Test 2: AgregarAlarma - debe asignar ID automáticamente
            Console.WriteLine("\nTest 2: AgregarAlarma()");
            var nuevaAlarma = new Alarma(0, "Alarma Test", encendido: true,
                estaArmada: false, tipoAlarma: TipoAlarma.Panico, nivelVolumen: 90);
            controller.AgregarAlarma(nuevaAlarma);
            var alarmasDespuesAgregar = controller.ObtenerAlarmas();
            var alarmaAgregada = alarmasDespuesAgregar.FirstOrDefault(a => a.Nombre == "Alarma Test");
            
            if (alarmaAgregada != null && alarmaAgregada.Id > 0)
                Console.WriteLine($"✓ Alarma agregada con ID: {alarmaAgregada.Id}");
            else
                Console.WriteLine("✗ Error: Alarma no agregada correctamente");

            // Test 3: EditarAlarma - debe actualizar propiedades
            Console.WriteLine("\nTest 3: EditarAlarma()");
            if (alarmaAgregada != null)
            {
                alarmaAgregada.EstaArmada = true;
                alarmaAgregada.TipoAlarma = TipoAlarma.Incendio;
                alarmaAgregada.NivelVolumen = 100;
                alarmaAgregada.EstaEncendido = false;
                controller.EditarAlarma(alarmaAgregada);
                
                var alarmasActualizadas = controller.ObtenerAlarmas();
                var alarmaEditada = alarmasActualizadas.FirstOrDefault(a => a.Id == alarmaAgregada.Id);
                
                if (alarmaEditada != null && 
                    alarmaEditada.EstaArmada == true && 
                    alarmaEditada.TipoAlarma == TipoAlarma.Incendio &&
                    alarmaEditada.NivelVolumen == 100 &&
                    alarmaEditada.EstaEncendido == false)
                    Console.WriteLine("✓ Alarma editada correctamente");
                else
                    Console.WriteLine("✗ Error: Alarma no editada correctamente");
            }

            // Test 4: EliminarAlarma - debe eliminar por ID
            Console.WriteLine("\nTest 4: EliminarAlarma()");
            if (alarmaAgregada != null)
            {
                int idAEliminar = alarmaAgregada.Id;
                controller.EliminarAlarma(idAEliminar);
                
                var alarmasDespuesEliminar = controller.ObtenerAlarmas();
                var alarmaEliminada = alarmasDespuesEliminar.FirstOrDefault(a => a.Id == idAEliminar);
                
                if (alarmaEliminada == null)
                    Console.WriteLine("✓ Alarma eliminada correctamente");
                else
                    Console.WriteLine("✗ Error: Alarma no eliminada");
            }

            Console.WriteLine("\n=== Pruebas completadas ===");
        }

        public static void Main(string[] args)
        {
            TestSensorMovimientoCRUD();
            Console.WriteLine("\n");
            TestAlarmaCRUD();
        }
    }
}
