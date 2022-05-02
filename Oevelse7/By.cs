using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oevelse7
{
    public class By
    {

        private string Navn;
        private int Indbyggerantal;

        public By(string navn)
        {
            Navn = navn;
        }

        public By(string navn, int indbyggerantal)
        {
            Navn = navn;
            Indbyggerantal = indbyggerantal;

        }
    }
}
