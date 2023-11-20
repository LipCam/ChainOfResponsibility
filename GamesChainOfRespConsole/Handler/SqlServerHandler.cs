using GamesChainOfRespConsole.Entities;
using System.Data;
using System.Data.SqlClient;

namespace GamesChainOfRespConsole.Handler
{
    public class SqlServerHandler : DataBaseHandler
    {
        public override void GetDataBaseInfo(DataBaseInfo dataBaseInfo)
        {
            string Erro = "";
            dataBaseInfo.SourceDesc = "Connected with Sql Server";
            try
            {
                SqlConnection con = new SqlConnection("Data source=FILIPE-PC\\FILIPEPC;initial catalog=dslist;persist security info=True;user id=sa;password=lip");
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(dataBaseInfo.Query, con);

                if (dataBaseInfo.lstQueryParameters != null)
                {
                    foreach (var item in dataBaseInfo.lstQueryParameters)
                    {
                        SqlDbType DbType = GetDbType(item.DbType);
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

        private SqlDbType GetDbType(DbTypeParameter objDbType)
        {
            SqlDbType sqlDbType = SqlDbType.VarChar;

            if (objDbType == DbTypeParameter.String)
                sqlDbType = SqlDbType.VarChar;
            else if (objDbType == DbTypeParameter.Int)
                sqlDbType = SqlDbType.Int;
            else if (objDbType == DbTypeParameter.Long)
                sqlDbType = SqlDbType.BigInt;
            else if (objDbType == DbTypeParameter.Decimal)
                sqlDbType = SqlDbType.Decimal;
            else if (objDbType == DbTypeParameter.DateTime)
                sqlDbType = SqlDbType.DateTime;
            else if (objDbType == DbTypeParameter.Bool)
                sqlDbType = SqlDbType.Bit;

            return sqlDbType;
        }
    }
}
