using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace testHVEX.Models
{
    public class Transformer : BaseModel
    {
        [BsonElement("internal_number")]
        public int Internal_Number { get; set; }

        [BsonElement("tension_class")]
        public string Tension_Class { get; set; } = String.Empty;

        [BsonElement("potency")]
        public int Potency { get; set; }

        [BsonElement("current")]
        public bool Current { get; set; }

    }
}
