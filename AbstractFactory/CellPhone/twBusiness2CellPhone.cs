using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class twBusiness2CellPhone : AbstractCellPhone
    {
        ICellPhoneAssemblyFactory cellPhoneAssemblyFactory;

        public twBusiness2CellPhone()
        {
            base.Name = "Taiwan Business2 SmartPhone";
        }

        public twBusiness2CellPhone(ICellPhoneAssemblyFactory cutomCellPhoneAssemblyFactory)
        {
            this.cellPhoneAssemblyFactory = cutomCellPhoneAssemblyFactory;
        }
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
