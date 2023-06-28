using Moq;
using NUnit.Framework;
using TDDMicroExcercise.TirePressureMonitoringSystem.Contracts;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TDDMicroExcercise.Tests
{
    public class AlarmTest
    {
        [Test]
        public void Test()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void CheckAlarmIsOnWhenPressureIs10()
        {
            var alarm = TestHelper.ObjectAlarm().WithReadPressure(10).SafetyRange(17,21).BuildAlarmClass();
            alarm.Check();
            Assert.AreEqual(true, alarm.AlarmOn);
        }

        [Test]
        public void CheckAlarmIsOnWhenPressureIs15()
        {
            var alarm = TestHelper.ObjectAlarm().WithReadPressure(15).SafetyRange(17, 21).BuildAlarmClass();

            alarm.Check();

            Assert.AreEqual(true, alarm.AlarmOn);
        }

        [Test]
        public void CheckAlarmIsOnWhenPressureIs18()
        {
            var alarm = TestHelper.ObjectAlarm().WithReadPressure(18).SafetyRange(17, 21).BuildAlarmClass();

            alarm.Check();

            Assert.AreEqual(false, alarm.AlarmOn);
        }

        [Test]
        public void CheckAlarmIsOnWhenPressureIs23()
        {
            var alarm = TestHelper.ObjectAlarm().WithReadPressure(23).SafetyRange(17, 21).BuildAlarmClass();

            alarm.Check();

            Assert.AreEqual(true, alarm.AlarmOn);
        }
    }
}