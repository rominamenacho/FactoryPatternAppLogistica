using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternLogisticaDelivery
{
  abstract class Logistics
    {
        public void planDelivery() {
            ITransport t = createTransport();
       }
        public abstract ITransport createTransport();
    }
}
