using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class caBusinessCellPhone : AbstractCellPhone
    {
        private ICellPhoneAssemblyFactory cellPhoneAssemblyFactory;

        public caBusinessCellPhone(ICellPhoneAssemblyFactory customCellPhoneAssemblyFactory)
        {
            this.cellPhoneAssemblyFactory = customCellPhoneAssemblyFactory;
        }

        /// <summary>
        /// 特殊零組件
        /// </summary>
        public override void prepareAssembly()
        {
            //神奇的事情發生在這邊
            Console.WriteLine("Preparing Assembly:" + Name);
            usb = cellPhoneAssemblyFactory.PrepareUsb();
            os = cellPhoneAssemblyFactory.InstallOs();
            monitor = cellPhoneAssemblyFactory.PrepareMonitor();
            wireless3G = cellPhoneAssemblyFactory.PrepareWireless3G();
        }
    }
}
