using ApiRest.Data.Dtos;
using ApiRest.Models;
using AutoMapper;

namespace ApiRest.Profiles
{
    public class DiretorProfile : Profile
    {
        public DiretorProfile()
        {
            CreateMap<Diretor, ReadDiretorDto>();
            CreateMap<CreateDiretorDto, Diretor>();
            CreateMap<UpdateDiretorDto, Diretor>();
        }
    }
}