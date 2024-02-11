using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class CustomerEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    [Required, StringLength(100)]
    public string FirstName { get; set; } = null!;
    [Required, StringLength(100)]
    public string LastName { get; set; } = null!;
    public string? PhoneNumber { get; set; }

    public string AddressId { get; set; } = null!;
    public AddressEntity Address { get; set; } = null!;
}
