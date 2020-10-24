using Cotizacion.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizacion.IRepository
{
    public interface IQuoteRepository
    {
        List<Quote> GetQuotes();
        Quote GetQuote(int id);
        void Save(Quote quote);
    }
}
