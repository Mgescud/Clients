using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Clients.Core.Model
{
    public class Client
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public List<Address> Addresses { get; set; }
        [BsonElement]
        public string Email { get; set; }
        [BsonElement]
        public string Fone { get; set; }


    }
}
