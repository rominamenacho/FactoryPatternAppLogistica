using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternLogisticaDelivery
{
    class RoadLogistics : Logistics
    {
        public override ITransport createTransport()
        {
            return new Truck();
        }

       
    }
}
