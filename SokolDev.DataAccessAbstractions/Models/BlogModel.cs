namespace SokolDev.DataAccessAbstractions.Models;

public class BlogModel
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    public List<PostModel> Posts { get; set; } = new();
}