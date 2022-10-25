using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace testHVEX.Models
{
    public class Report : BaseModel
    {
        [BsonElement("status")]
        public string Status { get; set; } = String.Empty;
    }
}
