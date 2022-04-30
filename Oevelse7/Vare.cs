using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oevelse7
{
    public class Vare
    {

        public string Navn { get; set; }
        public double Pris { get; set; }

        public void Udskriv()
        {
            Console.WriteLine($"Varen er {Navn} og koster {Pris:C2}");
        }

    }
}
