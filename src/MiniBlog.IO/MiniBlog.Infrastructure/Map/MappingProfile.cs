using AutoMapper;
using MiniBlog.Domain.Entities;
using MiniBlog.Infrastructure.Model;

namespace MiniBlog.Infrastructure.Map
{
    public static class MappingProfile
    {
        public static MapperConfiguration InitializeAutoMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Post, PostModel>().ReverseMap();
            });

            return config;
        }
    }
}
