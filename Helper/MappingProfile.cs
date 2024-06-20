using AutoMapper;
using MoviesApi.Dtos;
using MoviesApi.Models;
namespace MoviesApi.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDetailsDto>().ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.Genre.Name));
            CreateMap<MovieDto, Movie>()
                .ForMember(src => src.Poster, opt => opt.Ignore());
        }
    }
}
