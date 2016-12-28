using System;
using System.Security.AccessControl;

namespace AbstractFactory
{
    public abstract class AbstractCellPhone
    {
        public string Name;
        protected OS os;
        protected Monitor monitor;
        protected USB usb;
        protected Wireless3G wireless3G;

        /// <summary>
        /// 設計
        /// </summary>
        public virtual void design()
        {
            Console.WriteLine("Doing Design Process");
        }

        /// <summary>
        /// 模組化
        /// </summary>
        public virtual void modeling()
        {
            Console.WriteLine("Doing Modeling Process");
        }

        /// <summary>
        /// 備料
        /// </summary>
        public abstract void prepareAssembly();

        /// <summary>
        /// 組裝
        /// </summary>
        public virtual void combine()
        {
            Console.WriteLine("Doing Combine Process");
        }

        //維持不變
        public virtual void box()
        {
            Console.WriteLine("doing Boxing Process....");
        }

        public string getName()
        {
            return Name;
        }
    }
}