using Moq;
using NUnit.Framework;
using TDDMicroExcercise.TirePressureMonitoringSystem.Contracts;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TDDMicroExcercise.Tests
{
    public class AlarmTest
    {
        private ISensor _sensor;

        [Test]
        public void Test()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void CheckAlarmIsOnWhenPressureIs22()
        {
            var alarm = TestHelper.ObjectAlarm().WithSensorDetecting(22).SafetyRange(17,21).BuildAlarmClass();
            alarm.Check();
            Assert.AreEqual(true, alarm.AlarmOn);
        }
    }
}