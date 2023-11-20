namespace GamesChainOfRespConsole.Entities
{
    public enum DbTypeParameter
    {
        String = 0,
        Int = 1,
        Long = 2,
        Decimal = 3,
        DateTime = 4,
        Bool = 5,
    }

    public class QueryParameter
    {
        public string ParameterName { get; set; }
        public DbTypeParameter DbType { get; set; }
        public object Value { get; set; }
    }
}
