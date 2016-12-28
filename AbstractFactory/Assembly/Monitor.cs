namespace AbstractFactory
{
    public class Monitor
    {
        public string partName;
    }

    public class capacitiveMonitor : Monitor
    {
        public capacitiveMonitor()  //電容式
        {
            base.partName = "CapacitiveMonitor電容式";
        }
    }

    public class resistanceMonitor : Monitor
    {
        public resistanceMonitor()  //電阻式
        {
            base.partName = "ResistanceMonitor電阻式";
        }
    }
}