using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class UserEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    [Required, StringLength(100)]
    public string Email { get; set; } = null!;
    [Required, StringLength(100)]
    public string Password { get; set; } = null!;

    public string RoleId { get; set; } = null!;
    public RoleEntity Role { get; set; } = null!;
}
