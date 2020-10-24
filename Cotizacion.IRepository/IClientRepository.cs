using Cotizacion.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizacion.IRepository
{
    public interface IClientRepository
    {
        IList<Client> GetClients();
        Client GetClient(int id);
    }
}
