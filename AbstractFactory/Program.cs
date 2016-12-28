using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Store;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 比薩店範例
            AbstractPizzaStore store = new PortlandPizzaStore();
            store.OrderPizza("Cheese");
            store = new HillsboroPizzaStore();
            store.OrderPizza("Clam");
            store = new TaiwanPizzaStore();
            store.OrderPizza("Cheese");
            #endregion


            #region 手機銷售範例
            AbstractCellPhoneStore Cellstore = new TaiwanCellPhoneStore();
            Cellstore.OrderCenllPhone("Business");


            #endregion
        }
    }

}
