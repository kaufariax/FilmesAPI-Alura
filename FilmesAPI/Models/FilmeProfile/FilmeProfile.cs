using AutoMapper;
using FilmesAPI.Models.Dtos;

namespace FilmesAPI.Models.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CriarFilmeDto, Filme>();
            CreateMap<Filme, RetornoFilmeDto>();
            CreateMap<AtualizarFilmeDto, Filme>();
        }
    }
}
