using System.ComponentModel.DataAnnotations.Schema;

namespace SokolDev.DataAccess.Entities;

public class UserAddress
{
    [Column("AddressId")]
    public int Id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    // Using fluent api for a convention behavior redefining. Just for tests
    [Column("IndexCode")]
    public string PostalCode { get; set; }
    public string Building { get; set; }
    public string Housing { get; set; }
    public string Flat  { get; set; }
}