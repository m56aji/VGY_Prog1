using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class InkomstInfo
    {
        public string Namn { get; set; }
        public int Inkomst { get; set; }
        public int Timmar { get; set; }

        public int Timlön { get { return Inkomst / Timmar; } }
    }
}
