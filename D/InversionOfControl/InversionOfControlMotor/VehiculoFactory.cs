using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControlMotor
{
    public class VehiculoFactory
    {
        public static Vehiculo Create(TipoMotor tipoMotor){
            Vehiculo v = null;
            switch (tipoMotor)
            {
                case TipoMotor.MOTOR_DIESEL:
                    v = new Vehiculo(new MotorDiesel());
                    break;
                case TipoMotor.MOTOR_GASOLINA:
                    v = new Vehiculo(new MotorGasolina());
                    break;
                default:
                    break;
            }
            return v;
        }
    }
}
