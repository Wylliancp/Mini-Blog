using AutoMapper;
using MiniBlog.Domain.Entities;
using MiniBlog.Infrastructure.Model;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Linq;

namespace MiniBlog.Infrastructure.Map
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<List<ObjectId>, List<string>>().ConvertUsing(o => o.Select(os => os.ToString()).ToList());
            CreateMap<List<string>, List<ObjectId>>().ConvertUsing(o => o.Select(os => ObjectId.Parse(os)).ToList());
            CreateMap<ObjectId, string>().ConvertUsing(o => o.ToString());
            CreateMap<string, ObjectId>().ConvertUsing(s => ObjectId.Parse(s));
            CreateMap<Post, PostModel>().ReverseMap();
            CreateMap<Author, AuthorModel>().ReverseMap();
            CreateMap<Comment, CommentModel>().ReverseMap();
            
        }
    }
}
