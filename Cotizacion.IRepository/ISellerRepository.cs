using Cotizacion.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizacion.IRepository
{
    public interface ISellerRepository
    {
        IList<Seller> GetSellers();
        Seller GetSeller(int id);
    }
}
