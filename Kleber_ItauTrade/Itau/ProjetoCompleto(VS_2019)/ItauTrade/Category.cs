using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauTrade
{
    public class Category : ICategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public OperatorType Operator { get; set; }
        public double BaseValue { get; set; }
        public SectorType Sector { get; set; }
    }
}
