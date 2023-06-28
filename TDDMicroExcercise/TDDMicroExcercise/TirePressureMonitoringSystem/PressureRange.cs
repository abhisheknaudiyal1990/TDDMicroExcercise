using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDMicroExcercise.TirePressureMonitoringSystem.Contracts;

namespace TDDMicroExcercise.TirePressureMonitoringSystem
{
    public class PressureRange: IPressureRange
    {
        private double _lowerLimit;
        private double _upperLimit;

        public PressureRange(double lowerLimit, double upperLimit)
        {
            _lowerLimit = lowerLimit;
            _upperLimit = upperLimit;
        }

        public bool IsPressureWithinSafeRange(double measure)
        {
            if (measure < _lowerLimit || _upperLimit < measure)
            {
                return true;
            }
            return false;
        }
    }
}
