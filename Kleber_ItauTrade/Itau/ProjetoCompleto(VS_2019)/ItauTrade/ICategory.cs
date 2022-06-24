using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauTrade
{
    public interface ICategory
    {
        int ID { get; set; }
        string Name { get; set; }
        OperatorType Operator { get; set; }
        double BaseValue { get; set; }
        SectorType Sector { get; set; }
    }
}
