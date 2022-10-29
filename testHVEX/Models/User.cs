using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace testHVEX.Models
{
    public class User : BaseModel
    {
        [BsonElement("email")]
        public string Email { get; set; } = String.Empty;

        [BsonElement("transformer")]
        Transformer? Transformer { get; set; }
    }
}
