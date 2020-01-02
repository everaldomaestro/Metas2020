using AutoMapper;
using Metas2020.Domain.Entity;
using Metas2020.Models;

namespace Metas2020.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Meta, CriarMetaViewModel>().ReverseMap();
        }
    }
}
