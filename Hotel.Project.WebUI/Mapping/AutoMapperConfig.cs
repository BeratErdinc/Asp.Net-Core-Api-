using AutoMapper;
using Hotel.Project.WebUI.Dtos.ServiceDto;
using HotelProject.EntityLayer.Concrete;

namespace Hotel.Project.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
           

        }
    }
}
