using AutoMapper;
using runo.Models.Dtos;
using runo.Models.Entities;

namespace runo.Mappings
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Todo, TodoDto>().ReverseMap();
        }
    }
}
