namespace Cars.Data.Seeding
{
	using Cars.Data.Models;
	using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

	public class CarColorsSeeder : ISeeder
	{
		public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
		{
			if(dbContext.CarColors == null)
			{
				return;
			}			

			HashSet<string> colors = new HashSet<string>
			{ "Red", "Orange", "Blue", "Green", "Indigo", "Violet", "Purple", "Pink", "Silver",
			"Beige", "Brown", "Grey", "Black", "White"};

			foreach (string color in colors)
			{
				await dbContext.CarColors.AddAsync(new CarColor { Name = color });
			}

			await dbContext.SaveChangesAsync();

		}
	}
}
