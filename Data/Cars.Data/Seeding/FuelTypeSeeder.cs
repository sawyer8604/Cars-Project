﻿namespace Cars.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Cars.Data.Models;

    public class FuelTypeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.FuelTypes.Any())
            {
                return;
            }
            await dbContext.FuelTypes.AddAsync(new FuelType { Name = "Gasoline" });

            await dbContext.FuelTypes.AddAsync(new FuelType { Name = "Diesel" });

            await dbContext.FuelTypes.AddAsync(new FuelType { Name = "Compressed Natural Gas (CNG)" });

            await dbContext.FuelTypes.AddAsync(new FuelType { Name = "LPG" });

            await dbContext.FuelTypes.AddAsync(new FuelType { Name = "Ethanol or Methanol" });

            await dbContext.FuelTypes.AddAsync(new FuelType { Name = "Hybrid" });

            await dbContext.FuelTypes.AddAsync(new FuelType { Name = "Electric" });

            await dbContext.SaveChangesAsync();
        }
    }
}
