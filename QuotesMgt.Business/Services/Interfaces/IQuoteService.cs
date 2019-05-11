using QuotesMgt.Contracts;
using System.Collections.Generic;

namespace QuotesMgt.Business.Services.Interfaces
{
    public interface IQuoteService
    {
        void Add(Quote quote);

        IEnumerable<Quote> List();

        Quote Get(int id);
    }
}