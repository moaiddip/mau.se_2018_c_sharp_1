using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    class MathOperations
    {
        private readonly bool corporativeMath;
        private readonly int corporativeMathFactor;

        public MathOperations(bool corporativeMath)
        {
            this.corporativeMath = corporativeMath;
        }

        private double corporativeMathFactorValue()
        {
            Random ran = new Random();
            return (ran.NextDouble() * corporativeMathFactor) * (1000.00 - 50.00) + 50.00;
        }
    }
}
