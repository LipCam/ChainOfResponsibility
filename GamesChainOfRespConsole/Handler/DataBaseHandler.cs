using GamesChainOfRespConsole.Entities;

namespace GamesChainOfRespConsole.Handler
{
    public interface IDataBaseHandler
    {
        IDataBaseHandler SetNext(IDataBaseHandler dataBaseHandler);
        void GetDataBaseInfo(DataBaseInfo dataBaseInfo);
    }

    public class DataBaseHandler : IDataBaseHandler
    {
        IDataBaseHandler nextDataBaseHandler;

        public IDataBaseHandler SetNext(IDataBaseHandler dataBaseHandler)
        {
            nextDataBaseHandler = dataBaseHandler;
            return dataBaseHandler;
        }

        public virtual void GetDataBaseInfo(DataBaseInfo dataBaseInfo)
        {
            if(nextDataBaseHandler != null)
                nextDataBaseHandler.GetDataBaseInfo(dataBaseInfo);
        }
    }
}
