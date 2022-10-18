using SokolDev.DataAccessAbstractions.Models;
using SokolDev.DataAccessAbstractions.Repositories;

namespace SokolDev.DataAccess.Repositories;

public class BloggingRepository : IBloggingRepository
{
    public BlogModel GetBlogByName(string name)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BlogModel> GetAllBlogs()
    {
        throw new NotImplementedException();
    }

    public void AddBlog(BlogModel blog)
    {
        throw new NotImplementedException();
    }

    public void SaveChanges()
    {
        throw new NotImplementedException();
    }
}