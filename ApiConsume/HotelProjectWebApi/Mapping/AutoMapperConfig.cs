using AutoMapper;
using HotelProject.Dto.Layer.Dtos.RoomDtos;
using HotelProject.EntityLayer.Concrete;

namespace HotelProjectWebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddRoomDto, Room>();
            CreateMap<Room, AddRoomDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();

        }
    }
}
