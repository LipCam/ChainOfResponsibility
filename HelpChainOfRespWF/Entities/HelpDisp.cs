namespace HelpChainOfRespWF.Entities
{
    public class HelpDisp
    {
        public string Component { get; set; }
        public string Information { get; set; }

        public HelpDisp(string component)
        {
            Component = component;
        }
    }
}
