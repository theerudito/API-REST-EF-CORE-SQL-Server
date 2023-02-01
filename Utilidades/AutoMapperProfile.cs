using AutoMapper;
using EF_SQL_Server.DTO;
using EF_SQL_Server.Models;

namespace EF_SQL_Server.Utilidades
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Naruto_DTO, Naruto>();
            CreateMap<JutsuDTO, Jutsu>();
        }
    }
}
