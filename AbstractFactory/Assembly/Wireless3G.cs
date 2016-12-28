using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Wireless3G
    {
        public string partName;
    }

    public class WCDMA : Wireless3G
    {
        public WCDMA()
        {
           base.partName = "WCDMA 3g模組";
        }
    }
 
    public class TD_SCDMA : Wireless3G
    {
        public TD_SCDMA()
        {
           base.partName = "TD-SCDMA 3g模組";
        }
    }
}
