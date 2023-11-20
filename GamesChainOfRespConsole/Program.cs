using GamesChainOfRespConsole.Entities;
using GamesChainOfRespConsole.Handler;
using System.Data;

namespace GamesChainOfRespConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDataBaseHandler handler = new SqlServerHandler();
            handler.SetNext(new PostgresHandler())
                    .SetNext(new SqLiteHandler());

            DataBaseInfo dataBaseInfo = new DataBaseInfo();
            dataBaseInfo.Query = "SELECT * FROM tb_players";
            //dataBaseInfo.Query = "SELECT * FROM tb_players WHERE name like @name";
            //dataBaseInfo.lstQueryParameters = new List<QueryParameter>()
            //{
            //    new QueryParameter { ParameterName = "@name", DbType = DbTypeParameter.String, Value = "Da%" }
            //};

            handler.GetDataBaseInfo(dataBaseInfo);

            Console.WriteLine(dataBaseInfo.SourceDesc);
            if (dataBaseInfo.Data != null)
            {   
                foreach (DataRow dr in dataBaseInfo.Data.Rows)
                {
                    Console.WriteLine(dr[0].ToString() + "- " + dr[1].ToString());
                }
            }
            else
            {
                Console.WriteLine("No data");
                if (!string.IsNullOrEmpty(dataBaseInfo.ErrorMessage))
                {
                    Console.WriteLine("ErrorMessage:");
                    Console.WriteLine(dataBaseInfo.ErrorMessage);
                }
            }
        }
    }
}