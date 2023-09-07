namespace Cars.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    using Cars.Data.Models;

    public class TransmissionSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            await dbContext.Transmissions.AddAsync(new Transmission { Name = "Automatic" });

            await dbContext.Transmissions.AddAsync(new Transmission { Name = "Manual" });

            await dbContext.SaveChangesAsync();
        }
    }
}
