using NUnit.Framework;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace NUnitTestProject1
{
    public class AlarmTest
    {
        [Test]
        public void Test()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void CheckAlarm()
        {
            var alarm = BuildAlarmClass();

            alarm.Check();

            Assert.AreEqual(true, alarm.AlarmOn);
        }

        public Alarm BuildAlarmClass()
        {
            return new Alarm();
        }
    }
}