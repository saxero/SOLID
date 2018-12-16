
namespace InversionOfControlMotor
{
    public class MotorGasolina:IMotor
    {
        public void Acelerar()
        {
            RealizarAdmision();
            RealizarCompresion();
            RealizarCombustion();   // Propia del motor diesel
            RealizarEscape();
        }

        public int GetRevoluciones()
        {
            int currentRPM = 5000;

            // ...

            return currentRPM;
        }

        private void RealizarAdmision() { /* ... */ }
        private void RealizarCompresion() { /* ... */ }
        private void RealizarCombustion() { /* ... */ }
        private void RealizarEscape() { /* ... */ }
    }
}
