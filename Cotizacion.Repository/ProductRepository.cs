using Cotizacion.DAL;
using Cotizacion.Entities;
using Cotizacion.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotizacion.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly CotizacionDbContext context;
        public ProductRepository(CotizacionDbContext context)
        {
            this.context = context;
        }
        public Product GetProduct(int id)
        {
            return context.Products.Find(id);
        }

        public IList<Product> GetProducts()
        {
            return context.Products.ToList();
        }
    }
}
