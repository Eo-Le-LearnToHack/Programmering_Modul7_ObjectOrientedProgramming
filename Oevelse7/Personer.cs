using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oevelse7
{
    internal class Personer
    {
        public string Navn { get; set; }
        public string Email { get; set; }

        public void Udskriv()
        {
            Console.WriteLine($"Personen hedder {Navn} og email-adressen er {Email}");
        }

       
    }
}
