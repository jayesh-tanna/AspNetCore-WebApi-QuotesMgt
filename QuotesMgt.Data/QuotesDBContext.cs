using Microsoft.EntityFrameworkCore;
using QuotesMgt.Contracts;

namespace QuotesMgt.Data
{
    public class QuotesDBContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}