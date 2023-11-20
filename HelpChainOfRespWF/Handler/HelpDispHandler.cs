using HelpChainOfRespWF.Entities;

namespace HelpChainOfRespWF.Handler
{
    public interface IHelpDispHandler
    {
        IHelpDispHandler SetNext(IHelpDispHandler helpDispHandler);
        void ShowHelpInfo(HelpDisp helpDisp);
    }

    public abstract class HelpDispHandler : IHelpDispHandler
    {
        IHelpDispHandler nextHelpDispHandler;

        public IHelpDispHandler SetNext(IHelpDispHandler helpDispHandler)
        {
            nextHelpDispHandler = helpDispHandler;
            return helpDispHandler;
        }

        public virtual void ShowHelpInfo(HelpDisp helpDisp)
        {
            if (nextHelpDispHandler != null)
                nextHelpDispHandler.ShowHelpInfo(helpDisp);
        }
    }
}
