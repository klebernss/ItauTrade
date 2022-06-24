using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauTrade
{
    interface ITrade
    {
        double Value { get; }
        SectorType ClientSector { get; }
    }
}
