using AutoMapper;
using CinemaDataModels.Models.DTO;
using CinemaDataModels.Models.DTO.Sub_Address;
using CinemaDataModels.Models.DTO.Sub_Genre;
using CinemaDataModels.Models.DTO.Sub_Seat;
using CinemaDataModels.Models.DTO.Sub_Showtime;
using CinemaDataModels.Models.DTO.Sub_Theater;
using CinemaDataModels.Models.DTO.Sub_Ticket;
using CinemaDataModels.Models.DTO.Sub_PostalCode;
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
            CreateMap<AddPostCodeRequestDto, PostalCode>().ReverseMap();

            // Genre
            CreateMap<Genre, GenreDto>().ReverseMap();
            CreateMap<AddGenreRequestDto, Genre>().ReverseMap();

            // Movie
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<AddMovieRequestDto, Movie>().ReverseMap();
            CreateMap<UpdateMovieRequestDto, Movie>().ReverseMap();

            // Address
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<AddAddressRequestDto, Address>().ReverseMap();
            CreateMap<UpdateAddressRequestDto, Address>().ReverseMap();

            // Theater
            CreateMap<Theater, TheaterDto>().ReverseMap();
            CreateMap<AddTheaterRequestDto, Theater>().ReverseMap();    
            CreateMap<UpdateTheaterRequestDto, Theater>().ReverseMap();

            // Showtime
            CreateMap<Showtime, ShowtimeDto>().ReverseMap();

            // Ticket
            CreateMap<Ticket, TicketDto>().ReverseMap();

            // Seat
            CreateMap<Seat, SeatDto>().ReverseMap();
            CreateMap<AddSeatRequestDto, Seat>().ReverseMap();

        }
    }
}
