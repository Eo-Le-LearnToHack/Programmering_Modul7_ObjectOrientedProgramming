using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oevelse7
{
    public class Vejr
    {

        public int SamletNedbør (Regn dag1, Regn dag2)
        {
            int total = dag1.Nedbør + dag2.Nedbør;
            return total;
        }
    }
}
