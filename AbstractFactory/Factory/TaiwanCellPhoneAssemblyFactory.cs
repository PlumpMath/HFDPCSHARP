using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AbstractFactory
{
    public class TaiwanCellPhoneAssemblyFactory : ICellPhoneAssemblyFactory
    {
        public OS InstallOs()
        {
            return new Android("繁體");
        }

        public Monitor PrepareMonitor()
        {
          return  new capacitiveMonitor();
        }

        public USB PrepareUsb()
        {
            return  new miniUSB();
        }

        public Wireless3G PrepareWireless3G()
        {

            return new WCDMA(); 
        }
    }
}
