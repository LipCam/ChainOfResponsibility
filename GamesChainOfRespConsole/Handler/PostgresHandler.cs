using GamesChainOfRespConsole.Entities;
using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace GamesChainOfRespConsole.Handler
{
    public class PostgresHandler : DataBaseHandler
    {
        public override void GetDataBaseInfo(DataBaseInfo dataBaseInfo)
        {
            string Erro = "";
            dataBaseInfo.SourceDesc = "Connected with Postgres";
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=dslist;User Id=postgres;Password=123;");
                DataTable dt = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(dataBaseInfo.Query, con);

                if (dataBaseInfo.lstQueryParameters != null)
                {
                    foreach (var item in dataBaseInfo.lstQueryParameters)
                    {
                        NpgsqlDbType DbType = GetDbType(item.DbType);
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

        private NpgsqlDbType GetDbType(DbTypeParameter objDbType)
        {
            NpgsqlDbType sqlDbType = NpgsqlDbType.Varchar;

            if (objDbType == DbTypeParameter.String)
                sqlDbType = NpgsqlDbType.Varchar;
            else if (objDbType == DbTypeParameter.Int)
                sqlDbType = NpgsqlDbType.Integer;
            else if (objDbType == DbTypeParameter.Long)
                sqlDbType = NpgsqlDbType.Bigint;
            else if (objDbType == DbTypeParameter.Decimal)
                sqlDbType = NpgsqlDbType.Numeric;
            else if (objDbType == DbTypeParameter.DateTime)
                sqlDbType = NpgsqlDbType.TimestampTZ;
            else if (objDbType == DbTypeParameter.Bool)
                sqlDbType = NpgsqlDbType.Boolean;

            return sqlDbType;
        }
    }
}
