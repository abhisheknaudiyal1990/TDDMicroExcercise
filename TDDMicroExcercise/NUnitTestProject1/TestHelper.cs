
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDMicroExcercise.TirePressureMonitoringSystem;
using TDDMicroExcercise.TirePressureMonitoringSystem.Contracts;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TDDMicroExcercise.Tests
{

    public class TestHelper
    {
        private ISensor _sensor;
        private IPressureRange _pressureRange;

        public static TestHelper ObjectAlarm()
        {
            return new TestHelper();
        }

        public Alarm BuildAlarmClass()
        {
            return new Alarm(_sensor, _pressureRange);
        }

        public TestHelper WithReadPressure(double measure)
        {
            var sensorMock = new Mock<ISensor>();
            sensorMock.Setup(s => s.MeasurePressure()).Returns(measure);
            _sensor = sensorMock.Object;
            return this;
        }

        public TestHelper SafetyRange(double lowerLimit, double upperLimit)
        {
            _pressureRange = new PressureRange(lowerLimit, upperLimit);
            return this;
        }
    }
}
