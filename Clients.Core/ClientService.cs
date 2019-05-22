using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Clients.Core.Model;
using Clients.Core.Repository;


namespace Clients.Core
{
    public class ClientService
    {
        private IClientRepository clientRepository;

        private bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        private bool ValidateFone(string fone)
        {
            return Regex.IsMatch(fone, @"^(\([0 - 9]{ 2}\))\s([9]{ 1})?([0 - 9]{ 4})-([0 - 9]{ 4})$", RegexOptions.IgnoreCase);
        }

        public ClientService(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public void Add(Client client)
        {
            if (!ValidateEmail(client.Email))
                throw new Exception("Invalid Email");
            if (!ValidateFone(client.Fone))
                throw new Exception("Invalid Fone");
            clientRepository.Add(client);
        }

        public void Update(Client client)
        {
            clientRepository.Update(client.Id, client);
        }

        public void Delete(Client client)
        {
            clientRepository.Remove(client.Id);
        }

        public Client ListById(Guid id)
        {
            return clientRepository.Get(id);
        }

        public List<Client> ListAll()
        {
            return clientRepository.GetAll();
        }
    }
}
