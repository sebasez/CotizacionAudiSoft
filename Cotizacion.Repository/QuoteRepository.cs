using Cotizacion.DAL;
using Cotizacion.Entities;
using Cotizacion.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotizacion.Repository
{
    public class QuoteRepository : IQuoteRepository
    {
        private readonly CotizacionDbContext context;
        public QuoteRepository(CotizacionDbContext context)
        {
            this.context = context;
        }
        public Quote GetQuote(int id)
        {
            return context.Quotes.Find(id);
        }

        public List<Quote> GetQuotes()
        {
            return context.Quotes.ToList();
        }

        public void Save(Quote quote)
        {
            context.Quotes.Add(quote);
            context.SaveChanges();
        }
    }
}
