namespace Cars.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Cars.Data.Models;

    public class ModelsSeeder : ISeeder
    {
        HashSet<string> astonMartin = new HashSet<string>
        {
            "Cygnet Hatchback", "DB11 Coupe", "B11 Volante Convertible", "DB9 Coupe", "DBS Volante Convertible",
            "DBX Base SUV", "Vanquish 2+2 Coupe", "Vantage Coupe", "Vantage V8 Coupe", "Virage Coupe",
        };

        HashSet<string> audi = new HashSet<string>
        {
            "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "e-tron", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "Q8",
            "R8", "RS 3", "RS 5", "RS 6", "RS 7", "S3", "S4", "S5", "S6", "S7", "S8", "SQ2", "SQ5", "SQ7", "TT",
            "TTS",
        };

        HashSet<string> bmw = new HashSet<string>
        {
            "1-Series", "2-Series", "3-Series", "4-Series", "5-Series", "6-Series", "7-Series", "8-Series",
            "i3", "i4", "i7", "i8", "iX1", "iX3", "iX", "M2", "M3", "M4", "M5", "M6", "M8", "X1", "X2", "X3",
            "X4", "X5", "X6", "X7", "Z4",
        };

        HashSet<string> bentley = new HashSet<string>
        {
            "Bentayga 4wd SUV", "Bentayga SUV", "Continental Flying Spur", "Continental GTC", "Continental GT",
        };

        HashSet<string> cadillac = new HashSet<string>
        {
            "ATS", "CT4", "CT5", "CT6", "CTS", "Escalade ESV", "Escalade ESV", "Escalade Hybrid", "Escalade",
            "Lyriq", "SRX", "XT4", "XT5", "XT6", "XTS",
        };

        HashSet<string> alfaRomeo = new HashSet<string>
        {
            "4C", "Giulia", "Giulietta", "Mito", "Stelvio", "Tonale",
        };

        HashSet<string> buick = new HashSet<string>
        {
            "Cascada", "Enclave", "Encore", "Envision", "LaCrosse", "Regal", "Verano",
        };

        HashSet<string> chevrolet = new HashSet<string>
        {
            "Volt", "Trax", "Traverse", "Trailblazer", "Tahoe", "Suburban", "SS", "Spark", "Sonic",
            "Silverado", "Orlando", "Malibu", "Impala", "Express", "Equinox", "Cruze", "Corvette",
            "Colorado", "Captiva", "Camaro", "Bolt", "Blazer", "Aveo5",
        };

        HashSet<string> chrysler = new HashSet<string>
        {
            "200", "300C", "300", "Pacifica Hybrid", "Pacifica", "Sebring", "Town and Country", "Voyager LX Minivan",
        };

        HashSet<string> citroen = new HashSet<string>
        {
            "Ami", "Berlingo", "C1", "C2", "C3", "C4", "C5", "C6", "C8",
            "DS3", "DS4", "E-C4", "e-Jumpy", "E-Mehari", "Grand C4 Picasso", "Jumper", "Nemo",
            "Space Tourer", "Xsara Picasso Mini",
        };

        HashSet<string> dacia = new HashSet<string>
        {
            "Dokker", "Duster", "Jogger", "Logan", "Sandero", "Spring",
        };

        HashSet<string> dodge = new HashSet<string>
        {
            "Avenger", "Caravan Minivan", "Challenger", "Charger", "Dart Rallye", "Dart SE", "Durango",
            "Grand Caravan", "Journey American", "Journey Crossroad", "RAM", "Sprinter Passenger",
            "Viper SRT-10", "Viper SRT Convertible",
        };

        HashSet<string> ferrari = new HashSet<string>
        {
            "Roma Convertible", "296 GTS", "GTC4Lusso T", "488 Pista", "Purosangue", "812", "296 GTB",
            "Daytona", "Monza", "F60 America", "F8", "Roma", "GTC4Lusso", "SF90", "125/159 S", "166 Spider Corsa",
            "166 Sport", "195", "212", "288 GTO/F40/F50/Enzo/LaFerrari", "308 GTB/GTS", "360 Spider", "458 Italia",
        };

        HashSet<string> fiat = new HashSet<string>
        {
            "124 Spider", "500 Abarth", "500c Abarth Convertible", "500C", "500e Battery Electric",
            "500e Electric Hatchback", "500 Icon", "500 Hybrid", "500L Living", "500L Trekking",
            "500L Trekking", "500 S8 Star Hatchback", "500X", "Doblo", "E-Doblò", "Fiorino", "Fullback",
            "Panda", "Punto", "Qubo", "Talento", "Tipo",
        };


        HashSet<string> ford = new HashSet<string>
        {
            "Bronco", "C-Max", "E-150", "EcoSport", "Edge", "Escape", "e-Transit", "Expedition", "Explorer",
            "F-150", "F-250", "F-350", "F-450", "Fiesta", "Flex", "Focus", "Fusion",
            "Galaxy", "Grand C-Max", "Grand Tourneo", "KA", "Kuga", "Maverick ", "Mondeo", "Mustang", "Puma",
            "Ranger", "Ranger", "S-Max", "Taurus", "Tourneo", "Transit",
        };


        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Models.Any())
            {
                return;
            }

            foreach (var make in dbContext.Makes)
            {
                if(make.Name == "Audi")
                {
                    await dbContext.Models.AddAsync(new Model { Name = "A3", MakeID = make.Id });
                }

            }

            await dbContext.SaveChangesAsync();
        }
    }
}
