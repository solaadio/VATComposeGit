using System.Collections.Generic;
using Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Repository.Implementation
{
    public class RatesBson
    {
        public ObjectId Id { get; set; }

        [BsonElement("rates")]
        public List<CountryRates> Rates { get; set; }

        [BsonElement("version")]
        public double Version { get; set; }
    }
}