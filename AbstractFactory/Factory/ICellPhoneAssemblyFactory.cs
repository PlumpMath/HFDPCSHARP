using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 手機零組件介面
    /// </summary>
    public interface ICellPhoneAssemblyFactory
    {
        /// <summary>
        /// 安裝作業系統
        /// </summary>
        /// <returns></returns>
        OS InstallOs();

        /// <summary>
        /// 準備USB組件
        /// </summary>
        /// <returns></returns>
        USB PrepareUsb();
        /// <summary>
        /// 準備螢幕組件
        /// </summary>
        /// <returns></returns>
        Monitor PrepareMonitor();

        /// <summary>
        /// 準備無限三G模組
        /// </summary>
        /// <returns></returns>
        Wireless3G PrepareWireless3G();
    }
}
