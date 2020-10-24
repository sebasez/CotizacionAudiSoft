using Cotizacion.DAL;
using Cotizacion.Entities;
using Cotizacion.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotizacion.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly CotizacionDbContext context;
        public ClientRepository(CotizacionDbContext context)
        {
            this.context = context;
        }
        public Client GetClient(int id)
        {
            return context.Clients.Find(id);
        }

        public IList<Client> GetClients()
        {
            return context.Clients.ToList();
        }
    }
}
