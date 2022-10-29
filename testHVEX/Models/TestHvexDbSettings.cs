using MongoDB.Driver;

namespace testHVEX.Models
{
    public class HvexTestDbSettings
    {
        public string? ConnectionString { get; set; }
        public string DatabaseName { get; set; } = String.Empty;
        public string CollectionName { get; set; } = String.Empty;
    }
}
