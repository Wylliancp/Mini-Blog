using AutoMapper;
using MiniBlog.Domain.Entities;
using MiniBlog.Infrastructure.Model;

namespace MiniBlog.Infrastructure.Map
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostModel>().ReverseMap();
            CreateMap<Author, AuthorModel>().ReverseMap();
            CreateMap<Comment, CommentModel>().ReverseMap();
            //        .ForMember(dest => dest.Id, s => s.MapFrom(o => o.Id))
            //        .ForMember(dest => dest.Created, s => s.MapFrom(o => o.Created))
            //        .ForMember(dest => dest.Modified, s => s.MapFrom(o => o.Modified))
            //        .ForMember(dest => dest.IsDeleted, s => s.MapFrom(o => o.IsDeleted))
            //        .ForMember(dest => dest.Title, s => s.MapFrom(o => o.Title))
            //        .ForMember(dest => dest.Text, s => s.MapFrom(o => o.Text))
            //        .ForMember(dest => dest.LikesCount, s => s.MapFrom(o => o.LikesCount));

            //CreateMap<PostModel, Post>()
            //        .ForMember(dest => dest.Id, s => s.MapFrom(o => o.Id))
            //        .ForMember(dest => dest.Created, s => s.MapFrom(o => o.Created))
            //        .ForMember(dest => dest.Modified, s => s.MapFrom(o => o.Modified))
            //        .ForMember(dest => dest.IsDeleted, s => s.MapFrom(o => o.IsDeleted))
            //        .ForMember(dest => dest.Title, s => s.MapFrom(o => o.Title))
            //        .ForMember(dest => dest.Text, s => s.MapFrom(o => o.Text))
            //        .ForMember(dest => dest.LikesCount, s => s.MapFrom(o => o.LikesCount));
        }
    }
}
