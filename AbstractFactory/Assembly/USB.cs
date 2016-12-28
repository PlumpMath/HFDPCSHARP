namespace AbstractFactory
{
    public class USB
    {
        public string partName;
    }

    public class normalUSB : USB
    {
        public normalUSB()
        {
            base.partName = "一般USB插口";
        }
    }

    public class miniUSB : USB
    {
        public miniUSB()
        {
            base.partName = "miniUSB插口";
        }
    }
}