namespace SokolDev.DataAccess.Entities;

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    public List<Post> Posts { get; } = new();

    public int AuthorId { get; set; }
    public  Author Author { get; set; }
}