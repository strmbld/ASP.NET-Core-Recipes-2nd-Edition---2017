using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;


namespace DAL.Context
{
    public class ArtistContextFactory : IDesignTimeDbContextFactory<ArtistContext>
    {
        public ArtistContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ArtistContext> optionsBuilder = new();
            string connectionString =
                "Server=.,5433;Database=EFexample;User ID=sa;Password=P@ssw0rd;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionString);

            return new(optionsBuilder.Options);
        }
    }
}
