using Microsoft.EntityFrameworkCore;
using KayakerApp.Domain;

namespace KayakerApp.Data
{
    public class KayakerContext:DbContext
    {
        public DbSet<Kayaker> Kayakers { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }
    }
}
