using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauTrade
{
    public class Trade : ITrade
    {
        public double Value { get; set; }
        public SectorType ClientSector { get; set; }
    }
}
