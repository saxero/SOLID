
namespace InversionOfControlMotor
{
    public class MotorDiesel:IMotor
    {
        public void Acelerar()
        {
            RealizarAdmision();
            RealizarCompresion();
            RealizarEscape();
        }

        public int GetRevoluciones()
        {
            int currentRPM = 3400;

            // ...

            return currentRPM;
        }

        private void RealizarAdmision() { /* ... */ }
        private void RealizarCompresion() { /* ... */ }
        private void RealizarEscape() { /* ... */ }
    }
}
