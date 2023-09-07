namespace Cars.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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

        HashSet<string> honda = new HashSet<string>
        {
            "Accord", "Civic", "Clarity", "Crosstour", "CR-V", "CR-Z", "Element", "Fit", "HR-V",
            "Insight", "Jaaz", "Odyssey", "Passport", "Pilot", "Ridgeline", "Ridgeline",
        };

        HashSet<string> hummer = new HashSet<string>
        {
            "H2 Alpha", "H2 SUT",
        };

        HashSet<string> hyundai = new HashSet<string>
        {
            "Accent", "Elantra", "Genesis", "Grand Santa Fe", "i10", "i20", "i30",
            "Ioniq", "Kona", "Palisade", "Sonata", "Tucson",
        };

        HashSet<string> infiniti = new HashSet<string>
        {
            "G37", "M35", "Q30", "Q50", "Q60", "Q70", "QX60",
            "QX70", "QX80",
        };

        HashSet<string> isuzu = new HashSet<string>
        {
            "D-Max", "D-Max",
        };

        HashSet<string> jaguar = new HashSet<string>
        {
            "E-Pace", "F-Type", "I-PACE", "XE", "XF", "XJ", "XKR",
        };

        HashSet<string> jeep = new HashSet<string>
        {
            "Cherokee", "Compass", "Gladiator", "Grand Cherokee", "Patriot Latitude", "Renegade ",
            "Wrangler",
        };

        HashSet<string> kia = new HashSet<string>
        {
            "Carnival", "Ceed", "Forte5", "Niro", "Optima", "Picanto", "Rio",
            "Sedona", "Sorento", "Soul", "Sportage", "Stinger",
        };

        HashSet<string> lamborghini = new HashSet<string>
        {
            "Huracan", "Urus", "Aventador",
        };

        HashSet<string> lancia = new HashSet<string>
        {
            "Delta", "Ypsilon",
        };

        HashSet<string> landRover = new HashSet<string>
        {
            "Defender", "Discovery", "Range Rover",
        };

        HashSet<string> lexus = new HashSet<string>
        {
            "CT Executive", "ES", "GS", "GX", "IS", "LC", "LS",
            "NX", "RC", "RX", "UX", "RZ",
        };

        HashSet<string> maserati = new HashSet<string>
        {
            "Ghibli", "GranCabrio", "GranTurismo", "Grecale", "Levante", "Quattroporte",
        };


        HashSet<string> mazda = new HashSet<string>
        {
            "CX-3", "CX-5", "CX-7", "CX-9", "Mazda2", "Mazda3", "Mazda5",
            "MX-5 Miata", "Tribute ",
        };

        HashSet<string> mercedes = new HashSet<string>
        {
            "A-Class", "AMG GT", "B-Class", "C-Class", "Citan", "CLA-Class", "E-Class",
            "EQE", "G-Class", "GLA", "GLC", "Maybach", "S-Class",
            "Sprinter", "Vito", "C Class AMG Line Wagon",
        };

        HashSet<string> mini = new HashSet<string>
        {
            "Clubman", "Cooper", "Countryman", "Hardtop", "MINI Electric",
        };

        HashSet<string> mitsubishi = new HashSet<string>
        {
            "ASX", "Eclipse", "L200", "Lancer", "Mirage", "Outlander", "Space Star",
        };

        HashSet<string> nissan = new HashSet<string>
        {
            "370Z", "Altima", "Ariya", "Armada", "Frontier", "GT-R", "Maxima",
            "Micra", "Murano", "Pathfinder", "Qashqai", "Rogue", "X-Trail",
        };

        HashSet<string> opel = new HashSet<string>
        {
            "Adam", "Astra", "Cascada", "Combo", "Corsa", "Crossland", "Grandland",
            "Insignia", "Mokka", "Vivaro", "Zafira",
        };

        HashSet<string> peugeot = new HashSet<string>
        {
            "108", "2008", "208", "3008", "308", "5008", "508",
            "Boxer", "Partner", "Rifter", "Traveller",
        };

        HashSet<string> porsche = new HashSet<string>
        {
            "718 Boxster", "911 Carrera", "Boxster", "Cayenne", "Macan", "Panamera", "Taycan",
        };

        HashSet<string> renault = new HashSet<string>
        {
            "Alaskan", "Arkana", "Captur", "Clio", "Grand Scenic", "Kangoo", "Koleos",
            "Megane", "Talisman", "Trafic", "Twingo",
        };

        HashSet<string> saab = new HashSet<string>
        {
            "9-3", "9-5", "9-7X",
        };

        HashSet<string> seat = new HashSet<string>
        {
            "Alhambra", "Altea", "Arona", "Ibiza", "Leon", "Tarraco",
        };

        HashSet<string> skoda = new HashSet<string>
        {
            "Citigo", "Enyaq", "Fabia", "Kamiq", "Kodiaq", "Octavia", "Rapid",
            "Superb", "Yeti",
        };

        HashSet<string> smart = new HashSet<string>
        {
            "EQ", "ForFour", "ForTwo",
        };

        HashSet<string> subaru = new HashSet<string>
        {
            "Ascent", "BRZ", "Crosstrek", "Forester", "Impreza", "Legacy", "Outback",
            "WRX", "XV",
        };

        HashSet<string> suzuki = new HashSet<string>
        {
            "Baleno", "Celerio", "Equator", "Grand Vitara", "Ignis", "Jimny", "Swift",
            "SX4", "Vitara",
        };

        HashSet<string> tesla = new HashSet<string>
        {
            "Model S", "Model 3 Performance", "Model X", "Model Y",
        };

        HashSet<string> toyota = new HashSet<string>
        {
            "4Runner", "Auris", "Avalon", "Avensis", "Aygo", "Camry", "C-HR",
            "Corolla", "Supra", "Highlander", "Hilux", "Land Cruiser", "Mirai",
            "Prius", "Proace", "RAV4", "Sienna", "Tacoma", "Tundra", "Yaris",
        };

        HashSet<string> volkswagen = new HashSet<string>
        {
            "Amarok", "Arteon", "Atlas", "Beetle ", "Caddy", "Caravelle", "CC",
            "Crafter", "e-Golf", "Golf", "ID.4", "Jetta", "Multivan",
            "Passat", "Polo", "Sharan", "T-Cross", "Tiguan", "Touareg", "Touran",
            "Transporter", "T-Roc", "UP ",
        };


        HashSet<string> volvo = new HashSet<string>
        {
            "C30", "C40", "S60", "S90", "V40", "V60", "V90",
            "XC40", "XC60", "XC90",
        };



        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Models.Any())
            {
                return;
            }

            foreach (var make in dbContext.Makes)
            {
                switch (make.Name)
                {
                    case "Alfa Romeo":

                        await AddModels(dbContext, make, alfaRomeo);

                        break;

                    case "Aston Martin":

                        await AddModels(dbContext, make, astonMartin);

                        break;

                    case "Audi":

                        await AddModels(dbContext, make, audi);

                        break;

                    case "Bentley":

                        await AddModels(dbContext, make, bentley);

                        break;

                    case "BMW":

                        await AddModels(dbContext, make, bmw);

                        break;

                    case "Buick":

                        await AddModels(dbContext, make, buick);

                        break;

                    case "Cadillac":

                        await AddModels(dbContext, make, cadillac);

                        break;

                    case "Chevrolet":

                        await AddModels(dbContext, make, chevrolet);

                        break;

                    case "Chrysler":

                        await AddModels(dbContext, make, chrysler);

                        break;

                    case "Citroen":

                        await AddModels(dbContext, make, citroen);

                        break;

                    case "Dacia":

                        await AddModels(dbContext, make, dacia);

                        break;

                    case "Dodge":

                        await AddModels(dbContext, make, dodge);

                        break;

                    case "Ferrari":

                        await AddModels(dbContext, make, ferrari);

                        break;

                    case "Fiat":

                        await AddModels(dbContext, make, fiat);

                        break;

                    case "Ford":

                        await AddModels(dbContext, make, ford);

                        break;

                    case "Honda":

                        await AddModels(dbContext, make, honda);

                        break;

                    case "Hummer":

                        await AddModels(dbContext, make, hummer);

                        break;

                    case "Hyundai":

                        await AddModels(dbContext, make, hyundai);

                        break;

                    case "Infiniti":

                        await AddModels(dbContext, make, infiniti);

                        break;

                    case "Isuzu":

                        await AddModels(dbContext, make, isuzu);

                        break;

                    case "Jaguar":

                        await AddModels(dbContext, make, jaguar);

                        break;

                    case "Jeep":

                        await AddModels(dbContext, make, jeep);

                        break;

                    case "Kia":

                        await AddModels(dbContext, make, kia);

                        break;

                    case "Lamborghini":

                        await AddModels(dbContext, make, lamborghini);

                        break;

                    case "Lancia":

                        await AddModels(dbContext, make, lancia);

                        break;

                    case "Land Rover":

                        await AddModels(dbContext, make, landRover);

                        break;

                    case "Lexus":

                        await AddModels(dbContext, make, lexus);

                        break;

                    case "Maserati":

                        await AddModels(dbContext, make, maserati);

                        break;

                    case "Mazda":

                        await AddModels(dbContext, make, mazda);

                        break;

                    case "Mercedes-Benz":

                        await AddModels(dbContext, make, mercedes);

                        break;

                    case "Mini":

                        await AddModels(dbContext, make, mini);

                        break;

                    case "Mitsubishi":

                        await AddModels(dbContext, make, mitsubishi);

                        break;

                    case "Nissan":

                        await AddModels(dbContext, make, nissan);

                        break;

                    case "Opel":

                        await AddModels(dbContext, make, opel);

                        break;

                    case "Peugeot":

                        await AddModels(dbContext, make, peugeot);

                        break;

                    case "Porsche":

                        await AddModels(dbContext, make, porsche);

                        break;

                    case "Renault":

                        await AddModels(dbContext, make, renault);

                        break;

                    case "Saab":

                        await AddModels(dbContext, make, saab);

                        break;

                    case "Seat":

                        await AddModels(dbContext, make, seat);

                        break;

                    case "Skoda":

                        await AddModels(dbContext, make, skoda);

                        break;

                    case "Smart":

                        await AddModels(dbContext, make, smart);

                        break;

                    case "Subaru":

                        await AddModels(dbContext, make, subaru);

                        break;

                    case "Suzuki":

                        await AddModels(dbContext, make, suzuki);

                        break;

                    case "Tesla":

                        await AddModels(dbContext, make, tesla);

                        break;

                    case "Toyota":

                        await AddModels(dbContext, make, toyota);

                        break;

                    case "Volkswagen":

                        await AddModels(dbContext, make, volkswagen);

                        break;

                    case "Volvo":

                        await AddModels(dbContext, make, volvo);

                        break;
                }
            }

            await dbContext.SaveChangesAsync();
        }

        private async Task AddModels(ApplicationDbContext dbContext, Make make, HashSet<string> models)
        {
            foreach (var model in models)
            {
                await dbContext.Models.AddAsync(new Model { Name = model, MakeID = make.Id });
            }
        }
    }
}
