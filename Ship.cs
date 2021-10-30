using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternLogisticaDelivery
{
   public class Ship : ITransport
    {

        public Ship() {
            this.Deliver();
        }
        public void Deliver()
        {
            Console.WriteLine("Entrego por mar");
        }
    }
}
