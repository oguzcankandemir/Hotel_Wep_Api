using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();

        }
    }
}
