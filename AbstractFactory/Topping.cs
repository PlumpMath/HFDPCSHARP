using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 麵團
    /// </summary>
    public class Dough
    {
        public string partname;
    }
    /// <summary>
    /// 醬料
    /// </summary>
    public class Sauce
    {
        public string partname;
    }
    /// <summary>
    /// 起司
    /// </summary>
    public class Cheese
    {
        public string partname;
    }

    public class MegaDough : Dough
    {
        public MegaDough()
        {
            base.partname = "SuperTaiwanDough";
        }

        public MegaDough(string Type)
        {
            if (Type == "台南")
            {
                base.partname = "南部麵團";
            }
            else
            {
                base.partname = "北部麵團";
            }
        }
    }

    public class GigaDough : Dough
    {
        public GigaDough()
        {
            base.partname = "SuperChinaDough";
        }

        public GigaDough(string type)
        {
            if (type == "北京")
            {
                base.partname = "京都風味麵團";
            }
            else
            {
                base.partname = "外鍋風味麵團";
            }
        }
    }

    public class MegaCheese : Cheese
    {
        public MegaCheese()
        {
            base.partname = "正宗台灣起司";
        }

        public MegaCheese(string Type)
        {
            if (Type == "台北")
            {
                base.partname = "北部起司";
            }
            else
            {
                base.partname = "南部起司";
            }
        }
    }

    public class GigaCheese : Cheese
    {
        public GigaCheese()
        {
            base.partname = "正宗大陸起司";
        }

        public GigaCheese(string Type)
        {
            if (Type == "北京")
            {
                base.partname = "官方起司";
            }
            else
            {
                base.partname = "民間起司";
            }
        }
    }


    public class MegaSauce: Sauce
    {
        public MegaSauce()
        {
            base.partname = "正宗大陸醬料";
        }

        public MegaSauce(string Type)
        {
            if (Type == "台北")
            {
                base.partname = "台北官方醬料";
            }
            else
            {
                base.partname = "台灣民間醬料";
            }
        }
    }

    public class GigaSauce: Sauce
    {
        public GigaSauce()
        {
            base.partname = "正宗大陸醬料";
        }

        public GigaSauce(string Type)
        {
            if (Type == "北京")
            {
                base.partname = "北京官方醬料";
            }
            else
            {
                base.partname = "大陸民間醬料";
            }
        }
    }
}
