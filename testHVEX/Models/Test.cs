using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace testHVEX.Models
{
    public class Test : BaseModel
    {
        [BsonElement("status")]
        public string Status { get; set; } = String.Empty;

        [BsonElement("duration_in_seconds")]
        public decimal Duration_In_Seconds { get; set; }
    }
}
