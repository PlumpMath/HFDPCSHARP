using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod;
using FactoryMethod.Original;

namespace FactoryMethod
{
    class PizzaTestDrive
    {
        static void Main(string[] args)
        {
          PizzaStore MyStore = new TaiwanPizzaStore();
            MyStore.OrderPizza("Cheese");
        }
    }
}
