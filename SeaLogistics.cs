using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternLogisticaDelivery
{
    class SeaLogistics : Logistics
    {
        public override ITransport createTransport()
        {
            return new Ship();
        }

      
    }
}
