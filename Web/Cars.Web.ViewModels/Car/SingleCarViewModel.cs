﻿namespace Cars.Web.ViewModels.Car
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AutoMapper;
    using Cars.Data.Models;
    using Cars.Services.Mapping;

    public class SingleCarViewModel : IMapFrom<MyCar>, IHaveCustomMappings
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public string MakeName { get; set; }

        public int MakeId { get; set; }

        public string ModelName { get; set; }

        public string FuelTypeName { get; set; }

        public int FuelTypeId { get; set; }

        public string TransmissionName { get; set; }

        public int TransmissionId { get; set; }

        public double Price { get; set; }

        public string TownName { get; set; }

        public int TownId { get; set; }

        public string ColorName { get; set; }

        public int Mileage { get; set; }

        public string Description { get; set; }

        public string SellersPhoneNumber { get; set; }

        public DateTime CreatedOn { get; set; }

        public string AddedbyUserUserName { get; set; }


        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<MyCar, SingleCarViewModel>()
                .ForMember(x => x.ImageUrl, opt =>
                    opt.MapFrom(x =>
                        x.Images.FirstOrDefault().RemoteImageUrl != null ?
                        x.Images.FirstOrDefault().RemoteImageUrl :
                        "/images/cars/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension));
        }

        public ICollection<Image> Images { get; set; }
    }
}
