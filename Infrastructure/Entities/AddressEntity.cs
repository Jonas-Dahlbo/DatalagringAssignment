using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class AddressEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    [Required, StringLength(100)]
    public string StreetName { get; set; } = null!;
    [Required, StringLength(100)]
    public string City { get; set; } = null!;
    [Required, StringLength(50)]
    public string PostalCode { get; set; } = null!;
}
