
namespace InversionOfControlMotor
{
    public class Vehiculo
    {
        private IMotor m;

        public IMotor Motor{
            get { return m; }
            set { m = value; }
        }

        public Vehiculo(IMotor motor)
        {
            m = motor;
        }

        public int GetRevolucionesMotor()
        {
            if (m != null)
                return m.GetRevoluciones();
            else
                return -1;
        }
    }
}
