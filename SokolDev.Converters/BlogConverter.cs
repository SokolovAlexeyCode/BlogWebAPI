using SokolDev.DataAccess.Entities;
using SokolDev.DataAccessAbstractions.Models;

namespace SokolDev.Converters
{
    public static  class BlogConverter
    {
        public static BlogModel FromEntityToModel(this Blog blogEntity)
        {
            var result = new BlogModel
            {
                BlogId = blogEntity.BlogId,
                Url = blogEntity.Url
            };

            result.Posts = blogEntity.Posts.Select(post => post.FromEntityToModel(result)).ToList();

            return result;
        }
    }
}