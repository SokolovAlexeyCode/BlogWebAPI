using System.Reflection.Metadata;

namespace SokolDev.DataAccessAbstractions.Models;

public class PostModel
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public BlogModel Blog { get; set; }
}