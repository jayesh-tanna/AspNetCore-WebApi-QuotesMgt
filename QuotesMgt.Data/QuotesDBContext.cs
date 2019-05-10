using Microsoft.EntityFrameworkCore;
using QuotesMgt.Contracts;

namespace QuotesMgt.Data
{
    public class QuotesDBContext : DbContext
    {

        public QuotesDBContext(DbContextOptions<QuotesDBContext> options) : base(options)
        {

        }

        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}