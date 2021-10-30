using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternLogisticaDelivery
{
  public  class Truck : ITransport
    {

        public Truck()
        {
            this.Deliver();
        }
        public void Deliver()
        {
           Console.WriteLine("Entrego por tierra");
        }
    }
}
