using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IIngredientFactory
    {
       Dough CreateDough();
       Sauce CreateSauce();
       Cheese CreateCheese();
    }


    public class PortlandIngredientFactory : IIngredientFactory
    {
        #region IngredientFactory Members

        public Dough CreateDough()
        {
            Console.WriteLine("Portland");
            return new Dough();
        }

        public Sauce CreateSauce()
        {
            Console.WriteLine("Portland");
            return new Sauce();
        }

        public Cheese CreateCheese()
        {
            Console.WriteLine("Portland");
            return new Cheese();
        }

        #endregion
    }

    public class HillsboroIngredientFactory : IIngredientFactory
    {
        #region IngredientFactory Members

        public Dough CreateDough()
        {
            Console.WriteLine("Hillsboro");
            return new Dough();
        }

        public Sauce CreateSauce()
        {
            Console.WriteLine("Hillsboro");
            return new Sauce();
        }

        public Cheese CreateCheese()
        {
            Console.WriteLine("Hillsboro");
            return new Cheese();
        }

        #endregion
    }


    public class TaiwanIngredientFactory : IIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return  new MegaCheese("台北");
        }

        public Dough CreateDough()
        {
           return  new MegaDough("台北");
        }

        public Sauce CreateSauce()
        {
            return  new MegaSauce("台北");
        }
    }

    public class ChinaIngredientFactory : IIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new GigaCheese("台北");
        }

        public Dough CreateDough()
        {
            return new GigaDough("台北");
        }

        public Sauce CreateSauce()
        {
            return new GigaSauce("台北");
        }
    }

}
