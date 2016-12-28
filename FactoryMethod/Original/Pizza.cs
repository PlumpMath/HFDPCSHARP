using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /// <summary>
    /// 比薩的抽象類別
    /// </summary>
    public abstract class Pizza
    {
        /// <summary>
        /// 名稱
        /// </summary>
        protected string name;

        /// <summary>
        /// 麵團型態
        /// </summary>
        protected string dough;

        /// <summary>
        /// 醬汁型態
        /// </summary>
        protected string sauce;

        /// <summary>
        /// 餡料組
        /// </summary>
        protected ArrayList toppings = new ArrayList();

        /// <summary>
        /// 準備方法
        /// </summary>
        public virtual void Prepare()
        {

            Console.WriteLine("Standard preparation technique.");
        }

        /// <summary>
        /// 烹調方法
        /// </summary>
        public virtual void Bake()
        {
            Console.WriteLine("Standard baking technique.");
        }

        /// <summary>
        /// 切法
        /// </summary>
        public virtual void Cut()
        {
            Console.WriteLine("Standard cutting technique.");
        }

        /// <summary>
        /// 包裝方法
        /// </summary>
        public virtual void Box()
        {
            Console.WriteLine("Standard boxing technique.");
        }
    }
}
