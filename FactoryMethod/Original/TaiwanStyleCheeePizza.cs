using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FactoryMethod.Original
{
    public class TaiwanStyleCheeePizza : Pizza
    {
        public TaiwanStyleCheeePizza()
        {
            name = "台式比薩";
            dough = "發酵麵糰";
            sauce = "大同醬油";
            toppings.Add("蔥");
            toppings.Add("醋");
        }

        /// <summary>
        /// 複寫台灣起司比薩的準備法
        /// </summary>
        public override void Prepare()
        {
            Console.WriteLine(name);
            Console.WriteLine(dough);
            Console.WriteLine(sauce);
            Console.WriteLine("Making custom Taiwan style cheese pizza.");
        }

        /// <summary>
        /// 複寫台灣起司比薩的烘培法
        /// </summary>
        public override void Bake()
        {
            base.Bake();
        }

        /// <summary>
        /// 台灣裁切法
        /// </summary>
        public override void Cut()
        {
            base.Cut();
        }

        /// <summary>
        /// 台灣包箱法
        /// </summary>
        public override void Box()
        {
            base.Box();
        }
    }
}
