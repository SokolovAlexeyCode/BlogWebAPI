using SokolDev.DataAccessAbstractions.Models;

namespace SokolDev.DataAccessAbstractions.Repositories
{
    public interface IBloggingRepository
    {
        BlogModel GetBlogByName(string name);
        IEnumerable<BlogModel> GetAllBlogs();
        void AddBlog(BlogModel blog);
        void SaveChanges();
    }
}