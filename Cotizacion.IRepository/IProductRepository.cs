using System;
using System.Collections.Generic;
using System.Text;
using Cotizacion.Entities;

namespace Cotizacion.IRepository
{
    public interface IProductRepository
    {
        IList<Product> GetProducts();
        Product GetProduct(int id);
    }
}
