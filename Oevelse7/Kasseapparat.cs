using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oevelse7
{
    public class Kasseapparat
    {
        public void Udskriv(Vare[] varer)
        {
            foreach(Vare v in varer) 
                {

                v.Udskriv();
            }
            

        }

    }
}
