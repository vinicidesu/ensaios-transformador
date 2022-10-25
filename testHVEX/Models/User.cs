﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace testHVEX.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;

        [BsonElement("email")]
        public string Email { get; set; } = String.Empty;
    }
}
