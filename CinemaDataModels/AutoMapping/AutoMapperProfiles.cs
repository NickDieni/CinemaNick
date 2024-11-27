using AutoMapper;
using CinemaDataModels.Models.DTO;
using CinemaDataModels.Models.Entities;

namespace CinemaDataModels.AutoMapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // Users
            CreateMap<UpdateUserRequestDto, User>().ReverseMap();
            CreateMap<AddUserRequestDto, User>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();

            // PostalCode
            CreateMap<PostalCode, PostalCodeDto>().ReverseMap();

            // Genre
            CreateMap<Genre, GenreDto>().ReverseMap();

            // Movie
            CreateMap<Movie, MovieDto>().ReverseMap();
        }
    }
}
