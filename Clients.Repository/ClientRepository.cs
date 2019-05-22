using System;
using MongoDB.Driver;
using Clients.Core;
using Clients.Core.Repository;
using Clients.Core.Model;
using System.Collections.Generic;

namespace Clients.Repository
{
    public class ClientRepositoy : IClientRepository
    {
        private readonly IMongoCollection<Client> _client;

        public ClientRepositoy()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Clients");
            _client = database.GetCollection<Client>("Client");
        }

        public void Add(Client client)
        {
            _client.InsertOne(client);
        }

        public Client Get(Guid id)
        {
            return _client.Find<Client>(x => x.Id == id).FirstOrDefault();
        }

        public List<Client> GetAll()
        {
            return _client.Find<Client>(x => true).ToList<Client>();
        }

        public void Remove(Guid id)
        {
            _client.DeleteOne<Client>(x => x.Id == id);
        }

        public void Update(Guid id, Client client)
        {
            _client.ReplaceOne(x => x.Id == id, client);
        }
    }
}
