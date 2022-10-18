using System.ComponentModel.DataAnnotations.Schema;

namespace SokolDev.DataAccess.Entities;

public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public string NickName { get; set; }


    [NotMapped] // ignoring property for mapping to database
    public string Alias { get; set; }
    public DateTime BirthDay{ get; set; }
}