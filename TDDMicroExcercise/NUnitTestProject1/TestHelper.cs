
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDMicroExcercise.TirePressureMonitoringSystem.Contracts;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TDDMicroExcercise.Tests
{

    public class TestHelper
    {
        public static TestHelper ObjectAlarm()
        {
            return new TestHelper();
        }

        public Alarm BuildAlarmClass(ISensor _sensor)
        {
            return new Alarm(_sensor);
        }
    }
}
