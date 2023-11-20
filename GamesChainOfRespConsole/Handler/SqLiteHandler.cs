using GamesChainOfRespConsole.Entities;
using System.Data;
using System.Data.SQLite;

namespace GamesChainOfRespConsole.Handler
{
    public class SqLiteHandler : DataBaseHandler
    {
        public override void GetDataBaseInfo(DataBaseInfo dataBaseInfo)
        {
            string Erro = "";
            dataBaseInfo.SourceDesc = "Connected with SqLite";
            try
            {
                string _Path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\dslist.db";

                SQLiteConnection con = new SQLiteConnection($"Data Source={_Path}; Version=3;");
                DataTable dt = new DataTable();
                SQLiteDataAdapter adp = new SQLiteDataAdapter(dataBaseInfo.Query, con);

                if (dataBaseInfo.lstQueryParameters != null)
                {
                    foreach (var item in dataBaseInfo.lstQueryParameters)
                    {
                        DbType DbType = GetDbType(item.DbType);
                        adp.SelectCommand.Parameters.Add(item.ParameterName, DbType).Value = item.Value;
                    }
                }

                adp.Fill(dt);
                dataBaseInfo.Data = dt;
                dataBaseInfo.ErrorMessage = Erro;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    Erro = ex.InnerException.Message;
                else
                    Erro = ex.Message;

                dataBaseInfo.ErrorMessage = Erro;
                base.GetDataBaseInfo(dataBaseInfo);
            }
        }

        private DbType GetDbType(DbTypeParameter objDbType)
        {
            DbType sqlDbType = DbType.String;

            if (objDbType == DbTypeParameter.String)
                sqlDbType = DbType.String;
            else if (objDbType == DbTypeParameter.Int)
                sqlDbType = DbType.Int32;
            else if (objDbType == DbTypeParameter.Long)
                sqlDbType = DbType.Int64;
            else if (objDbType == DbTypeParameter.Decimal)
                sqlDbType = DbType.Decimal;
            else if (objDbType == DbTypeParameter.DateTime)
                sqlDbType = DbType.DateTime;
            else if (objDbType == DbTypeParameter.Bool)
                sqlDbType = DbType.Boolean;

            return sqlDbType;
        }
    }
}
