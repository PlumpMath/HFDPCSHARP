using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// 飲料超類別
    /// </summary>
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        /// <summary>
        /// 取得描述
        /// </summary>
        /// <returns></returns>
        public virtual string GetDescription()
        {
            return this.description;
        }

        /// <summary>
        /// 取得花費
        /// </summary>
        /// <returns></returns>
        public abstract double GetCost();
    }

    public class AfricanBlend : Beverage
    {
        public AfricanBlend()
        {
            this.description = "AfricanBlend";
        }

        public override double GetCost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.description = "House Blend";
        }

        public override double GetCost()
        {
            return 0.89;
        }
    }

    /// <summary>
    /// 裝飾者抽象類別
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDescription();
    }


    /// <summary>
    /// 裝飾者具象類別
    /// </summary>
    public class Cream : CondimentDecorator
    {
        Beverage beverage;

        public Cream(Beverage newBeverage)
        {
            this.beverage = newBeverage;
        }

        /// <summary>
        /// 由於是Virtual可複寫或可不複寫 超類別本身已經有方法了~
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            return this.beverage.GetDescription() + ", Cream " +
                this.GetCost();
        }

        public override double GetCost()
        {
            return 0.20 + this.beverage.GetCost();
        }
    }
}
