using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;



namespace MissyMenuAPI.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Recipes>(myJsonResponse);
    public class Id
    {
        [JsonPropertyName("$oid")]
        public string Oid { get; set; }
    }

    public class Ingredient
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("measurement")]
        public string Measurement { get; set; }

        [JsonPropertyName("pork is best")]
        public string PorkIsBest { get; set; }
    }

    public class Recipes
    {
        [JsonPropertyName("_id")]
        public Id Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("ingredients")]
        public List<Ingredient> Ingredients { get; set; }
    }

