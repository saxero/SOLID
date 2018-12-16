using InversionOfControlMotor;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotor motorDeGasolina = new MotorGasolina();
            //Vehiculo v = new Vehiculo(motorDeGasolina);
            Vehiculo v = VehiculoFactory.Create(TipoMotor.MOTOR_GASOLINA);
            Console.WriteLine("Revoluciones del motor de gasolina: " + v.GetRevolucionesMotor());

            Vehiculo v2 = VehiculoFactory.Create(TipoMotor.MOTOR_DIESEL);
            Console.WriteLine("Revoluciones del motor diesel: " + v2.GetRevolucionesMotor());
            Console.Read();
        }
    }
}
