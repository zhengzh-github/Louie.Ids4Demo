using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Louie.Ids4Demo.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class Ids4DemoDbContextFactory : IDesignTimeDbContextFactory<Ids4DemoDbContext>
    {
        public Ids4DemoDbContext CreateDbContext(string[] args)
        {
            Ids4DemoEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<Ids4DemoDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new Ids4DemoDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Louie.Ids4Demo.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
