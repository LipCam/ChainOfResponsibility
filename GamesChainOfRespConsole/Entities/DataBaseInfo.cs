using System.Data;

namespace GamesChainOfRespConsole.Entities
{
    public class DataBaseInfo
    {
        public string SourceDesc { get; set; }
        public string Query { get; set; }
        public List<QueryParameter> lstQueryParameters { get; set; }
        public DataTable Data { get; set; }
        public string ErrorMessage { get; set; }
    }
}
