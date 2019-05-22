using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Clients.Core.Model
{
    public class Address
    {
        [BsonElement]
        public string Street { get; set; }
        [BsonElement]
        public int Number { get; set; }
        [BsonElement]
        public string Neighborhood { get; set; }
        [BsonElement]
        public string ZipCode { get; set; }
        [BsonElement]
        public string City { get; set; }
        [BsonElement]
        public string State { get; set; }
        [BsonElement]
        public string Country { get; set;  }
    }
}
