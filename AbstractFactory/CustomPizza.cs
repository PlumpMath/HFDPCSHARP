using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CheesePizza : Pizza
    {
        IIngredientFactory ingredientFactory;

        public CheesePizza(IIngredientFactory customIngredientFactory)
        {
            this.ingredientFactory = customIngredientFactory;
        }


        public override void Prepare()
        {
            dough = this.ingredientFactory.CreateDough();
            sauce = this.ingredientFactory.CreateSauce();
            cheese = this.ingredientFactory.CreateCheese();
            Console.WriteLine("Making custom cheese pizza.");
            Console.WriteLine(dough.partname);
            Console.WriteLine(sauce.partname);
            Console.WriteLine(cheese.partname);
        }
    }

    class ClamPizza : Pizza
    {
        IIngredientFactory ingredientFactory;

        public ClamPizza(IIngredientFactory customIngredientFactory)
        {
            this.ingredientFactory = customIngredientFactory;
        }

        public override void Prepare()
        {
            dough = this.ingredientFactory.CreateDough();
            sauce = this.ingredientFactory.CreateSauce();
            cheese = this.ingredientFactory.CreateCheese();
            Console.WriteLine("Making custom sea-creature pizza.");
            this.ingredientFactory.CreateDough();
            this.ingredientFactory.CreateSauce();
            this.ingredientFactory.CreateCheese();
        }
    }

    class ShoePizza : Pizza
    {
        IIngredientFactory ingredientFactory;

        public ShoePizza(IIngredientFactory customIngredientFactory)
        {
            this.ingredientFactory = customIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Making custom orthopedic pizza.");
            this.ingredientFactory.CreateDough();
            this.ingredientFactory.CreateSauce();
            this.ingredientFactory.CreateCheese();
        }
    }
}
