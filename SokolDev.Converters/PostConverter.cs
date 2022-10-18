using SokolDev.DataAccess.Entities;
using SokolDev.DataAccessAbstractions.Models;

namespace SokolDev.Converters;

public static class PostConverter
{
    public static PostModel FromEntityToModel(this Post postEntity, BlogModel blogModel)
    {
        var result = new PostModel
        {
            BlogId = postEntity.BlogId,
            Content = postEntity.Content,
            PostId = postEntity.PostId,
            Title = postEntity.Title,
            Blog = blogModel ?? new BlogModel()
        };

        return result;
    }
}