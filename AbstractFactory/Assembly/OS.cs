namespace AbstractFactory
{
    /// <summary>
    /// 作業系統
    /// </summary>
    public class OS
    {
        public string partName;
    }



    public class Android : OS
    {
        public Android()  //系統
        {
            base.partName = "Android 2.1";
        }

        public Android(string type)  //系統語言
        {
            //這只是一個例子，相關的動態行為都可以設計到類別中
            if (type == "繁體")
                base.partName = "Android 2.1(繁)";
            else
                base.partName = "Android 2.1(簡)";
        }
    }


    public class WindowsMobile : OS
    {
        public WindowsMobile()  //系統
        {
            base.partName = "WindowsMobile 6.5";
        }

        public WindowsMobile(string type)  //系統語言
        {
            //這只是一個例子，相關的動態行為都可以設計到類別中
            if (type == "繁體")
                base.partName = "WindowsMobile 6.5(繁)";
            else
                base.partName = "WindowsMobile 6.0(簡)";
        }
    }
}