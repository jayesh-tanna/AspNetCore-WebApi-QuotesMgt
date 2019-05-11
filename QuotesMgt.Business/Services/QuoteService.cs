using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuotesMgt.Business.Services.Interfaces;
using QuotesMgt.Contracts;
using QuotesMgt.Data;

namespace QuotesMgt.Business.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly QuotesDBContext _context;

        public QuoteService(QuotesDBContext context)
        {
            _context = context;
        }

        public void Add(Quote quote)
        {
            _context.Add<Quote>(quote);
            _context.SaveChanges();
        }

        public Quote Get(int id)
        {
            return _context.Quotes.Include(x => x.Author).First(x => x.Id == id);
        }

        public IEnumerable<Quote> List()
        {
            return _context.Quotes;
        }
    }
}