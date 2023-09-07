namespace Cars.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Cars.Data.Models;

    public class MakesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Makes.Any())
            {
                return;
            }

            HashSet<string> makes = new HashSet<string>
            { "Alfa Romeo", "Aston Martin", "Audi", "Bentley",
            "BMW", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Citroen", "Dacia", "Dodge", "Ferrari",
            "Fiat", "Ford", "Honda", "Hummer", "Hyundai", "Infiniti", "Isuzu", "Jaguar", "Jeep", "Kia",
            "Lamborghini", "Lancia", "Land Rover", "Lexus", "Maserati", "Mazda",
            "Mercedes-Benz", "Mini", "Mitsubishi", "Nissan", "Opel", "Peugeot", "Porsche",
            "Renault", "Saab", "Seat", "Skoda", "Smart", "Subaru", "Suzuki", "Tesla", "Toyota", "Volkswagen",
            "Volvo", };

            foreach (string make in makes)
            {
                await dbContext.Makes.AddAsync(new Make { Name = make });
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
