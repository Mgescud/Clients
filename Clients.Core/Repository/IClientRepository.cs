using System;
using System.Collections.Generic;
using System.Text;
using Clients.Core.Model;

namespace Clients.Core.Repository
{
    public interface IClientRepository
    {
        Client Get(Guid id);
        List<Client> GetAll();
        void Add(Client client);
        void Update(Guid id, Client client);
        void Remove(Guid id);
    }
}
