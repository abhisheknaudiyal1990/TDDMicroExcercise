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
            var sensorMock = new Mock<ISensor>();
            sensorMock.Setup(s => s.MeasurePressure()).Returns(22);
            _sensor = sensorMock.Object;
            var alarm = TestHelper.ObjectAlarm().BuildAlarmClass(_sensor);
            alarm.Check();
            Assert.AreEqual(true, alarm.AlarmOn);
        }
    }
}