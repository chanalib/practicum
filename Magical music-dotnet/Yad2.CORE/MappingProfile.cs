using AutoMapper;
using MagicalMusic.CORE.DTOs;
using MagicalMusic.CORE.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Creator, CreatorDTO>().ReverseMap();
        CreateMap<Song, SongDTO>().ReverseMap();
        CreateMap<UserDTO, User>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}")) // מיפוי מותאם
            .ReverseMap();
    }
}
