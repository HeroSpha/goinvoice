using GoInvoice.MobileAppService.Core.Interface;
using GoInvoice.MobileAppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoInvoice.MobileAppService.Core.Repository
{
    public class ClientRepository : IClientRepository
    {
        public Task<Client> AddClientAsync(Client client)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteClientAsync(int clientId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GetClientsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Client> UpdateClientAsync(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
