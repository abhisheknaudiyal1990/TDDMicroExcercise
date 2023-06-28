using TDDMicroExcercise.TirePressureMonitoringSystem.Contracts;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private readonly ISensor _sensor;
        private readonly IPressureRange _pressureRange;

        bool _alarmOn = false;

        public Alarm(ISensor sensor, IPressureRange pressureRange)
        {
            _sensor = sensor;
            _pressureRange = pressureRange;
        }

        public void Check()
        {
            double psiPressureValue = _sensor.MeasurePressure();
            _alarmOn = _pressureRange.IsPressureWithinSafeRange(psiPressureValue);
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }
    }
}
