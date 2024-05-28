using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Phonebook;
internal class ContactContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default"));
    }
}
