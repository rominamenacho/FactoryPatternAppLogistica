using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternLogisticaDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Logistics logistic; 

            Console.WriteLine("Ingrese T para truck o S para ship");
            string varIngresada = Console.ReadLine();

            if (varIngresada == "T")
            {
                logistic = new RoadLogistics();
            }
            else
            {
                logistic = new SeaLogistics();
            
            }
            logistic.planDelivery();
          //logistic.createTransport();


            Console.ReadKey();

        }
    }
}
