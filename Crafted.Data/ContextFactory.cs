using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Crafted.Data
{
    public class ContextFactory : IDesignTimeDbContextFactory<CraftedContext>
    {
        public CraftedContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CraftedContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CraftedDb;uid=SA;pwd=Pass@word;timeout=100000;");

            return new CraftedContext(optionsBuilder.Options);
        }
    }
}
