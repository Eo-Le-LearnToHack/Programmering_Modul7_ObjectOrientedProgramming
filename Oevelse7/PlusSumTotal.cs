using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oevelse7
{
    internal class PlusSumTotal
    {
        private double Total;

        public void Plus_met(double tal)
        {
            Total += tal;
        }

        public double Sum_met()
        {
            return Total;
        }
    }
}
