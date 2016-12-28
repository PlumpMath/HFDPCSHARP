using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FactoryMethod.Original
{
    public class TaiwanPizzaStore : PizzaStore
    {
        /// <summary>
        /// 實作製造比薩的抽象方法
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "Cheese")
            {
               pizza = new TaiwanStyleCheeePizza();
            }
            else if (type == "Clam")
            {
                pizza = new TaiwanStyleClamPizza();
            }
            return pizza;
        }
    }
}
