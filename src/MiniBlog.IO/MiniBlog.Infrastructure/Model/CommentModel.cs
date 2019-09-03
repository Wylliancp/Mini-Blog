using MiniBlog.Infrastructure.Model.Base;

namespace MiniBlog.Infrastructure.Model
{
    public class CommentModel : BaseModel
    {
        public string Text { get; set; }
        public PostModel Post { get; set; }
    }
}
