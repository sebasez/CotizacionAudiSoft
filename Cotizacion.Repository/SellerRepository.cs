using Cotizacion.DAL;
using Cotizacion.Entities;
using Cotizacion.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace Cotizacion.Repository
{
    public class SellerRepository : ISellerRepository
    {
        private readonly CotizacionDbContext context;
        public SellerRepository(CotizacionDbContext context)
        {
            this.context = context;
        }
        public Seller GetSeller(int id)
        {
            return context.Sellers.Find(id);
        }

        public IList<Seller> GetSellers()
        {
            return context.Sellers.ToList();
        }
    }
}
