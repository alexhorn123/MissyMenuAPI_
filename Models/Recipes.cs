using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;



namespace MissyMenuAPI.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Recipes>(myJsonResponse);
public class Id
    {
        [JsonPropertyName("$oid")]
        public string Oid { get; set; }
    }

    public class Ingredient
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("measurement")]
        public string Measurement { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }
    }

    public class Recipes
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonPropertyName("_id")]
        public Id Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("ingredients")]
        public List<Ingredient> Ingredients { get; set; }
    }

